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
            ui->nextButton->setVisible(true);

            setupNetworkScreen();
            break;
    }
}

void TransferTo::setupNetworkScreen() {
#ifdef Q_OS_LINUX

#else
#error "theHop can't be compiled for this platform."
#endif

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
