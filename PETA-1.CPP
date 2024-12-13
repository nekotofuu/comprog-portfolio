#include <iostream.h>
#include <conio.h>
#include <string.h>
#include <math.h>

// Functions
char* isPassed (float average) {
    if (average >= 75) {
	return "PASSED";
    } else {
	return "FAILED";
    }
}

float round (float num, int placeValue) {
    float offset, roundn;
    offset = (num * pow(10, placeValue)) - floor(num * pow(10, placeValue));

    if (offset >= 0.5) {
	roundn = ceil(num * pow(10, placeValue)) / pow(10, placeValue);
    } else {
	roundn = floor(num * pow(10, placeValue)) / pow(10, placeValue);
    }

    return roundn;
}


int messageSpacer (char* message, int startx, int starty) {
    int i, length, endx;
    endx = 55;
    length = strlen(message);
    gotoxy(startx, starty); cout << message;

    for (i = startx + length; i <= endx; i++) {
	gotoxy(i, starty); cout << " ";
    }
    return 0;
}

main () {

    //Initialization
    char lrnNum[13], firstName[20], lastName[15], middleInitial[2], track[10], strand[5], section[12], adviser[30], sexCode[2], gradeLevel[3], age[3];
    float oral1, perdev1, kompan1, genmath1, hope1, ucsp1, eals1, cprg1a, cprg2a;
    float oral2, perdev2, kompan2, genmath2, hope2, ucsp2, eals2, cprg1b, cprg2b;
    float avgoral, avgperdev, avgkompan, avggenmath, avghope, avgucsp, avgeals, avgcprg1, avgcprg2, genavg;

    int i;
    int keypress;
    int choice = 0;
    clrscr();

    //Start Menu
    gotoxy(20, 5); cout << "**************************************";
    gotoxy(30, 7); cout << "Performance Task: #1";
    gotoxy(28, 8); cout << "Report Card Application";
    gotoxy(34, 10); cout << "Submitted to";
    gotoxy(30, 11); cout << "Sir Rodolfo Canaria";
    gotoxy(34, 13); cout << "Submitted by";
    gotoxy(29, 14); cout << "Brent Jamieson G. Cuya";
    gotoxy(20, 16); cout << "**************************************";
    gotoxy(26, 19); cout << "Press any key to continue...";

    for (i = 6; i < 16; i++) {
	gotoxy(20, i); cout << "|";
	gotoxy(57, i); cout << "|";
    };
    gotoxy(80, 25);
    getch();

    do {

    clrscr();
    //Student Data Entry
    gotoxy(31, 6); cout << "Student Information";
    gotoxy(19, 7); cout << "Please enter the following information:";
    messageSpacer("LRN Number: ", 10, 9); cin >> lrnNum;
    messageSpacer("First Name: ", 10, 10); cin >> firstName;
    messageSpacer("Middle Initial: ", 10, 11); cin >> middleInitial;
    messageSpacer("Last Name: ", 10, 12); cin >> lastName;
    messageSpacer("Track: ", 10, 13); cin >> track;
    messageSpacer("Strand: ", 10, 14); cin >> strand;
    messageSpacer("Grade Level: ", 10, 15); cin >> gradeLevel;
    messageSpacer("Section: ", 10, 16); cin >> section;
    messageSpacer("Sex Code: ", 10, 17); cin >> sexCode;
    messageSpacer("Age: ", 10, 18); cin >> age;
    messageSpacer("Name of Adviser: ", 10, 19); cin >> adviser;
    gotoxy(26, 21); cout << "Press any key to continue...";
    getch();
    clrscr();

 // Student Grade Entry: Quarter 1
    messageSpacer("First Quarter Input Screen", 27, 7);
    messageSpacer("Please enter the grades for the first quarter.", 17, 8);
    messageSpacer("General Mathematics: ", 10, 10); cin >> genmath1;
    messageSpacer("Oral Communication: ", 10, 11); cin >> oral1;
    messageSpacer("Komunikasyon at Pananaliksik: ", 10, 12); cin >> kompan1;
    messageSpacer("Earth and Life Science: ", 10, 13); cin >> eals1;
    messageSpacer("Understanding Culture, Society, Politics: ", 10, 14); cin >> ucsp1;
    messageSpacer("Personal Development: ", 10, 15); cin >> perdev1;
    messageSpacer("HOPE: ", 10, 16); cin >> hope1;
    messageSpacer("Computer Programming 1: ", 10, 17); cin >> cprg1a;
    messageSpacer("Computer Programming 2: ", 10, 18); cin >> cprg2a;
    gotoxy(26, 20); cout << "Press any key to continue...";
    getch();
    clrscr();

    // Student Grade Entry: Quarter 2
    messageSpacer("Second Quarter Input Screen", 26, 7);
    messageSpacer("Enter the student's grade on each subject for the second quarter. ", 6, 8);
    messageSpacer("General Mathematics: ", 10, 10); cin >> genmath2;
    messageSpacer("Oral Communication: ", 10, 11); cin >> oral2;
    messageSpacer("Komunikasyon at Pananaliksik: ", 10, 12); cin >> kompan2;
    messageSpacer("Earth and Life Science: ", 10, 13); cin >> eals2;
    messageSpacer("Understanding Culture, Society, Politics: ", 10, 14); cin >> ucsp2;
    messageSpacer("Personal Development: ", 10, 15); cin >> perdev2;
    messageSpacer("HOPE: ", 10, 16); cin >> hope2;
    messageSpacer("Computer Programming 1: ", 10, 17); cin >> cprg1b;
    messageSpacer("Computer Programming 2: ", 10, 18); cin >> cprg2b;
    gotoxy(26, 20); cout << "Press any key to continue...";
    getch();
    clrscr();

    // Grade computation
    avggenmath = (genmath1 + genmath2) / 2;
    avgoral = (oral1 + oral2) / 2;
    avgperdev = (perdev1 + perdev2) / 2;
    avgeals = (eals1 + eals2) / 2;
    avgucsp = (ucsp1 + ucsp2) / 2;
    avghope = (hope1 + hope2) / 2;
    avgkompan = (kompan1 + kompan2) / 2;
    avgcprg1 = (cprg1a + cprg2a) / 2;
    avgcprg2 = (cprg2a + cprg2b) / 2;
    genavg = (avggenmath + avgcprg2 + avgcprg1 + avgkompan + avghope + avgucsp + avgeals + avgperdev + avgoral) / 9;

    // Report Card Display
    // Header
    gotoxy(19, 2); cout << "Gen. Tiburcio De Leon National High School";
    gotoxy(15, 3); cout << "Corner Mercado St., Gen. T. De Leon, Valenzuela City";
    gotoxy(25, 4); cout << "SENIOR HIGH SCHOOL DEPARTMENT";
    gotoxy(34, 5); cout << "Report Card";
    gotoxy(32, 6); cout << "S.Y. 2024 - 2025";
    gotoxy(10, 7); cout << "LRN Number: " << lrnNum;
    gotoxy(10, 8); cout << "Name: " << lastName << ", " << firstName << " " << middleInitial << ".";
    gotoxy(10, 9); cout << "Grade & Section: " << gradeLevel << " - " << section;
    gotoxy(10, 10); cout << "Age: " << age;
    gotoxy(50, 7); cout << "Track/Strand: " << track << " - " << strand;
    gotoxy(50, 8); cout << "Adviser: " << adviser;
    gotoxy(50, 9); cout << "Sex: " << sexCode;

    // Divider
    gotoxy(1, 11); cout << "--------------------------------------------------------------------------------";
    gotoxy(3, 12); cout << "Subject";
    gotoxy(35, 12); cout << "Quarter 1";
    gotoxy(47, 12); cout << "Quarter 2";
    gotoxy(60, 12); cout << "Average";
    gotoxy(70, 12); cout << "Remarks";
    gotoxy(1, 13); cout << "--------------------------------------------------------------------------------";

    // Subject
    gotoxy(3,14); cout << "General Mathematics";
    gotoxy(3,15); cout << "Oral Communication";
    gotoxy(3,16); cout << "Earth and Life Science";
    gotoxy(3,17); cout << "Komunikasyon at Pananaliksik";
    gotoxy(3,18); cout << "Personal Development";
    gotoxy(3,19); cout << "HOPE";
    gotoxy(3,20); cout << "UCSP";
    gotoxy(3,21); cout << "Computer Programming 1";
    gotoxy(3,22); cout << "Computer Programming 2";

    // Quarter 1 Grades
    gotoxy(39, 14); cout << genmath1;
    gotoxy(39, 15); cout << oral1;
    gotoxy(39, 16); cout << eals1;
    gotoxy(39, 17); cout << kompan1;
    gotoxy(39, 18); cout << perdev1;
    gotoxy(39, 19); cout << hope1;
    gotoxy(39, 20); cout << ucsp1;
    gotoxy(39, 21); cout << cprg1a;
    gotoxy(39, 22); cout << cprg2a;

    // Quarter 2 Grades
    gotoxy(51, 14); cout << genmath2;
    gotoxy(51, 15); cout << oral2;
    gotoxy(51, 16); cout << eals2;
    gotoxy(51, 17); cout << kompan2;
    gotoxy(51, 18); cout << perdev2;
    gotoxy(51, 19); cout << hope2;
    gotoxy(51, 20); cout << ucsp2;
    gotoxy(51, 21); cout << cprg1b;
    gotoxy(51, 22); cout << cprg2b;

    // Average
    gotoxy(62, 14); cout << round(avggenmath, 0);
    gotoxy(62, 15); cout << round(avgoral, 0);
    gotoxy(62, 16); cout << round(avgeals, 0);
    gotoxy(62, 17); cout << round(avgkompan, 0);
    gotoxy(62, 18); cout << round(avgperdev, 0);
    gotoxy(62, 19); cout << round(avghope, 0);
    gotoxy(62, 20); cout << round(avgucsp, 0);
    gotoxy(62, 21); cout << round(avgcprg1, 0);
    gotoxy(62, 22); cout << round(avgcprg2, 0);

    //Remarks
    gotoxy(71, 14); cout << isPassed(avggenmath);
    gotoxy(71, 15); cout << isPassed(avgoral);
    gotoxy(71, 16); cout << isPassed(avgeals);
    gotoxy(71, 17); cout << isPassed(avgkompan);
    gotoxy(71, 18); cout << isPassed(avgperdev);
    gotoxy(71, 19); cout << isPassed(avghope);
    gotoxy(71, 20); cout << isPassed(avgucsp);
    gotoxy(71, 21); cout << isPassed(avgcprg1);
    gotoxy(71, 22); cout << isPassed(avgcprg2);

    // Footer
    gotoxy(1, 23); cout << "--------------------------------------------------------------------------------";
    gotoxy(3, 24); cout << "General Average ";
    gotoxy(62, 24); cout << round(genavg, 0);
    gotoxy(71, 24); cout << isPassed(genavg);
    gotoxy(1, 25); cout << "--------------------------------------------------------------------------------";

    getch();

    do {
	clrscr();

	if (choice == 0) {
			gotoxy((80 - strlen("Do you want to make a new card?")) / 2, 12); cout << "Do you want to make a new card";
			gotoxy(30, 14); cout << char(16) << " Yes";
			gotoxy(46, 14); cout << "  No";
	} else if (choice == 1) {
			gotoxy((80 - strlen("Do you want to make a new card?")) / 2, 12); cout << "Do you want to make a new card";
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