package Exercise4;

import java.util.*;

public class AddCoins {
    private static Scanner s = new Scanner(System.in);

    private static String getDollarAmount (int quarter, int dime, int nickel, int penny) {
        return String.format("$%.2f", (0.25 * quarter) + (0.1 * dime) + (0.05 * nickel) + (0.01 * penny));
    }

    public static void main(String[] args) {
        System.out.println("Enter your total coins:");

        System.out.print("\tQuarters: ");
        int quarter = s.nextInt();

        System.out.print("\tDimes: ");
        int dime = s.nextInt();

        System.out.print("\tNickels: ");
        int nickel = s.nextInt();

        System.out.print("\tPennies: ");
        int penny = s.nextInt();

        System.out.printf("%nTotal: %s", getDollarAmount(quarter, dime, nickel, penny));
    }
}
