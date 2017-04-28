#include "transferto.h"
#include "ui_transferto.h"

TransferTo::TransferTo(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::TransferTo)
{
    ui->setupUi(this);

    ui->TasksFrame->installEventFilter(this);
    ui->backButton->setVisible(false);
    ui->nextButton->setVisible(false);

    tcpServer = new QTcpServer();

    connect(tcpServer, SIGNAL(newConnection()), this, SLOT(tcpServerNewConnection()));
}

TransferTo::~TransferTo()
{
    delete ui;
}

void TransferTo::on_cancelButton_clicked()
{
    this->close();
}

bool TransferTo::eventFilter(QObject *obj, QEvent *e) {
    if (obj == ui->TasksFrame) {
        if (e->type() == QEvent::Paint) {
            QPaintEvent* event = (QPaintEvent*) e;
            QPainter painter(ui->TasksFrame);
            painter.setPen(ui->TasksFrame->palette().color(QPalette::WindowText));
            painter.drawLine(0, 0, ui->TasksFrame->width(), 0);
        }
    }
    return false;
}

void TransferTo::on_useNetwork_clicked()
{
    ui->pages->setCurrentIndex(NetworkSetup);
}

void TransferTo::on_pages_currentChanged(int arg1)
{
    if (tcpServer->isListening()) {
        tcpServer->pauseAccepting();
    }
    switch (arg1) {
        case TransferType:
            ui->backButton->setVisible(false);
            ui->nextButton->setVisible(false);
            break;
        case DriveSelect:
            ui->backButton->setVisible(true);
            ui->nextButton->setVisible(true);
            break;
        case NetworkSetup:
            ui->backButton->setVisible(true);
            ui->nextButton->setVisible(false);

            setupNetworkScreen();
            break;
    }
}

void TransferTo::setupNetworkScreen() {
#ifdef Q_OS_LINUX
    for (QNetworkInterface interface : QNetworkInterface::allInterfaces()) {
        if (!(interface.flags() & QNetworkInterface::IsLoopBack)) {
            qintptr ipAddr = interface.addressEntries().first().ip().toIPv4Address();
            if (qFromLittleEndian(ipAddr) != ipAddr) {
                ipAddr = qToLittleEndian(ipAddr);
            }

            QString text = QString("%1").arg(ipAddr, 10, 10, QChar('0')).insert(5, " ") + " ";

            qsrand(QDateTime::currentMSecsSinceEpoch());
            QString cryptoKey = QString("%1").arg(qrand() % 100000, 5, 10, QChar('0')); //Get another random 5 digit number to use as encryption key
            encryptionKey = QCryptographicHash::hash(cryptoKey.toUtf8(), QCryptographicHash::Sha256);
            text.append(cryptoKey);

            QCA::SymmetricKey key(encryptionKey);

            //Prepare encryption cipher
            QByteArray initVector;
            initVector.append(1);
            initVector.append(2);
            initVector.append(3);
            initVector.append(4);
            initVector.append(5);
            initVector.append(6);
            initVector.append(7);
            initVector.append(8);
            initVector.append(9);
            initVector.append(10);
            initVector.append(11);
            initVector.append(12);
            initVector.append(13);
            initVector.append(14);
            initVector.append(15);
            initVector.append(16);
            QCA::InitializationVector iv(initVector);

            encryptionCipher = new QCA::Cipher(QString("aes256"), QCA::Cipher::CBC, QCA::Cipher::DefaultPadding, QCA::Decode, key, iv);

            ui->NumberCode->setText(text);
        }
    }
#else
#error "theHop can't be compiled for this platform."
#endif
    tcpServer->listen(QHostAddress::Any, 26160);
}

void TransferTo::on_backButton_clicked()
{
    switch (ui->pages->currentIndex()) {
        case DriveSelect:
        case NetworkSetup:
            ui->pages->setCurrentIndex(TransferType);
            break;
        default:
            ui->pages->setCurrentIndex(ui->pages->currentIndex() - 1);
            break;
    }
}

void TransferTo::tcpServerNewConnection() {
    dataSocket = tcpServer->nextPendingConnection();

    connect(dataSocket, &QTcpSocket::readyRead, [=] {
        QByteArray encData(dataSocket->readAll());

        //Decrypt everything
        QByteArray data = encryptionCipher->process(encData).toByteArray();

        qDebug() << data;
    });
    tcpServer->pauseAccepting();
}
