#ifndef REPORT_H
#define REPORT_H

#include <iostream>
#include <string>
#include <ctime>
using namespace std;

class Report {
private:
    string reportType;
    string generatedDate;

public:
    Report(string type) : reportType(type) {
        time_t now = time(0);
        generatedDate = ctime(&now);
    }

    void generateBorrowedBooksReport() {
        cout << "Borrowed books report generated\n";
    }

    void generateLateBooksReport() {
        cout << "Late books report generated\n";
    }
};

#endif
