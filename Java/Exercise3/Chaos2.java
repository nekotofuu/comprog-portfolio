package Exercise3;

import java.util.Scanner;

public class Chaos2 {
    private static Scanner s = new Scanner(System.in);

    private static double logistic (double x, double b) {
        return Math.pow(b, x) * (1 - x);
    }

    public static void main(String[] args) {
        System.out.print("Please enter a base factor: ");
        double base = s.nextDouble();

        double currentValue = 0.5;
        System.out.println("Value: " + 0.5);
        for (int i  = 1; i <= 50; i++) {
            currentValue = logistic(currentValue, base);
            System.out.println("Value: " + currentValue);
        }
    }
}
