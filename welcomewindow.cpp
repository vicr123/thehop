#include "welcomewindow.h"
#include "ui_welcomewindow.h"

WelcomeWindow::WelcomeWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::WelcomeWindow)
{
    ui->setupUi(this);
}

WelcomeWindow::~WelcomeWindow()
{
    delete ui;
}

void WelcomeWindow::on_TransferToButton_clicked()
{
    TransferTo* transfer = new TransferTo();
    transfer->showFullScreen();
    transfer->exec();
    transfer->deleteLater();
}

void WelcomeWindow::on_exitButton_clicked()
{
    this->close();
}
