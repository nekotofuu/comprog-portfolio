package Exercise2;

import java.util.Scanner;

public class TrigFunctions {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.print("Please enter an angle in degrees: ");
        double angle = Math.toRadians(s.nextDouble());
        System.out.printf("\nSine: %f", Math.sin(angle));
        System.out.printf("\nCosine: %f", Math.cos(angle));
        System.out.printf("\nTangent: %f", Math.tan(angle));
    }
}
