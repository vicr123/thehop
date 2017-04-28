#ifndef TRANSFERTO_H
#define TRANSFERTO_H

#include <QDialog>
#include <QFrame>
#include <QEvent>
#include <QPaintEvent>
#include <QPainter>
#include "animatedstackedwidget.h"
#include <QPushButton>
#include <QNetworkInterface>

namespace Ui {
class TransferTo;
}

class TransferTo : public QDialog
{
    Q_OBJECT

public:
    explicit TransferTo(QWidget *parent = 0);
    ~TransferTo();

    enum pages {
        TransferType = 0,

        //Transferring using drive
        DriveSelect,

        //Transferring using network
        NetworkSetup
    };

private slots:
    void on_cancelButton_clicked();

    void on_useNetwork_clicked();

    void on_pages_currentChanged(int arg1);

    void on_backButton_clicked();

    void setupNetworkScreen();

private:
    Ui::TransferTo *ui;

    bool eventFilter(QObject *obj, QEvent *e);
};

#endif // TRANSFERTO_H
