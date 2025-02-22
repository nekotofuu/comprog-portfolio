package Exercise2;

import java.util.*;

public class GuessingGame {
    static Random r = new Random();
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        int luckyNumber = r.nextInt(1, 21);
        System.out.print("Enter a number between 1 and 20: ");
        int n = s.nextInt();

        System.out.printf("Computer's Number: %d", luckyNumber);
        System.out.printf("Player's Number: %d", n);

        if (luckyNumber == n) System.out.println("You won!");
        else System.out.println("Better luck next time.");
    }
}
