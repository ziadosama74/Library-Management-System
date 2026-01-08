#ifndef LOAN_H
#define LOAN_H

#include <iostream>
#include <string>
using namespace std;

class Loan {
private:
    int loanId;
    string borrowDate;
    string returnDate;
    string dueDate;
    double fine;

public:
    Loan(int id, string borrow, string due)
        : loanId(id), borrowDate(borrow),
          dueDate(due), fine(0.0) {}

    double calculateFine() {
        fine = 10.0;
        return fine;
    }

    void closeLoan() {
        cout << "Loan closed\n";
    }
};

#endif
