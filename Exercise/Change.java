package Exercise;

import java.util.Scanner;

public class Change {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.print("Enter the change in cents: ");
        int change = s.nextInt();

        int quarter = change / 25;
        int dime = (change - (25 * quarter)) / 10;
        int nickel = (change - (25 * quarter) - (10 * dime)) / 5;
        int penny = change - (25 * quarter) - (10 * dime) - (5 * nickel);

        System.out.println("The minimum number of coins are: ");
        System.out.println("\tQuarters: " + quarter);
        System.out.println("\tDimes: " + dime);
        System.out.println("\tNickels: " + nickel);
        System.out.println("\tPennies: " + penny);


    }
}
