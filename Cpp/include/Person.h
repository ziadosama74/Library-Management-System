#ifndef PERSON_H
#define PERSON_H

#include <iostream>
#include <string>
using namespace std;

class Person {
protected:
    int userId;
    string name;
    string email;
    string password;
    string role;

public:
    Person(int id, string n, string e, string p, string r)
        : userId(id), name(n), email(e), password(p), role(r) {}

    virtual void login(string e, string p) {
        if (email == e && password == p)
            cout << name << " logged in successfully\n";
        else
            cout << "Login failed\n";
    }

    virtual void logout() {
        cout << name << " logged out\n";
    }

    virtual ~Person() {}
};

#endif
