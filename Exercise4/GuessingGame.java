package Exercise4;

import java.util.Random;
import java.util.Scanner;

public class GuessingGame {
    static Random r = new Random();
    static Scanner s = new Scanner(System.in);

    private static boolean displayHint (int n, int luckyNumber) {
        if (n > luckyNumber) System.out.println("Too high");
        else if (n < luckyNumber) System.out.println("Too low");
        else {
            System.out.println("You guessed it!");
            return true;
        }

        return false;
    }

    public static void main(String[] args) {
        int luckyNumber = r.nextInt(1, 51);

        do {
            System.out.print("Enter a number between 1 and 50: ");
            int n = s.nextInt();

            if (displayHint(n, luckyNumber)) break;
        } while (true);
    }
}
