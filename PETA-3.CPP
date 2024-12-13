#include <iostream.h>
#include <conio.h>
#include <string.h>
#include <math.h>

// Constants
// For console padding
int lpadding = 0;
int rpadding = 0;


// Functions
// Sets padding
void setpd (int left, int right) {
    lpadding = left;
    rpadding = right;
}

// Returns x coord for centering string in console
int center (char* string) {
    int length = strlen(string);
    return (80 - length) / 2;
}

// Outputs string with a left alignment
void lcout(int x, int y, char* message, int type) {
    int xpos;
    switch (type) {
	case 1: // Relative to padding
	    xpos = x + lpadding;
	    break;
	case 0: // Relative to left
	    xpos = x;
	    break;
    }

    gotoxy(xpos, y);
    cout << message;
}

// Outputs string with center alignment
void ccout(int y, char* message) {
    gotoxy(center(message), y);
    cout << message;
}

// Outputs string with right alignment
void rcout(int x, int y, char* message, int type) {
    int xpos;
    int length = strlen(message);
    switch (type) {
	case 1: // Relative to padding
	    xpos = 80 - (x + length + rpadding);
	    break;
	case 0: // Relative to right
	    xpos = 80 -  (x + length);
	    break;
    }

    gotoxy(xpos, y);
    cout << message;
}

// Function that displays a border
void createBorder (int starty, int endy, char vertChar, char horChar, char vertex) {
    int i, startx, endx;
    startx = lpadding;
    endx = 80 - rpadding;

    for (i = startx; i <= endx; i++) {
	gotoxy(i, starty); cout << horChar;
    }

    for (i = startx; i <= endx; i++) {
	gotoxy(i, endy); cout << horChar;
    }

    for (i = starty; i <= endy; i++) {
	gotoxy(startx, i); cout << vertChar;
    }

    for (i = starty; i <= endy; i++) {
	gotoxy(endx, i); cout << vertChar;
    }

    gotoxy(startx, starty); cout << vertex;
    gotoxy(startx, endy); cout << vertex;
    gotoxy(endx, starty); cout << vertex;
    gotoxy(endx, endy); cout << vertex;
}

// Function that creates a horizontal line divider
void hr (int y, char lineChar, char endChar) {
    int i, startx, endx;
    startx = lpadding;
    endx = 80 - rpadding;

    gotoxy(startx, y); cout << endChar;

    for (i = startx + 1; i <= endx - 1; i++) {
	gotoxy(i, y); cout << lineChar;
    }

    gotoxy(endx, y); cout << endChar;
}

// Function that creates left aligned-spacing
void lspacer (int n, int mode) {
    int x;
    switch (mode) {
	case 0: // with respect to viewport
	    x = n;
	    break;
	default: // with respect to padding
	    x = n + lpadding;
	    break;
    }

    for (int i = wherex(); i < x; i++) { cout << " "; }
}

float round (float num, int placeValue) {
    float shift, offset, roundn;
    shift = 1;

    if (placeValue > 0) {
	for (int i = 0; i < placeValue; i++) shift = shift * 10;
    } else if (placeValue < 0) {
	for (int i = 0; i < abs(placeValue); i++) shift = shift / 10;
    }

    return floor(num * shift + 0.5f) / shift;
}


int cursorInterface (int possibleChoices, int initValue, int inputVar) {
    int output = initValue;

    if (inputVar == 44) output--;
    else if (inputVar == 46 || inputVar == 32) output++;

    if (output > possibleChoices) output = 1; // When it overflows, it resets back to the first choice,
    if (output < 1) output = possibleChoices; // When it underflows, it goes to the highest possible choice.
    return output;
}


