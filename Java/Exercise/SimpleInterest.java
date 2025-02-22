package Exercise;

import java.util.Scanner;

public class SimpleInterest {
    static Scanner s = new Scanner(System.in);

    private static double getInterest(double P, double r, double t) {
        return P * (1 + r * t);
    }

    public static void main(String[] args) {
        double principal, years, rate;

        System.out.print("Enter the principal: ");
        principal = s.nextDouble();
        System.out.print("Enter the number of years: ");
        years = s.nextDouble();
        System.out.print("Enter the interest rate: ");
        rate = s.nextDouble();
        System.out.printf("The value after the term is: $%.2f", getInterest(principal, rate, years));
    }
}
