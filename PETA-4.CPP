#include <iostream.h>
#include <graphics.h>
#include <conio.h>
#include <dos.h>
#include <stdlib.h>
#include <stdio.h>
#include <time.h>
#include <string.h>
#include <math.h>
#include <alloc.h>

/* Global Variables */
int rounds = 1, currentRound = 1;
int pMove = 0, cMove = 0;
int pScore = 0, cScore = 0;
char playerName[12] = "Player";

void *rock, *paper, *scissors;

struct viewporttype vinf;

/* Mechanics */
// Message enum to encode information from awaitKey()
enum Message {
	NONE,
	BACK,
	MOVECURXP,
	MOVECURXN,
	MOVECURYP,
	MOVECURYN,
	SELECT
};

// Function that converts keypress to message
// Message can be used instead as a shorthand to a specific command.
// A message can just be used in a switch statement instead of detecting for
// multiple keys at a time.
Message awaitKey () {
	int key = getch();

	switch (key) {
		case 0: // For arrow key support (they use extended keys)
		     int ext = getch();
		     switch (ext) {
			case 72:
				return MOVECURYN;
			case 80:
				return MOVECURYP;
			case 75:
				return MOVECURXN;
			case 77:
				return MOVECURXP;
			default:
				return NONE;
		     }
		case 27: // Esc key
			return BACK;
		case 119: // W key
			return MOVECURYN;
		case 97: // A key
			return MOVECURXN;
		case 115: // S key
			return MOVECURYP;
		case 100: // D key
			return MOVECURXP;
		case 32: // Space key
			return SELECT;
		case 13: // Enter key
			return SELECT;
		default:
			return NONE;
	};
}

int checkMem () {
	return coreleft();
}

/* Graphics Initialization */
struct gconfig {
	int gd;
	int gm;
};

void startGraphics(gconfig &gc) {
	gc.gd = DETECT;
	initgraph(&gc.gd, &gc.gm, "C://TURBOC3//BGI");
}

void endGraphics () {
	closegraph();
}

/* Custom Graphics Functions */
void border() {
	const int x = getmaxx();
	const int y = getmaxy();
	rectangle(0, 0, x, y);
	rectangle(10, 10, x - 10, y - 10);
}

// Resets viewport
void resetviewport (int clip) {
	setviewport(0, 0, getmaxx(), getmaxy(), clip);
}

// Draws a left/right pointed triangle at (x,y)
void pointer (int x, int y, int r) {

	if (r != 0) {
		int polygon[8] = {x, y + r,
				  x + r, y,
				  x, y - r,
				  x, y + r};
		drawpoly(4, polygon);
		fillpoly(4, polygon);
	} else {
		putpixel(x, y, 15);
	}
}

void box (int x, int y, int sidelength) {
	rectangle(x, y, x + sidelength, y + sidelength);
}

// Draws a rotated ellipse using the parametric representation of an ellipse
// Unlike the graphics function ellipse(), the graph is rotated by an extra
// parameter angle.

// It calculates each individual point in the ellipse using its parametric
// representation formula, filters each unique point on the screen, then
// applies a transformation to rotate each point by the angle provided, then
// draws each point using drawpoly();

void rotateEllipse (int centerx, int centery, int xrad, int yrad, int angle) {

	if (angle == 0 || angle == 180) ellipse(centerx, centery, 0, 360, xrad, yrad);
	else if (angle == 90 || angle == 270) ellipse(centerx, centery, 0, 360, yrad, xrad);
	else {
		float x, y, xNew, yNew;
		float theta = angle * (M_PI / 180.0);
		float alpha = 0.0;
		int i = 0, j = 2;

		int ellipsex[629] = {0};
		int ellipsey[629] = {0};
		int ellipse[1260] = {0};

		do {
			x = xrad * cos(alpha);
			y = yrad * sin(alpha);


			ellipsex[i] = centerx + (x * cos(theta) - y * sin(theta));
			ellipsey[i] = centery + (x * sin(theta) + y * cos(theta));

			alpha = alpha + 0.01;
			i++;
		} while (i <= 628);

		ellipse[0] = ellipsex[0];
		ellipse[1] = ellipsey[0];

		int point = 1;
		for (i = 1; i <= 628; i++) {
			if (ellipsex[i - 1] != ellipsex[i] || ellipsey[i - 1] != ellipsey[i]) {

				ellipse[j] = ellipsex[i];
				j++;

				ellipse[j] = ellipsey[i];
				j++;

				point++;
			}

		}

		ellipse[j] = ellipsex[0];
		j++;
		ellipse[j] = ellipsey[0];

		drawpoly(point, ellipse);
	 }
}

void fillRotEllipse (int centerx, int centery, int xrad, int yrad, int angle) {

	if (angle == 0 || angle == 180) fillellipse(centerx, centery, xrad, yrad);
	else if (angle == 90 || angle == 270) fillellipse(centerx, centery, yrad, xrad);
	else {
		float x, y, xNew, yNew;
		float theta = angle * (M_PI / 180.0);
		float alpha = 0.0;
		int i = 0, j = 2;

		int ellipsex[629] = {0};
		int ellipsey[629] = {0};
		int ellipse[1260] = {0};

		do {
			x = xrad * cos(alpha);
			y = yrad * sin(alpha);


			ellipsex[i] = centerx + (x * cos(theta) - y * sin(theta));
			ellipsey[i] = centery + (x * sin(theta) + y * cos(theta));

			alpha = alpha + 0.01;
			i++;
		} while (i <= 628);

		ellipse[0] = ellipsex[0];
		ellipse[1] = ellipsey[0];

		int point = 1;
		for (i = 1; i <= 628; i++) {
			if (ellipsex[i - 1] != ellipsex[i] || ellipsey[i - 1] != ellipsey[i]) {

				ellipse[j] = ellipsex[i];
				j++;

				ellipse[j] = ellipsey[i];
				j++;

				point++;
			}

		}

		ellipse[j] = ellipsex[0];
		j++;
		ellipse[j] = ellipsey[0];

		fillpoly(point, ellipse);
	 }
}

