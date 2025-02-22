package Exercise3;

import java.util.Random;
import java.util.Scanner;

public class GuessingGame {
    static Random r = new Random();
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        int luckyNumber = r.nextInt(1, 21);

        do {
            System.out.print("Enter a number between 1 and 20: ");
            int n = s.nextInt();

            if (luckyNumber == n) {
                System.out.println("You won!");
                break;
            } else System.out.println("Try again.");
        } while (true);
    }
}
