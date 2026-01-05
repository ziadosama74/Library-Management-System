#ifndef ADMIN_H
#define ADMIN_H

#include "Person.h"

class Admin : public Person {
public:
    Admin(int id, string n, string e, string p)
        : Person(id, n, e, p, "Admin") {}

    void addUser() {
        cout << "Admin added a user\n";
    }

    void removeUser() {
        cout << "Admin removed a user\n";
    }
};

#endif
