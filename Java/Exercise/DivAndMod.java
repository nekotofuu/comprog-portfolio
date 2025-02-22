package Exercise;

import java.util.Scanner;

public class DivAndMod {
    public static void main (String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.println("Enter an integer: ");
        int a = s.nextInt();

        System.out.println("Enter a second integer: ");
        int b = s.nextInt();

        System.out.printf("%d / %d = %d\n", a, b, a / b);
        System.out.printf("%d %% %d = %d\n", a, b, a % b);

        System.out.printf("%d / %d = %d\n", b, a, b / a);
        System.out.printf("%d %% %d = %d\n", b, a, b % a);
    }
}