// Finds viewport length
// Useful for adjusting graphic objects to viewport coordinates
int viewwidth () {
	return vinf.right - vinf.left;
}

// Outputs x-position of a text, including offset
int textcenter (int offset, char* text) {
    return ((viewwidth() - textwidth(text)) / 2) + offset;
}

// Displays text at center
void centertext (int y, char* text) {
	int center = (viewwidth() - textwidth(text)) / 2;
	outtextxy(center, y, text);
}

// Variant of centertext() that accepts an offset value to center
void centertext (int y, int offset, char* text) {
	int position = ((viewwidth() - textwidth(text)) / 2) + offset;
	outtextxy(position, y, text);
}

void player (int mode) {
	setcolor(WHITE);
	ellipse(75, 120, 0, 180, 45, 55);
	circle(75, 40, 25);

	int pocket[12] = {75, 90,
			  95, 90,
			  95, 100,
			  85, 105,
			  75, 100,
			  75, 90};

	int lwink[6] = {60, 35,
			70, 40,
			60, 45};

	int rwink[6] = {90, 35,
			80, 40,
			90, 45};

	drawpoly(6, pocket);
	rectangle(75, 85, 95, 90);

	switch (mode) {
		case 0: // Default
			line(70, 40, 70, 28);
			line(80, 40, 80, 28);
			ellipse(77, 48, 270, 360, 8, 7);
			break;
		case 1: // Lose
			line(70, 40, 70, 28);
			line(80, 40, 80, 28);
			ellipse(85, 55, 90, 180, 8, 6);
			break;
		case 2: // Draw
			line(70, 40, 70, 28);
			line(80, 40, 80, 28);
			line(68, 51, 83, 51);
			break;
		case 3: // Win
			drawpoly(3, lwink);
			drawpoly(3, rwink);
			ellipse(75, 46, 250, 360, 8, 7);
			break;
	}
}

void robot (int mode) {
	setcolor(WHITE);
	rectangle(20, -(120 - (2 * 10)) + vinf.bottom - 11 - 10, 130, -(120 - (2 * 80)) + vinf.bottom - 11 - 80);
	rectangle(25, -(120 - (2 * 15)) + vinf.bottom - 11 - 15, 125, -(120 - (2 * 75)) + vinf.bottom - 11 - 75);
	rectangle(40, -(120 - (2 * 85)) + vinf.bottom - 11 - 85, 110, -(120 - (2 * 120)) + vinf.bottom - 11 - 120);
	rectangle(60, -(120 - (2 * 80)) + vinf.bottom - 11 - 80, 90, -(120 - (2 * 85)) + vinf.bottom - 11 - 85);
	rectangle(80, -(120 - (2 * 95)) + vinf.bottom - 11 - 95, 100, -(120 - (2 * 110)) + vinf.bottom - 11 - 110);
	rectangle(80 - 2, -(120 - (2 * 95)) + vinf.bottom - 11 - 95 - 2, 100 + 2, -(120 - (2 * 110)) + vinf.bottom - 11 - 110 + 2);

	for (int i = 96; i <= 110; i = i + 2) line(80, -(120 - (2 * i)) + vinf.bottom - 11 - i, 100, -(120 - (2 * i)) + vinf.bottom - 11 - i);

	setfillstyle(0, LIGHTGRAY);
	circle(58, -(120 - (2 * 102)) + vinf.bottom - 11 - 102, 10);

	switch (mode) {
		case 0: // Default
			circle(20 + 22 + 14, -(120 - (2 * 45)) + vinf.bottom - 11 - 45, 14);
			circle(20 + 22 + 14 + 10 + 28, -(120 - (2 * 45)) + vinf.bottom - 11 - 45, 14);
			line(65, -(120 - (2 * 66)) + vinf.bottom - 11 - 66, 85, -(120 - (2 * 66)) + vinf.bottom - 11 - 66);
			break;
		case 1: // Waiting
			rectangle(60, -(120 - (2 * 60)) + vinf.bottom - 11 - 60, 90, -(120 - (2 * 63)) + vinf.bottom - 11 - 63);
			rectangle(60, -(120 - (2 * 27)) + vinf.bottom - 11 - 27, 90, -(120 - (2 * 30)) + vinf.bottom - 11 - 30);
			int hourglass[10] = {60, -(120 - (2 * 60)) + vinf.bottom - 11 - 60,
					     90, -(120 - (2 * 30)) + vinf.bottom - 11 - 30,
					     60, -(120 - (2 * 30)) + vinf.bottom - 11 - 30,
					     90, -(120 - (2 * 60)) + vinf.bottom - 11 - 60,
					     60, -(120 - (2 * 60)) + vinf.bottom - 11 - 60};

			drawpoly(5, hourglass);
			break;
		case 2: // Lose
			circle(75, -(120 - (2 * 62)) + vinf.bottom - 11 - 62, 3);
			int mark[10] = {74, -(120 - (2 * 55)) + vinf.bottom - 11 - 55,
					72, -(120 - (2 * 25)) + vinf.bottom - 11 - 25,
					78, -(120 - (2 * 25)) + vinf.bottom - 11 - 25,
					76, -(120 - (2 * 55)) + vinf.bottom - 11 - 55,
					74, -(120 - (2 * 55)) + vinf.bottom - 11 - 55};

			drawpoly(5, mark);
			break;
		case 3: // Win
			int lwink[6] = {45, -(120 - (2 * 50)) + vinf.bottom - 11 - 50,
					60, -(120 - (2 * 42)) + vinf.bottom - 11 - 42,
					45, -(120 - (2 * 35)) + vinf.bottom - 11 - 35};

			int rwink[6] = {105, -(120 - (2 * 50)) + vinf.bottom - 11 - 50,
					90, -(120 - (2 * 42)) + vinf.bottom - 11 - 42,
					105, -(120 - (2 * 35)) + vinf.bottom - 11 - 35};

			drawpoly(3, lwink);
			drawpoly(3, rwink);

			ellipse(75, -(120 - (2 * 55)) + vinf.bottom - 11 - 55, 180, 360, 5, 3);
			break;
	}
}

