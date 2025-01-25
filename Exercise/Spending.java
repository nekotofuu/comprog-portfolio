package Exercise;

import java.util.Scanner;

public class Spending {
    static Scanner s = new Scanner(System.in);

    private static int getTotal(int[] intArray) {
        int total = 0;
        for (int i : intArray) total += i;
        return total;
    }

    public static void main (String[] args) {
        String[] expenseName = {"Food", "Clothing", "Entertainment", "Rent"};
        int[] expenses = new int[4];
        int total;

        System.out.println("Enter the amount spent last month on the following items:\n");
        for (int i = 0; i <= 3; i++) {
            System.out.print(expenseName[i] + ": $");
            expenses[i] = s.nextInt();
        }

        total = getTotal(expenses);

        System.out.format("\n%-18s %8s\n", "Category", "Budget");
        for (int i = 0; i <= 3; i++) {
            System.out.format("%-18s %8s %%\n", expenseName[i], String.format("%.2f", 100 * ((double)expenses[i] / (double)total)));
        }
    }
}

