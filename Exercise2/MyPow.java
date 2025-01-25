package Exercise2;

import java.util.Scanner;

public class MyPow {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.print("Enter a value for X: ");
        int x = s.nextInt();
        System.out.print("Enter a value for Y: ");
        int y = s.nextInt();

        System.out.printf("The result from using the formula: %f\n", Math.exp(y + Math.log(x)));
        System.out.printf("The result from using the Math pow(): %f", Math.pow(x, y));
    }
}