// Initializes assets used in the game
// It also allocates memory for the assets in the game to be loaded
// and displayed later.
// It uses getimage() for saving.
int initAssets() {
	unsigned int mem;
	const int centerx = getmaxx() / 2;
	const int centery = getmaxy() / 2;

	// Reserves memory required for the images
	unsigned int spritesize = imagesize(0, 0, 100, 100);
	rock = malloc(spritesize);
	paper = malloc(spritesize);
	scissors = malloc(spritesize);

	// Executes if memory allocation fails (null value)
	if (rock == NULL || paper == NULL || scissors == NULL) {
		endGraphics();
		cout << "Memory allocation failed!" << endl;
		getch();
		return -1;
	}

	// It uses double buffer to draw the assets in a separate page
	// in the background. The assets are still being drawn and saved
	// but the user does not see this process.

	// This sets the active working page to a page non-visible to user
	setactivepage(1);
	setviewport(centerx - 50, centery - 50, centerx + 50, centery + 50, 0);

	// Rock Design
	setcolor(7);
	setlinestyle(0, 0, 1);
	setfillstyle(1, 7);
	sector(50, 50, 0, 125, 48, 28);
	fillellipse(34, 45, 28, 20);
	fillellipse(58, 49, 40, 20);

	setcolor(8);
	setlinestyle(0, 0, 3);
	ellipse(50, 50, 0, 125, 48, 28);
	ellipse(34, 45, 110, 280, 28, 20);
	ellipse(58, 49, 233, 360, 40, 20);

	setcolor(15);
	setlinestyle(0, 0, 0);
	ellipse(50, 50, 0, 125, 45, 25);

	setcolor(8);
	setlinestyle(0, 0, 1);
	ellipse(50, 50, 20, 67, 24, 14);
	ellipse(52, 48, 25, 68, 24, 14);
	arc(72, 43, 280, 410, 2);
	arc(61, 37, 90, 180, 2);
	circle(77, 48, 2);

	setcolor(15);
	setlinestyle(0, 0, 0);
	ellipse(52, 48, 25, 68, 23, 13);
	arc(77, 48, 340, 360 + 100, 1);

	getimage(0, 0, 100, 100, rock);
	clearviewport();

	// Paper Design
	setcolor(7);
	setfillstyle(1, 7);
	bar(20, 15, 80, 25);
	pieslice(20, 20, 0, 360, 5);
	pieslice(80, 20, 0, 360, 5);

	setcolor(8);
	circle(20, 20, 5);
	arc(80, 20, 270, 450, 5);

	setcolor(7);
	setfillstyle(1, 7);
	bar(20, 25, 80, 85);
	sector(20, 70, 90, 270, 2, 15);
	sector(80, 40, 0, 360, 2, 15);

	setcolor(0);
	setfillstyle(1, 0);
	sector(20, 40, 0, 360, 2, 15);
	sector(80, 70, 90, 270, 2, 15);

	setcolor(8);
	ellipse(20, 40, 270, 450, 2, 15);
	ellipse(20, 70, 90, 270, 2, 15);
	ellipse(80, 40, 270, 450, 2, 15);
	ellipse(80, 70, 90, 270, 2, 15);
	line(20, 15, 80, 15);
	line(20, 25, 80, 25);
	line(20, 85, 80, 85);

	line(35, 35, 70, 35);
	line(50, 40, 70, 40);
	line(50, 45, 70, 45);
	line(50, 50, 70, 50);

	rectangle(35, 40, 45, 50);

	line(35, 60, 70, 60);
	line(35, 65, 70, 65);
	line(35, 70, 70, 70);
	line(35, 75, 70, 75);

	getimage(0, 0, 100, 100, paper);
	clearviewport();

	// Scissors Design

	setcolor(8);
	setlinestyle(0, 0, 0);
	setfillstyle(1, 7);

	int lblade[10] = {35, 55,
			  30, 50,
			  85, 30,
			  86, 33,
			  35, 55};

	int rblade[10] = {45, 65,
			  50, 70,
			  70, 15,
			  67, 14,
			  45, 65};

	fillpoly(5, lblade);
	fillpoly(5, rblade);

	setlinestyle(0, 0, 3);
	rotateEllipse(20, 60, 16, 8, -25);
	rotateEllipse(40, 80, 16, 8, -65);

	setfillstyle(1, 12);
	setlinestyle(0, 0, 1);
	fillRotEllipse(20, 60, 16, 8, -25);
	fillRotEllipse(40, 80, 16, 8, -65);

	setfillstyle(1, 0);
	fillRotEllipse(20, 60, 8, 4, -25);
	fillRotEllipse(40, 80, 8, 4, -65);

	getimage(0, 0, 100, 100, scissors);
	cleardevice();

	// Returns active, working page to the current page.
	setactivepage(0);
	setviewport(0, 0, getmaxx(), getmaxy(), 0);
	setcolor(15);
	setfillstyle(0, 15);
	setlinestyle(0, 0, 15);
	return 0;
}

