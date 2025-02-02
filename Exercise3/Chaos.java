package Exercise3;

import java.util.Scanner;

public class Chaos {
    private static Scanner s = new Scanner(System.in);

    private static double logistic (double x, double b) {
        return Math.pow(b, x) * (1 - x);
    }

    public static void main(String[] args) {
        System.out.print("Please enter a starting value: ");
        double currentValue = s.nextDouble();

        System.out.println("Value: " + currentValue);
        for (int i  = 1; i <= 50; i++) {
            currentValue = logistic(currentValue, 2);
            System.out.println("Value: " + currentValue);
        }
    }
}
