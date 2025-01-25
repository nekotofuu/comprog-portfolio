package Exercise2;

import java.util.Scanner;

public class Eggs {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int numEggs;
        double pricePerDozen;
        double totalBill;

        System.out.print("Enter the Number of Eggs purchased: ");
        numEggs = s.nextInt();

        int numDozens = numEggs / 12;
        int extraEggs = numEggs % 12;

        if (numDozens < 4) {
            pricePerDozen = 0.50;
        } else if (numDozens < 6) {
            pricePerDozen = 0.45;
        } else if (numDozens < 11) {
            pricePerDozen = 0.40;
        } else {
            pricePerDozen = 0.35;
        }

        totalBill = numDozens * pricePerDozen + extraEggs * (pricePerDozen / 12);

        System.out.printf("Bill is equal to: $%.2f%n", totalBill);
        s.close();
    }
}