// Function responsible for redrawing non-static game states (eg. menus)
// The argument info allows us to pass some information to the redrawer,
// which allows us to change some elements of the game.
void redrawviewport (int mode, int info) {

	char numBuffer[3];
	char roundsbf[10], playerbf[13];
	char plyscrbf[3], comscrbf[3];

	sprintf(numBuffer,"%d", rounds);
	sprintf(roundsbf, "Round %d", currentRound);
	sprintf(playerbf, "%s", playerName);

	sprintf(plyscrbf, "%d", pScore);
	sprintf(comscrbf, "%d", cScore);

	switch (mode) {
		case 1: // Main Menu
			outtextxy(230, 50, "Play");
			outtextxy(230, 80, "How to Play");
			outtextxy(230, 110, "Quit");

			// Handle pointer redraws
			pointer(210, 63 + (30 * info), 8);
			break;
		case 2: // Exit confirmation
			centertext(5, "Do you want to quit the game?");
			centertext(105, -30, "Yes");
			centertext(105, +30, "No");
			break;
		case 3: // Game options
			settextstyle(7, 0, 1);
			centertext(15, "Game Setup");

			if (info == 1) setcolor(YELLOW);
			settextstyle(1, 0, 1);
			centertext(45, "Player Name");
			if (info == 1) setcolor(WHITE);

			settextstyle(2, 0, 8);
			centertext(65, playerName);

			if (info == 2) setcolor(YELLOW);
			settextstyle(1, 0, 1);
			centertext(90, "Number of Games");
			if (info == 2) setcolor(WHITE);

			settextstyle(2, 0, 8);
			centertext(110, numBuffer);

			if (rounds >= 10) pointer(textcenter(0, numBuffer) - 5, (textheight(numBuffer) / 2) + 110, -3);
			else if (rounds <= 1) pointer(textcenter(0, numBuffer) + textwidth(numBuffer) + 2, (textheight(numBuffer) / 2) + 110, 3);
			else {
				pointer(textcenter(0, numBuffer) - 5, (textheight(numBuffer) / 2) + 110, -3);
				pointer(textcenter(0, numBuffer) + textwidth(numBuffer) + 2, (textheight(numBuffer) / 2) + 110, 3);
			}

			settextstyle(2, 0, 8);
			if (info == 3) setcolor(YELLOW);
			centertext(140, "Start Game");
			if (info == 3) setcolor(WHITE);
			break;
		case 4:  // Game proper: round setup
			settextstyle(2, 0, 8);
			getviewsettings(&vinf);

			// Character Portrait Boxes
			line(150, 0, 150, 150);
			line(0, 120, 150, 120);
			line(0, 150, 150, 150);

			line(0, vinf.bottom - 150 - 11, 150, vinf.bottom - 150 - 11);
			line(0, vinf.bottom - 120 - 11, 150, vinf.bottom - 120 - 11);
			line(150, vinf.bottom - 150 - 11, 150, vinf.bottom - 11);

			robot(0);
			player(0);

			// Nameplates
			settextstyle(2, 0, 7);
			outtextxy((150 - textwidth(playerbf)) / 2, 120 + (30 - textheight("H")) / 2, playerbf);
			outtextxy((150 - textwidth("Computer")) / 2, (vinf.bottom - 150 - 11) + (30 - textheight("H")) / 2, "Computer");

			// Scoreboard
			settextstyle(2, 0, 8);
			line(50, 240, 100, 240);
			outtextxy((150 - textwidth(plyscrbf)) / 2, 235 - textheight("H"), plyscrbf);
			outtextxy((150 - textwidth(comscrbf)) / 2, 240, comscrbf);

			// Round header
			delay(1250);
			centertext((vinf.bottom - vinf.top - textheight("W")) / 2, roundsbf);
			delay(1250);
			settextstyle(0, 0, 0);
			centertext((vinf.bottom - vinf.top - textheight("W")) / 2 + 20, "Press any key...");
			settextstyle(2, 0, 8);
			getch();
			clearviewport();

			// Rewrites screen again for next part of animation
			// Nameplates
			settextstyle(2, 0, 7);
			outtextxy((150 - textwidth(playerbf)) / 2, 120 + (30 - textheight("H")) / 2, playerbf);
			outtextxy((150 - textwidth("Computer")) / 2, (vinf.bottom - 150 - 11) + (30 - textheight("H")) / 2, "Computer");

			// Scoreboard
			settextstyle(2, 0, 8);
			line(50, 240, 100, 240);
			outtextxy((150 - textwidth(plyscrbf)) / 2, 235 - textheight("H"), plyscrbf);
			outtextxy((150 - textwidth(comscrbf)) / 2, 240, comscrbf);

			// Character Portrait Boxes
			line(150, 0, 150, 150);
			line(0, 120, 150, 120);
			line(0, 150, 150, 150);

			line(0, vinf.bottom - 150 - 11, 150, vinf.bottom - 150 - 11);
			line(0, vinf.bottom - 120 - 11, 150, vinf.bottom - 120 - 11);
			line(150, vinf.bottom - 150 - 11, 150, vinf.bottom - 11);

			robot(0);
			player(0);

			// Choices display animation
			putimage(400, 50, rock, 0);

			delay(750);
			putimage(400, 175, paper, 0);

			delay(750);
			putimage(400, 300, scissors, 0);

			delay(750);
			pointer(350, 100, 12);
			break;
		case 5: // Game proper: player update
			settextstyle(2, 0, 8);
			getviewsettings(&vinf);

			settextstyle(2, 0, 7);
			outtextxy((150 - textwidth(playerbf)) / 2, 120 + (30 - textheight("H")) / 2, playerbf);
			outtextxy((150 - textwidth("Computer")) / 2, (vinf.bottom - 150 - 11) + (30 - textheight("H")) / 2, "Computer");

			line(150, 0, 150, 150);
			line(0, 120, 150, 120);
			line(0, 150, 150, 150);

			line(0, vinf.bottom - 150 - 11, 150, vinf.bottom - 150 - 11);
			line(0, vinf.bottom - 120 - 11, 150, vinf.bottom - 120 - 11);
			line(150, vinf.bottom - 150 - 11, 150, vinf.bottom - 11);

			robot(0);
			player(0);

			settextstyle(2, 0, 8);
			line(50, 240, 100, 240);
			outtextxy((150 - textwidth(plyscrbf)) / 2, 235 - textheight("H"), plyscrbf);
			outtextxy((150 - textwidth(comscrbf)) / 2, 240, comscrbf);

			settextstyle(2, 0, 7);
			outtextxy(175, 25, "Your Move");
			outtextxy(175, vinf.bottom - 25 - 11 - textheight("C"), "CPU  Move");


			putimage(400, 50, rock, 0);
			putimage(400, 175, paper, 0);
			putimage(400, 300, scissors, 0);

			if (info == 1) {
				pointer(350, 100, 12);
				putimage(175, 50, rock, 0);
			} else if (info == 2) {
				pointer(350, 225, 12);
				putimage(175, 50, paper, 0);
			} else if (info == 3) {
				pointer(350, 350, 12);
				putimage(175, 50, scissors, 0);
			}
			break;
		case 6: // Game proper: comp choice
			settextstyle(2, 0, 8);
			getviewsettings(&vinf);

			settextstyle(2, 0, 7);
			outtextxy((150 - textwidth(playerbf)) / 2, 120 + (30 - textheight("H")) / 2, playerbf);
			outtextxy((150 - textwidth("Computer")) / 2, (vinf.bottom - 150 - 11) + (30 - textheight("H")) / 2, "Computer");

			line(150, 0, 150, 150);
			line(0, 120, 150, 120);
			line(0, 150, 150, 150);

			line(0, vinf.bottom - 150 - 11, 150, vinf.bottom - 150 - 11);
			line(0, vinf.bottom - 120 - 11, 150, vinf.bottom - 120 - 11);
			line(150, vinf.bottom - 150 - 11, 150, vinf.bottom - 11);

			robot(1);
			player(0);

			settextstyle(2, 0, 8);
			line(50, 240, 100, 240);
			outtextxy((150 - textwidth(plyscrbf)) / 2, 235 - textheight("H"), plyscrbf);
			outtextxy((150 - textwidth(comscrbf)) / 2, 240, comscrbf);

			settextstyle(2, 0, 7);
			outtextxy(175, 25, "Your Move");
			outtextxy(175, vinf.bottom - 25 - 11 - textheight("C"), "CPU's Move");

			putimage(400, 50, rock, 0);
			putimage(400, 175, paper, 0);
			putimage(400, 300, scissors, 0);

			if (pMove == 1) putimage(175, 50, rock, 0);
			else if (pMove == 2) putimage(175, 50, paper, 0);
			else if (pMove == 3) putimage(175, 50, scissors, 0);

			if (info == 1) {
				pointer(350, 100, 12);
				putimage(175, vinf.bottom - 150 - 11, rock, 0);
			} else if (info == 2) {
				pointer(350, 225, 12);
				putimage(175, vinf.bottom - 150 - 11, paper, 0);
			} else if (info == 3) {
				pointer(350, 350, 12);
				putimage(175, vinf.bottom - 150 - 11, scissors, 0);
			}
			break;
		case 7: // game proper: round results screen
			settextstyle(2, 0, 8);
			getviewsettings(&vinf);

			settextstyle(2, 0, 7);
			outtextxy((150 - textwidth(playerbf)) / 2, 120 + (30 - textheight("H")) / 2, playerbf);
			outtextxy((150 - textwidth("Computer")) / 2, (vinf.bottom - 150 - 11) + (30 - textheight("H")) / 2, "Computer");

			line(150, 0, 150, 150);
			line(0, 120, 150, 120);
			line(0, 150, 150, 150);

			line(0, vinf.bottom - 150 - 11, 150, vinf.bottom - 150 - 11);
			line(0, vinf.bottom - 120 - 11, 150, vinf.bottom - 120 - 11);
			line(150, vinf.bottom - 150 - 11, 150, vinf.bottom - 11);

			settextstyle(2, 0, 8);
			line(50, 240, 100, 240);
			outtextxy((150 - textwidth(plyscrbf)) / 2, 235 - textheight("H"), plyscrbf);
			outtextxy((150 - textwidth(comscrbf)) / 2, 240, comscrbf);

			settextstyle(2, 0, 7);
			outtextxy(175, 25, "Your Move");
			outtextxy(175, vinf.bottom - 25 - 11 - textheight("C"), "CPU's Move");

			if (pMove == 1) putimage(175, 50, rock, 0);
			else if (pMove == 2) putimage(175, 50, paper, 0);
			else if (pMove == 3) putimage(175, 50, scissors, 0);

			if (cMove == 1) putimage(175, vinf.bottom - 150 - 11, rock, 0);
			else if (cMove == 2) putimage(175, vinf.bottom - 150 - 11, paper, 0);
			else if (cMove == 3) putimage(175, vinf.bottom - 150 - 11, scissors, 0);

			if (info == 1) {
				settextstyle(2, 0, 9);
				setcolor(YELLOW);
				outtextxy(300 + (vinf.right - 300 - textwidth(playerbf)) / 2, (vinf.bottom - vinf.top - textheight("Y")) / 2, playerbf);
				settextstyle(0, 0, 0);
				setcolor(WHITE);
				outtextxy(300 + (vinf.right - 300 - textwidth("Wins")) / 2, 25 + (vinf.bottom - vinf.top - textheight("Y")) / 2, "Wins");
				robot(2);
				player(3);
			} else if (info == 2) { //
				settextstyle(2, 0, 9);
				setcolor(RED);
				outtextxy(300 + (vinf.right - 300 - textwidth("Computer")) / 2, (vinf.bottom - vinf.top - textheight("Y")) / 2, "Computer");
				settextstyle(0, 0, 0);
				setcolor(WHITE);
				outtextxy(300 + (vinf.right - 300 - textwidth("Wins")) / 2, 25 + (vinf.bottom - vinf.top - textheight("Y")) / 2, "Wins");
				robot(3);
				player(1);
			} else if (info == 3) { // Draw
				settextstyle(2, 0, 9);
				setcolor(GREEN);
				outtextxy(300 + (vinf.right - 300 - textwidth("Draw")) / 2, (vinf.bottom - vinf.top - textheight("Y")) / 2, "DRAW");
				settextstyle(0, 0, 0);
				setcolor(WHITE);
				outtextxy(300 + (vinf.right - 300 - textwidth("It\'s a")) / 2, -25 + (vinf.bottom - vinf.top - textheight("Y")) / 2, "It\'s a");
				robot(0);
				player(2);
			}
			break;
		case 8: // Game proper: results screen
			settextstyle(2, 0, 8);
			getviewsettings(&vinf);

			settextstyle(2, 0, 7);
			outtextxy((150 - textwidth(playerbf)) / 2, 120 + (30 - textheight("H")) / 2, playerbf);
			outtextxy((150 - textwidth("Computer")) / 2, (vinf.bottom - 150 - 11) + (30 - textheight("H")) / 2, "Computer");

			line(150, 0, 150, 150);
			line(0, 120, 150, 120);
			line(0, 150, 150, 150);

			line(0, vinf.bottom - 150 - 11, 150, vinf.bottom - 150 - 11);
			line(0, vinf.bottom - 120 - 11, 150, vinf.bottom - 120 - 11);
			line(150, vinf.bottom - 150 - 11, 150, vinf.bottom - 11);

			if (info == 1) {
				setcolor(GREEN);
				centertext(190, "You WIN!");
				player(3);
				robot(2);
			} else if (info == 3) {
				setcolor(YELLOW);
				centertext(190, "It's a TIE!");
				player(2);
				robot(0);
			} else if (info == 2) {
				setcolor(RED);
				centertext(190, "You LOSE!");
				player(1);
				robot(3);
			}

			delay(1200);
			setcolor(WHITE);
			centertext((vinf.bottom - vinf.top - textheight("W")) / 2, -(30 + textwidth(playerbf)), playerbf);
			centertext((vinf.bottom - vinf.top - textheight("W")) / 2, 30 + textwidth("Player"), "Computer");

			outtextxy(textcenter(-(30 + textwidth(playerbf)), playerbf) + (textwidth(playerbf) - textwidth(plyscrbf)) / 2, 5 + textheight("W") + (vinf.bottom - vinf.top - textheight("W")) / 2, plyscrbf);
			outtextxy(textcenter(30 + textwidth("Player"), "Computer") + (textwidth("Computer") - textwidth(comscrbf)) / 2, 5 + textheight("W") + (vinf.bottom - vinf.top - textheight("W")) / 2, comscrbf);
			delay(1200);
			settextstyle(0, 0, 0);
			centertext(100 + (vinf.bottom - vinf.top - textheight("W")) / 2, "Press any key to continue...");
			break;
		default:
			return;
	}
}


		     /* Screens */
