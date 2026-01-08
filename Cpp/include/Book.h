#ifndef BOOK_H
#define BOOK_H

#include <iostream>
#include <string>
using namespace std;

class Book {
private:
    int bookNumber;
    string title;
    string author;
    string category;
    int totalCopies;
    int availableCopies;

public:
    Book(int num, string t, string a, string c, int total)
        : bookNumber(num), title(t), author(a),
          category(c), totalCopies(total),
          availableCopies(total) {}

    bool isAvailable() {
        return availableCopies > 0;
    }

    void updateBook() {
        cout << "Book updated\n";
    }

    void borrow() {
        if (availableCopies > 0)
            availableCopies--;
    }

    void returnBook() {
        if (availableCopies < totalCopies)
            availableCopies++;
    }
};

#endif
