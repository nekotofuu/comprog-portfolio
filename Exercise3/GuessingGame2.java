package Exercise3;

import java.util.Random;
import java.util.Scanner;

public class GuessingGame2 {
    static Random r = new Random();
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        int luckyNumber = r.nextInt(1, 51);

        do {
            System.out.print("Enter a number between 1 and 50: ");
            int n = s.nextInt();

            if (n > luckyNumber) System.out.println("Too high");
            else if (n < luckyNumber) System.out.println("Too low");
            else {
                System.out.println("You guessed it!");
                break;
            }
        } while (true);
    }
}