void loading (int min) {
	int i;

	// Initialize string loading states
	char loading[3][11] = {"Loading.", "Loading..", "Loading..."};

	getviewsettings(&vinf);
	settextstyle(0, 0, 0);

	/* Randomize number of loading animation cycles */
	for (i = 0; i <= min + rand() % 31; i++) {
		int frame = 0; // Reset frame to 0;

		// Loop to write frames
		while (frame != 3) {
			centertext((vinf.bottom - vinf.top - textheight(loading[frame])) / 2, loading[frame]); // Write frame
			delay(125);
			clearviewport();
			frame++; // Shift to next frame
		};

		clearviewport();

	}

}


void title() {
	int centerx, centery;


	resetviewport(0);
	border();

	// Title
	setviewport(30, 30, getmaxx() - 30, getmaxy() - 30, 0);
	getviewsettings(&vinf);

	settextstyle(8, 0, 1);
	outtextxy(225, 30, "Welcome to");

	settextstyle(4, 0, 6);
	outtextxy(45, 45, "ROCK");

	delay(225);

	settextstyle(10, 0, 4);
	outtextxy(210, 95, "Paper");

	delay(225);

	settextstyle(5, 0, 7);
	outtextxy(345, 135, "Scissors");

	resetviewport(0);
	rectangle(30, (getmaxy() / 2) + 30, getmaxx() - 30, getmaxy() - 25);
	setviewport(31, (getmaxy() / 2) + 31, getmaxx() - 31, getmaxy() - 26, 0);

}

