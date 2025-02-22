package Exercise;

import java.util.Scanner;

public class Order {
    public static void main (String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.print("Enter the number of burgers: ");
        int burger = s.nextInt();

        System.out.print("Enter the number of fries: ");
        int fries = s.nextInt();

        System.out.print("Enter the number of sodas: ");
        int soda = s.nextInt();

        double netCost = 1.69 * burger + 1.09 * fries + 0.99 * soda;
        double tax = netCost * 0.065;
        double total = netCost + tax;

        System.out.printf("Total before tax: $%.2f\n" ,netCost);
        System.out.printf("Tax: $%.2f\n", tax);
        System.out.printf("Final total: $%.2f\n", total);

        System.out.print("\nEnter amount tendered: $");
        double tendered = s.nextDouble();

        System.out.printf("Change: $%.2f", tendered - total);
    }
}
