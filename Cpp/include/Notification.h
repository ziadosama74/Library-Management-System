#ifndef NOTIFICATION_H
#define NOTIFICATION_H

#include <iostream>
#include <string>
#include <ctime>

using namespace std;

class Notification {
private:
    int notificationId;
    string message;
    string date;

public:
    Notification(int id, string msg)
        : notificationId(id), message(msg) {
        time_t now = time(0);
        date = ctime(&now);
    }

    void sendNotification() {
        cout << "Notification sent: " << message << endl;
    }
};

#endif