int mainMenu() {
	int cChoices = 0;
	getviewsettings(&vinf);
	enum Message msg;

	settextstyle(7, 0, 2);
	pointer(210, 63, 8);
	redrawviewport(1, cChoices);

	// Main Menu Process
	do {
		msg = awaitKey(); // Await incoming message
		clearviewport();   // Clear existing screen

		/* Handle messages from awaitKey() */
		switch (msg) {
			case MOVECURYN:
				cChoices--;
				break;
			case MOVECURYP:
				cChoices++;
				break;
			case SELECT:
				clearviewport();
				return cChoices;
			case BACK:
				clearviewport();
				return -1;
		}

		// Handle overflow
		if (cChoices >= 3) cChoices = 0;
		else if (cChoices <= -1) cChoices = 2;

		redrawviewport(1, cChoices); // Redraw menu messages
	} while (1 == 1);
}

void help () {
	getviewsettings(&vinf);

	settextstyle(0, 0, 1);
	centertext(10, "How to Play");
	centertext(30, "At the beginning of each move, the player chooses whether their");
	centertext(40, "move is rock, paper, or scissors.");
	centertext(60, "The computer then generates a random move.");
	centertext(80, "The game then evaluates who gets a point");
	centertext(90, "based on the following criteria:");
	centertext(115, "PAPER beats ROCK");
	centertext(125, "ROCK beats SCISSORS");
	centertext(135, "SCISSORS beats PAPER");

	centertext(160, "The player who gets the highest points");
	centertext(170, "after a specified number of games wins!");

	delay(125);

	getch();
	clearviewport();

	centertext(10, "Controls");
	centertext(75, "Use WASD to navigate through controls.");
	centertext(85, "Use Space or Enter to select an item in the menu.");
	centertext(95, "Use Esc to go to the previous screen.");

	getch();
	clearviewport();
}

