package Exercise2;

import java.util.Scanner;

public class CarPayment {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        double p, r, m;
        System.out.print("Principal: ");
        p = s.nextDouble();

        System.out.print("Interest Rate: ");
        r = s.nextDouble();

        System.out.print("Number of monthly payments: ");
        m = s.nextDouble();

        double i = r / 12;
        System.out.printf("The monthly payment is: $.2%f", (p * i) / (1 - Math.pow(1 + i, -m)));
    }
}
