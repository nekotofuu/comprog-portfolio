package Exercise;

import java.util.Scanner;

public class Energy {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        final double c = 3.0 * Math.pow(10, 8);
        double e, m, l;

        System.out.print("Enter the mass in kilograms: ");
        m = s.nextDouble();
        e = m * c * c;
        l = e / 360000;

        System.out.println("The energy produced in Joules is = " + e);
        System.out.println("The number of 100-watt light bulbs powered = " + l);

    }
}
