#include <iostream.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>

int border (int startx, int starty, int endx, int endy, char borderChar) {
    int i;

    for (i = startx; i <= endx; i++) {
	gotoxy(i, starty); cout << borderChar;
    }

    for (i = startx; i <= endx; i++) {
	gotoxy(i, endy); cout << borderChar;
    }

    for (i = starty; i <= endy; i++) {
	gotoxy(startx, i); cout << borderChar;
    }

    for (i = starty; i <= endy; i++) {
	gotoxy(endx, i); cout << borderChar;
    }

    return 0;
}

int centerX (char* string) {
    int length = strlen(string);
    return ((80 - length) / 2);
}


int coutxy (int startx, int starty, char* output) {
    gotoxy(startx, starty); cout << output;
    return 0;
}

int spacer (int endx) {
    for (int i = wherex(); i < endx; i++) cout << " ";
    return 0;
}

main ( ) {
    float basicPay, sss, tax, philhealth, deduction, netPay, hoursWorked, ratePerHour;
    char employeeName[25], employeeNo[5], deptCode[2], department[11], console[30];

    int isDeptCodeInvalid;

    const float pagibig = 200;

    // String Buffers
    char netpaybf[20], totalbf[20];

    int keypress;
    int choice = 0;

    clrscr();


    // Cover Page
    border(centerX("Programming Task #2") - 10, 6, centerX("Programming Task #2") + strlen("Programming Task #2") + 11, 19, '@');
    coutxy(centerX("Programming Task #2"), 8, "Programming Task #2");
    coutxy(centerX("Payroll Application"), 9, "Payroll Application");

    border(centerX("Programming Task #2") - 9, 11, centerX("Programming Task #2") + strlen("Programming Task #2") + 10, 11, '-');

    coutxy(centerX("Submitted to:"), 13, "Submitted to:");
    coutxy(centerX("Sir Rodolfo Canaria"),  14, "Sir Rodolfo Canaria");

    coutxy(centerX("Submitted by"), 16, "Submitted by");
    coutxy(centerX("Brent Jamieson G. Cuya"), 17, "Brent Jamieson G. Cuya");

    coutxy(centerX("Press any key to continue..."), 21, "Press any key to continue...");
    gotoxy(79, 24);

    getch();

    do {
    clrscr();

    // Employee Detail Input
    do {
	isDeptCodeInvalid = 0;

	border(7, 5, 73, 18, '@');
	border(8, 10, 72, 10, '-');

	coutxy(centerX("Payroll"), 7, "Payroll");
	coutxy(centerX("<< Data Entry >>"), 8, "<< Data Entry >>");

	coutxy(12, 12, "Employee Number"); spacer(45); cin >> employeeNo;
	coutxy(12, 13, "Employee Name"); spacer(45); cin >> employeeName;
	coutxy(12, 14, "Department Code"); spacer(45); cin >> deptCode[0];
	coutxy(12, 15, "Number of Working Hours"); spacer(45); cin >> hoursWorked;
	coutxy(12, 16, "Rate per Number of Hours"); spacer(45); cin >> ratePerHour;
	coutxy(centerX("Invalid department code. Please try again."), 21, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
	coutxy(centerX("Press any key to continue..."), 21, "Press any key to continue...");
	getch();
	clrscr();

	if (deptCode[0] == 'A' || deptCode[0] == 'a') { strcpy(department, "Accounting"); }
	else if (deptCode[0] == 'I' || deptCode[0] == 'i') { strcpy(department, "ICT"); }
	else if (deptCode[0] == 'M' || deptCode[0] == 'm') { strcpy(department, "Marketing"); }
	else if (deptCode[0] == 'P' || deptCode[0] == 'p') { strcpy(department, "Personnel"); }
	else {
	    isDeptCodeInvalid = 1;
	    coutxy(centerX("Invalid department code. Please try again."), 21, "Invalid department code. Please try again.");
	}
    } while (isDeptCodeInvalid == 1);

    // Computations

    basicPay = ratePerHour * hoursWorked;
    sss = 0.2 * basicPay;
    tax = 0.25 * basicPay;
    philhealth = 0.04 * basicPay;
    deduction = sss + tax + philhealth + pagibig;
    netPay = basicPay - deduction;

    // Employee Payroll

    coutxy(centerX("MrBeast Corporation"), 2, "MrBeast Corporation");
    coutxy(centerX("Gen. T De Leon Branch, Valenzuela City"), 3, "Gen. T De Leon Branch, Valenzuela City");
    coutxy(centerX("October Payroll Report"), 4, "October Payroll Report");

    gotoxy(5, 6); cout << 'O'; gotoxy(75,6); cout << 'O'; border(6, 6, 74, 6, '-');
    border(5, 7, 5, 10, '|'); border (75, 7, 75, 10, '|');
    gotoxy(5,11); cout << 'O'; gotoxy(75,11); cout << 'O'; border(6,11, 74, 11, '-');

    strcpy(console, "Employee Number: "); strcat(console, employeeNo);
    coutxy(10, 8, console);

    strcpy(console, "Employee Name: "); strcat(console, employeeName);
    coutxy(10, 9, console);

    strcpy(console, "Department: "); strcat(console, department);
    coutxy(50, 8, console);

    coutxy(50, 9, "Date: 10-16-2024");

    border(5, 12, 5, 21, '|'); border (75 , 12, 75, 21, '|');

    coutxy(centerX("Salary Computations"), 13, "Salary Computations");

    coutxy(50, 16, "Working Hours: "); cout << hoursWorked; cout << " hrs";
    coutxy(50, 17, "Pay Rate:  PHP "); spacer(65); cout << ratePerHour; cout << "/hr";
    coutxy(50, 18, "Basic Pay: PHP"); spacer(65); cout << basicPay;

    sprintf(totalbf, "%.2f", deduction);
    sprintf(netpaybf, "%.2f", netPay);

    coutxy(15, 15, "Deductions");
    coutxy(10, 16, "SSS: "); spacer(25); cout << sss;
    coutxy(10, 17, "PAG-IBIG: "); spacer(25); cout << pagibig;
    coutxy(10, 18, "PhilHealth: "); spacer(25); cout << philhealth;
    coutxy(10, 19, "Tax: "); spacer(25); cout << tax;
    coutxy(10, 20, "Total: "); spacer(25); cout << totalbf;

    coutxy(50, 20, "Net Pay: "); spacer(65); cout << netpaybf;

    gotoxy(5, 22); cout << 'O'; gotoxy(75, 22); cout << 'O'; border(6, 22, 74, 22, '-');
    coutxy(centerX("Prepared by: Brent Cuya"), 24, "Prepared by: Brent Cuya");
    getch();

	do {
	clrscr();

	if (choice == 0) {
			gotoxy((80 - strlen("Do you want to make a new payroll receipt?")) / 2, 12); cout << "Do you want to make a new payroll receipt?";
			gotoxy(30, 14); cout << char(16) << " Yes";
			gotoxy(46, 14); cout << "  No";
	} else if (choice == 1) {
			gotoxy((80 - strlen("Do you want to make a new payroll receipt?")) / 2, 12); cout << "Do you want to make a new payroll receipt?";
			gotoxy(30, 14); cout << "  Yes";
			gotoxy(46, 14); cout << char(16) << " No";
	}

	keypress = getch();

	switch (keypress) {
		case 0:
			int ext = getch();
			if (ext == 72 || ext == 80 || ext == 75 || ext == 77) choice = 1 - choice;
			break;
		case 32:
			choice = 1 - choice;
			break;
	}

	} while (keypress != 13);

    } while (choice == 0);


    return 0;
}