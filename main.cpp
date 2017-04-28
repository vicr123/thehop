#include "welcomewindow.h"
#include <QApplication>
#include <QtCrypto/QtCrypto>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);

    QCA::init();

    WelcomeWindow w;
    w.show();

    return a.exec();
}
