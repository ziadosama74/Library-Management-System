#ifndef MEMBER_H
#define MEMBER_H

#include "Person.h"
#include "Book.h"
#include <iostream>

class Member : public Person {
private:
    double fineAmount;

public:
    Member(int id, string n, string e, string p)
        : Person(id, n, e, p, "Member"), fineAmount(0.0) {}

    void borrowBook(Book& book) {
        if (book.isAvailable()) {
            book.borrow();
            cout << "Book borrowed\n";
        } else {
            cout << "Book not available\n";
        }
    }

    void returnBook(Book& book) {
        book.returnBook();
        cout << "Book returned\n";
    }

    void viewFine() {
        cout << "Total fine: " << fineAmount << endl;
    }
};

#endif
