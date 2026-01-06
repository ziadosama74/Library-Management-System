#ifndef LIBRARIAN_H
#define LIBRARIAN_H

#include "Person.h"
#include <iostream>

class Librarian : public Person {
public:
    Librarian(int id, string n, string e, string p)
        : Person(id, n, e, p, "Librarian") {}

    void addBook() {
        cout << "Book added\n";
    }

    void editBook() {
        cout << "Book edited\n";
    }

    void deleteBook() {
        cout << "Book deleted\n";
    }

    void generateReports() {
        cout << "Reports generated\n";
    }
};

#endif