int exit () {
	enum Message msg;
	getviewsettings(&vinf);

	// Variable for chosen option
	int cChoices = 0;

	// Screen setup
	settextstyle(7, 0, 2);
	redrawviewport(2, 0);
	rectangle((viewwidth() - textwidth("Yes")) / 2 - 30 - 5, 100, 5 + textwidth("Yes") + ((viewwidth() - textwidth("Yes")) / 2 - 30), 110 + textheight("Yes"));

	do {
		// Await key press
		msg = awaitKey();

		// Redraw static parts of the screen
		clearviewport();
		redrawviewport(2, 0);

		// Execute command per key press
		switch (msg) {
			case MOVECURXN:
				cChoices = 1 - cChoices;
				break;
			case MOVECURXP:
				cChoices = 1 - cChoices;
				break;
			case MOVECURYN:
				cChoices = 1 - cChoices;
				break;
			case MOVECURYP:
				cChoices = 1 - cChoices;
				break;
			case SELECT:
				if (cChoices == 0) return 1; // Transfer control to to quit if Yes
				else if (cChoices == 1) return 0; // Return control to menu screen if No
			case BACK:
				return 0;
		}

		// Highlight selected option
		if (cChoices == 0) rectangle((viewwidth() - textwidth("Yes")) / 2 - 30 - 5, 100, 5 + textwidth("Yes") + ((viewwidth() - textwidth("Yes")) / 2 - 30), 115 + textheight("Yes"));
		else if (cChoices == 1) rectangle((viewwidth() - textwidth("No")) / 2 + 30 - 5, 100, 5 + textwidth("No") + ((viewwidth() - textwidth("No")) / 2 + 30), 115 + textheight("No"));

	} while (1);
}

// Manages number of rounds to play selection
int numGames (Message msg) {
	// Stores the number of games used in the game setup screen
	char numBuffer[3];

	// Loop that facilitates the entirety of name entry process
	do {
			clearviewport();
			redrawviewport(3, 2);
			msg = awaitKey(); // Awaits key press

			// Facilitates keypress commands
			// For MOVECURXP and MOVECURXN, the global variable rounds
			// is changed so that game settings for game setup is saved
			switch (msg) {
				case BACK:
					clearviewport();
					return -1; // -1 indicates a back command
				case SELECT:
					return 0;  // 0 indicates successful rounds selection
				case MOVECURXN:
					rounds--;
					break;
				case MOVECURXP:
					rounds++;
					break;
			}

			// Ensures rounds stay bounded between 1-10 rounds
			if (rounds >= 10) rounds = 10;
			else if (rounds <= 1) rounds = 1;

	} while (1);
}

// Facilitates player name process
int playerselect () {
	// Initializes index at the current player name
	int index = strlen(playerName);
	int keypress;

	do {
		clearviewport();
		redrawviewport(3, 1);

		// Detects a generic key press
		keypress = getch();

		// Executes commands based on keypresses
		if (keypress == 27) break; // Exits when Esc is detected
		else if ((keypress == 13) || (keypress == 32)) return 0; // Proceeds to next screen upon Space/Enter
		else if (keypress == 8) { // Processes backspace
			if (index > 0) {  // Checks if current index is not below 0
				index--;  // Shifts index
				playerName[index] = '\0'; // Replaces current index with a null character (to simulate key deletion)
			}
		} else { // Facilitates any other key presses
			if (index <= 12){ // Checks if current index is greater than 12 (max name limit)
				playerName[index] = char(keypress);
				index++;
				playerName[index] = '\0';
			}
		}

	} while (1);
	return -1;
}

