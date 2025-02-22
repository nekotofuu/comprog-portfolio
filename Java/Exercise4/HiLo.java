package Exercise4;

import java.util.*;

public class HiLo {
    private static Scanner s = new Scanner(System.in);
    private static Random r = new Random();


    private static void displayRules () {
        System.out.println("High Low Game\n");
        System.out.println("RULES");
        System.out.println("Numbers 1 through 6 are low");
        System.out.println("Numbers 8 through 13 are high");
        System.out.println("Number 7 is neither high nor low\n");
    }

    private static int game (int points) {
        System.out.printf("\nYou have %d points.\n", points);
        System.out.print("Enter points to risk: ");
        int riskPoints = s.nextInt();
        if (riskPoints > points) {
            System.out.println("Invalid number of points.");
            return 0;
        }


        System.out.println("Predict:");
        System.out.println("\t1) High");
        System.out.println("\t2) Low");

        System.out.print("Enter choice: ");

        try {
            int choice = s.nextInt();
            int random = r.nextInt(1, 14);

            if (choice == 1) {
                if (random < 7) {
                    System.out.println("You win.");
                    return riskPoints * 2;
                } else {
                    System.out.println("You lose.");
                    return -riskPoints;
                }
            } else if (choice == 2) {
                if (random > 7) {
                    System.out.println("You win.");
                    return riskPoints * 2;
                }
                else {
                    System.out.println("You lose.");
                    return -riskPoints;
                }
            } else {
                System.out.println("Invalid input. Try again");
                return 0;
            }
        } catch (InputMismatchException e) {
            System.out.println("Invalid input. Try again");
            return 0;
        }
    }


    public static void main(String[] args) {
        int points = 1000;
        displayRules();

        do {
            points += game(points);
        } while (!(points < 0));
    }
}