main () {
    int pQuantity, distance;
    char pFlavor[20], pSize[6], pCrust[6], orderType[10], customerType[10];
    char name[25], address[25];

    float basePrice, baseCrust, pizzaPrice,  crustMod, serviceCharge, spDiscount, subTotal, totalCost, tax;
    int select, current, isDone, temp;
    char console[50];

    int keypress;
    int choice = 0;

    clrscr();

    // Title Screen
    setpd(20, 20);
    createBorder(12, 15, '|', '-', '@');
    ccout(13, "Pizza House");
    ccout(14, "The House of Delicious Pizza");
    getch();

    do {
    clrscr();

    // Customer Form
    setpd(5, 5);
    createBorder(8, 17, '|', '-', '@');
    ccout(6, "Customer Info");
    lcout(5, 10, "Customer Name:", 1);
    lcout(5, 12, "Customer Address:", 1);
    lcout(5, 14, "Customer Type:", 1);
    lspacer(39, 0); cout << "Normal";
    lspacer(55, 0); cout << "Senior/PWD";

    gotoxy(30, 10); cin >> name;
    gotoxy(30, 12); cin >> address;

    // Customer Type Pick
    lcout(38, 14, "(Normal)", 0);
    current = 1;

    do {
	isDone = 0;
	ccout(19, "Press Space or , and . to scroll through options.");
	ccout(20, "Press Enter to confirm option.");
	select = getch();

	// Cursor Movement
	current = cursorInterface(2, current, select);

	// Console Update
	switch (current) {
	    case 1:
		lcout(54, 14, " Senior/PWD ", 0);
		lcout(38, 14, "(Normal)", 0);
		strcpy(customerType, "Normal"); // Assigns highlighted value to var
		break;
	    case 2:
		lcout(38, 14, " Normal ", 0);
		lcout(54, 14, "(Senior/PWD)", 0);
		strcpy(customerType, "Special");
		break;
	}

	// Check if user presses Enter
	    if (select == 13) {
		isDone = 1;
		lcout(1, 19, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 1);
		lcout(1, 20, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 19);
	    };

    } while (isDone == 0);

    ccout(19, "Press any key.");
    getch();

    // Pizza Order Entry
    clrscr();
    setpd(10, 10);
    createBorder(4, 20, '|', '-', '@');
    ccout(2, "Enter Order Details");

    //// Display initial options
    lcout(5, 7, "Flavor", 1);
    lcout(5, 10, "Crust", 1);
    lcout(5, 12, "Size", 1);
    lcout(5, 14, "Order Type", 1);
    lcout(5, 16, "Distance", 1);
    lcout(5, 18, "Quantity", 1);

    rcout(7, 6, "Ham and Cheese", 1);
    rcout(7, 7, "Manager's Choice", 1);
    rcout(7, 8, "Pepperoni", 1);

    lcout(38, 10, "Thin", 0);
    lcout(52, 10, "Thick", 0);

    lcout(38, 12, "S", 0);
    lcout(47, 12, "M", 0);
    lcout(56, 12, "L", 0);

    lcout(32, 14, "Dine-in", 0);
    lcout(44, 14, "Take-out", 0);
    lcout(57, 14, "Delivery", 0);

    /// Set/prepare for pizza flavor choice
    current = 1;
    rcout(5, 6, "> Ham and Cheese <", 1);

    do {
	isDone = 0;
	ccout(22, "Press Space or \'>\' and \'<\' to cycle through options.");
	ccout(23, "Press Enter to confirm option.");
	select = getch();

	current = cursorInterface(3, current, select);

	switch (current) {
	    case 1:
		rcout(5, 6, "> Ham and Cheese <", 1);
		rcout(5, 7, "  Manager's Choice  ", 1);
		rcout(5, 8, "  Pepperoni  ", 1);
		strcpy(pFlavor, "Ham and Cheese");
		break;
	    case 2:
		rcout(5, 6, "  Ham and Cheese  ", 1);
		rcout(5, 7, "> Manager's Choice <", 1);
		rcout(5, 8, "  Pepperoni  ", 1);
		strcpy(pFlavor, "Manager's Choice");
		break;
	    case 3:
		rcout(5, 6, "  Ham and Cheese  ", 1);
		rcout(5, 7, "  Manager's Choice  ", 1);
		rcout(5, 8, "> Pepperoni <", 1);
		strcpy(pFlavor, "Pepperoni");
		break;
	}

	if (select == 13) {
	    isDone = 1;
	    lcout(1, 22, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
	    lcout(1, 23, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
	}

    } while (isDone == 0);

    /// Set/prepare for pizza crust
    current = 1;
    lcout(36, 10, "> Thin <", 0);

    do {
	isDone = 0;
	ccout(22, "Press Space or \'>\' and \'<\' to cycle through options.");
	ccout(23, "Press Enter to confirm option.");
	select = getch();

	current = cursorInterface(2, current, select);

	switch(current) {
	    case 1:
		lcout(36, 10, "> Thin <", 0);
		lcout(50, 10, "  Thick  ", 0);
		strcpy(pCrust, "Thin");
		break;
	    case 2:
		lcout(36, 10, "  Thin  ", 0);
		lcout(50, 10, "> Thick <", 0);
		strcpy(pCrust, "Thick");
		break;
	}

	if (select == 13) {
	    isDone = 1;
	    lcout(1, 22, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
	    lcout(1, 23, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
	}
    } while (isDone == 0);

    /// Set/prepare for pizza size
    current = 1;
    lcout(36, 12, "> S <", 0);

    do {
	isDone = 0;
	ccout(22, "Press Space or \'>\' and \'<\' to cycle through options.");
	ccout(23, "Press Enter to confirm option.");
	select = getch();

	current = cursorInterface(3, current, select);

	switch (current) {
	    case 1:
		lcout(36, 12, "> S <", 0);
		lcout(45, 12, "  M  ", 0);
		lcout(54, 12, "  L  ", 0);
		strcpy(pSize, "Small");
		break;
	    case 2:
		lcout(36, 12, "  S  ", 0);
		lcout(45, 12, "> M <", 0);
		lcout(54, 12, "  L  ", 0);
		strcpy(pSize, "Medium");
		break;
	    case 3:
		lcout(36, 12, "  S  ", 0);
		lcout(45, 12, "  M  ", 0);
		lcout(54, 12, "> L <", 0);
		strcpy(pSize, "Large");
		break;
	}

	if (select == 13) {
	    isDone = 1;
	    lcout(1, 22, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
	    lcout(1, 23, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
	}

    } while (isDone == 0);

    /// Set/prepare for order type
    current = 1;
    lcout(30, 14, "> Dine-in <", 0);

    do {
	isDone = 0;
	ccout(22, "Press Space or \'>\' and \'<\' to cycle through options.");
	ccout(23, "Press Enter to confirm option.");
	select = getch();

	current = cursorInterface(3, current, select);

	switch (current) {
	    case 1:
		lcout(30, 14, "> Dine-in <", 0);
		lcout(42, 14, "  Take-out  ", 0);
		lcout(55, 14, "  Delivery  ", 0);
		strcpy(orderType, "Dine-in");
		break;
	    case 2:
		lcout(30, 14, "  Dine-in  ", 0);
		lcout(42, 14, "> Take-out <", 0);
		lcout(55, 14, "  Delivery  ", 0);
		strcpy(orderType, "Take-out");
		break;
	    case 3:
		lcout(30, 14, "  Dine-in  ", 0);
		lcout(42, 14, "  Take-out  ", 0);
		lcout(55, 14, "> Delivery <", 0);
		strcpy(orderType, "Delivery");
		break;
	}

	if (select == 13) {
	    isDone = 1;
	    lcout(1, 22, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
	    lcout(1, 23, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
	}

    } while (isDone == 0);

    /// Input distance
    if (strcmp(orderType, "Delivery") == 0) {
	lcout(55, 16, "km", 0);
	ccout(22, "Please input distance (in kilometers) from branch to customer address.");
	gotoxy(48, 16); cin >> distance;
	lcout(1, 22, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);
    } else {
	lcout(46, 16, "N/A", 0);
    }

    /// Input qty
    ccout(22, "Please input quantity of pizzas to order.");
    gotoxy(46, 18); cin >> pQuantity;
    lcout(1, 22, "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 0);

    ccout(22, "Press any key.");
    getch();
    clrscr();

    // Cost calculation

    if (strcmp(pFlavor, "Ham and Cheese") == 0) {
	basePrice = 200;
	baseCrust = 5;
    } else if (strcmp(pFlavor, "Manager's Choice") == 0) {
	basePrice = 250;
	baseCrust = 10;
    } else if (strcmp(pFlavor, "Pepperoni") == 0) {
	basePrice = 400;
	baseCrust = 15;
    }

    if (strcmp(pSize, "Small") == 0) crustMod = 0;
    else if (strcmp(pSize, "Medium") == 0) {
	basePrice = basePrice + 50;
	crustMod = 5;
    } else if (strcmp(pSize, "Large") == 0) {
	basePrice = basePrice + 100;
	crustMod = 10;
    }

    if (strcmp(pCrust, "Thick") == 0) pizzaPrice = basePrice +  baseCrust + crustMod;
    else pizzaPrice = basePrice;

    subTotal = pizzaPrice * pQuantity;
    tax = 0.12 * subTotal;

    /// Conditional Discounts/Taxes
    if (strcmp(customerType, "Special") == 0) spDiscount = 0.2 * subTotal;

    if (strcmp(orderType, "Dine-in") == 0) serviceCharge = 0.1 * subTotal;
    else if (strcmp(orderType, "Delivery") == 0) serviceCharge = floor(distance / 4) * 50;
    else serviceCharge = 0;

    totalCost = (subTotal + tax + serviceCharge) - spDiscount;


    // Receipt
    setpd(15, 15);
    createBorder(5, 25, '|', '-', '@');

    ccout(2,"Pizza House");
    ccout(3, "The Home of Delicious Pizza");
    ccout(4, "Gen. T De Leon Branch, Valenzuela City");

    lcout(2, 6, "Customer Name: ", 1); cout << name;
    lcout(2, 7, "Customer Address: ", 1); cout << address;

    rcout(1, 6, "Date: 10-24-24", 1);
    ccout(8, "Official Receipt");


    lcout(5, 10, "", 1); cout << pQuantity << " pc " << pFlavor << " Pizza";
    lcout(5, 11, "Pizza Cost: ", 1); rcout(10, 11, "", 1); cout << round(basePrice, 2);

    if (strcmp(pCrust, "Thick") == 0) {
	lcout(5, 12, "Crust: ", 1);
	rcout(10, 12, "", 1);
	cout << round(baseCrust + crustMod, 2);
    }

    rcout(2, 13, "----------", 1);
    rcout(10, 14, "", 1); cout << round(pizzaPrice, 2);
    lcout(5, 15, "Qty: ", 1); rcout(10, 15, "", 1); cout << round(pQuantity, 2);
    rcout(2, 16, "----------", 1);
    lcout(5, 17, "Subtotal: ", 1); rcout(10, 17, "", 1); cout << round(subTotal, 2);

    if (strcmp(orderType, "Dine-in") == 0) {
	lcout(5, 18, "Service Charge: ", 1);
	rcout(10, 18, "", 1);
	cout << round(serviceCharge, 2);
    }

    if (strcmp(orderType, "Delivery") == 0) {
	lcout(5, 18, "Delivery Charge: ", 1);
	rcout(10, 18, "", 1);
	cout << round(serviceCharge, 2);
    }
    lcout(5, 19, "VAT Added: ", 1); rcout(10, 19, "", 1); cout << round(tax, 2);

    if (strcmp(customerType, "Special") == 0) {
	if (spDiscount == 0) temp = 11;
	else temp = 10;

	lcout(5, 20, "Discount", 1);
	rcout(temp, 20, "", 1);
	cout << -1 * round(spDiscount, 2);
    }

    rcout(2, 21, "----------", 1);
    lcout(5, 22, "Total Cost: ", 1); rcout(10, 22, "", 1); cout << round(totalCost, 2);

    ccout(23, "Thank you for coming!");
    ccout(24, "Pls come again!");
    getch();

	do {
	clrscr();

	if (choice == 0) {
			gotoxy((80 - strlen("Do you want to make a new order?")) / 2, 12); cout << "Do you want to make a new order?";
			gotoxy(30, 14); cout << char(16) << " Yes";
			gotoxy(46, 14); cout << "  No";
	} else if (choice == 1) {
			gotoxy((80 - strlen("Do you want to make a new order?")) / 2, 12); cout << "Do you want to make a new order?";
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