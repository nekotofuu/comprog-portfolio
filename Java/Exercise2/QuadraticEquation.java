package Exercise2;

import java.util.*;

public class QuadraticEquation {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.print("Enter a value for a: ");
        double a = s.nextDouble();
        System.out.print("Enter a value for b: ");
        double b = s.nextDouble();
        System.out.print("Enter a value for c: ");
        double c = s.nextDouble();

        double[] roots = {
                (-b + Math.sqrt(Math.pow(b ,2) - 4 * a * c)) / (2 * a),
                (-b - Math.sqrt(Math.pow(b ,2) - 4 * a * c)) / (2 * a)
        };

        System.out.printf("The roots are %.1f and %.1f", roots[0], roots[1]);
    }
}
