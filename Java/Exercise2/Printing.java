package Exercise2;

import java.util.Scanner;

public class Printing {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.print("Enter the number of copies to be printed: ");
        int copy = s.nextInt();
        double price, total;

        if (copy < 99) price = .30;
        else if (copy < 499) price = .28;
        else if (copy < 749) price = .27;
        else if (copy < 999) price = .26;
        else price = .25;

        total = price * copy;

        System.out.printf("Price per copy: $%.2f", price);
        System.out.printf("Total cost: $%.2f", total);
    }
}