// Takes care of game setup
// It combines the two preceding game setup functions in one.
int gameSetup () {
	enum Message msg;
	getviewsettings(&vinf);

	int cmd;

	do {
		pselect:
		;
		cmd = playerselect();
		if (cmd == -1) {
			clearviewport();
			return -1;
		}

		roundchoices:
		;
		cmd = numGames(msg);
		if (cmd == -1) goto pselect;


		// Start game confirmation
		do {
			clearviewport();
			redrawviewport(3, 3);

			msg = awaitKey();

			switch (msg) {
				case SELECT:
					return 0;
			}
		} while (msg != BACK);

		if (msg == BACK) goto roundchoices;

	} while (1);
}

int playerChoice() {
	Message msg;
	int playerChoice = 1;

	do {
		redrawviewport(5, playerChoice);
		msg = awaitKey();
		clearviewport();

		switch (msg) {
			case MOVECURYN:
				playerChoice--;
				break;
			case MOVECURYP:
				playerChoice++;
				break;
			case SELECT:
				//computerchoice();
				return playerChoice;
			case BACK:
				return -1;
		}

		if (playerChoice > 3) playerChoice = 1;
		else if (playerChoice < 1) playerChoice = 3;

	} while (1);
}

// Handles and animates computer choice
int computerChoice () {

	int i, move = 0, prevMove = 0;

	// Predetermines a computer choice from 1 - 3
	// This is the actual computer move to be used in the game
	cMove = 1 + rand() % 3;

	// This cycles
	for (i = 1; i <= 40; i++) {
		// Compute next duration
		int duration = (25 + (975 / (1 + exp(-(i - 40))))); // Logistic function for determining duration of each roulette move

		// Simulate next roulette move
		do {
			prevMove = move;
			move = 1 + rand() % 3;
		} while (prevMove == move); // Prevents the randomizer to

		// Draw/update screen
		clearviewport();
		redrawviewport(6, move);

		delay(duration);
	}

	clearviewport();
	redrawviewport(6, cMove);
	return cMove;
}

void scoreUpdater (int mode) {
	switch (mode) {
		case 1: // Wins
			redrawviewport(7, 1);
			pScore++;
			delay(1500);
			clearviewport();
			redrawviewport(7, 1);
			break;
		case 2: // Losses
			redrawviewport(7, 2);
			cScore++;
			delay(1500);
			clearviewport();
			redrawviewport(7, 2);
			break;
		case 3: // Draw
			redrawviewport(7, 3);
			cScore++;
			pScore++;;
			delay(1500);
			clearviewport();
			redrawviewport(7, 3);
			break;
		default:
			return;
	}
}

void gameProper () {

	pMove = 1, pScore = 0;
	cMove = 1, cScore = 0;

	currentRound = 1;

	enum Message msg;

	resetviewport(1);
	cleardevice();
	border();

	setviewport(11, 11, getmaxx() - 11, getmaxy() - 11, 0);
	getviewsettings(&vinf);

	loading(15);

	do {
		clearviewport();
		redrawviewport(4, 0);
		pMove = playerChoice();
		if (pMove == -1) return;

		cMove = computerChoice();

		delay(1200);
		clearviewport();

		switch (pMove) {
			case 1:
				switch (cMove) {
					case 1:
						scoreUpdater(3);
						break;
					case 2:
						scoreUpdater(2);
						break;
					case 3:
						scoreUpdater(1);
						break;
				}
				break;
			case 2:
				switch (cMove) {
					case 1:
						scoreUpdater(1);
						break;
					case 2:
						scoreUpdater(3);
						break;
					case 3:
						scoreUpdater(2);
						break;
				}
				break;
			case 3:
				switch (cMove) {
					case 1:
						scoreUpdater(2);
						break;
					case 2:
						scoreUpdater(1);
						break;
					case 3:
						scoreUpdater(3);
						break;
				}
				break;
		}

		getch();
		currentRound++;
	} while (currentRound <= rounds);

	clearviewport();
	if (pScore > cScore) redrawviewport(8, 1);
	else if (pScore < cScore) redrawviewport(8, 2);
	else if (pScore == cScore) redrawviewport(8, 3);

	getch();
	resetviewport(0);

}

void freeAssets () {
	free(rock);
	free(paper);
	free(scissors);
}




/* Control */
int main () {

	clrscr();
	srand(time(0));
	int mainChoice, cmd;
	int isAssetLoadSuccessful;
	gconfig gc;

	startGraphics(gc);

	isAssetLoadSuccessful = initAssets();
	if (isAssetLoadSuccessful == -1) {
		freeAssets();
		return -1;
	}
	loading(3);
	delay(50);
	border();

	do {
		cmd = 0;
		clearviewport();
		title();
		mainChoice = mainMenu();

		switch (mainChoice) {
			case -1:
				clearviewport();
				cmd = exit();
				if (cmd == 1) mainChoice = 2;
				break;
			case 0:
				cmd = gameSetup();
				if (cmd == -1) break;
				gameProper();
				break;
			case 1:
				help();
				break;
		};

	} while (mainChoice != 2);

	freeAssets();
	endGraphics();

	return 0;
}