package Exercise2;

import java.util.Scanner;

public class InverseTrigFunctions {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.print("Please enter a number: ");
        double number = Math.toDegrees(s.nextDouble());
        System.out.printf("\nArcsin: %f", Math.asin(number));
        System.out.printf("\nArccos: %f", Math.acos(number));
        System.out.printf("\nArctan: %f", Math.atan(number));
    }
}
