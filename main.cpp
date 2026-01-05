#include <iostream>
#include <conio.h>


#include "Admin.h"
#include "Librarian.h"
#include "Member.h"
#include "Book.h"
#include "MyLibrary.h"

using namespace std;

void hideCursor()
{
    cout << "\033[?25l";
}

void resetScreen()
{
    textattr(0x07);
    clrscr();
}

void drawMenu(const char menu[][20], int size, int cur)
{
    resetScreen();

    for (int i = 0; i < size; i++)
    {
        if (i == cur)
            textattr(0x70); //highlighted
        else
            textattr(0x07);

        gotoxy(50, i * 3 + 10);
        cout << menu[i];
    }

    textattr(0x07);
}

int navigateMenu(const char menu[][20], int size)
{
    int cur = 0;
    char ch;

    while (true)
    {
        drawMenu(menu, size, cur);
        ch = _getch();

        if (ch == 0 || ch == -32 || ch == 224)
        {
            ch = _getch();
            switch (ch)
            {
            case 72: // UP
                cur--;
                if (cur < 0)
                    cur = size - 1;
                break;

            case 80: // DOWN
                cur++;
                if (cur >= size)
                    cur = 0;
                break;

            case 71: // HOME
                cur = 0;
                break;

            case 79: // END
                cur = size - 1;
                break;
            }
        }
        else if (ch == 13) // ENTER
        {
            resetScreen();
            return cur;
        }
        else if (ch == 27) // ESC
        {
            resetScreen();
            return size - 1;
        }
    }
}

void adminMenu(Admin& admin)
{
    const char menu[3][20] =
    {
        "Add User",
        "Remove User",
        "Back"
    };

    int choice;
    do
    {
        choice = navigateMenu(menu, 3);

        switch (choice)
        {
        case 0:
            admin.addUser();
            _getch();
            break;

        case 1:
            admin.removeUser();
            _getch();
            break;
        }
    }
    while (choice != 2);
}

void librarianMenu(Librarian& librarian)
{
    const char menu[5][20] =
    {
        "Add Book",
        "Edit Book",
        "Delete Book",
        "Generate Reports",
        "Back"
    };

    int choice;
    do
    {
        choice = navigateMenu(menu, 5);

        switch (choice)
        {
        case 0:
            librarian.addBook();
            _getch();
            break;

        case 1:
            librarian.editBook();
            _getch();
            break;

        case 2:
            librarian.deleteBook();
            _getch();
            break;

        case 3:
            librarian.generateReports();
            _getch();
            break;
        }
    }
    while (choice != 4);
}

void memberMenu(Member& member, Book& book)
{
    const char menu[4][20] =
    {
        "Borrow Book",
        "Return Book",
        "View Fine",
        "Back"
    };

    int choice;
    do
    {
        choice = navigateMenu(menu, 4);

        switch (choice)
        {
        case 0:
            member.borrowBook(book);
            _getch();
            break;

        case 1:
            member.returnBook(book);
            _getch();
            break;

        case 2:
            member.viewFine();
            _getch();
            break;
        }
    }
    while (choice != 3);
}

int main()
{
    hideCursor();
    Admin admin(1, "Admin", "admin@mail.com", "admin");
    Librarian librarian(2, "Librarian", "lib@mail.com", "lib");
    Member member(3, "Member", "mem@mail.com", "mem");
    Book book(1, "C++ Programming", "Bjarne", "Programming", 3);

    const char mainMenu[4][20] =
    {
        "Admin",
        "Librarian",
        "Member",
        "Exit"
    };

    int choice;
    do
    {
        choice = navigateMenu(mainMenu, 4);

        switch (choice)
        {
        case 0:
            adminMenu(admin);
            break;

        case 1:
            librarianMenu(librarian);
            break;

        case 2:
            memberMenu(member, book);
            break;
        }
    }
    while (choice != 3);

    resetScreen();
    cout << "Goodbye...\n";
    return 0;
}
