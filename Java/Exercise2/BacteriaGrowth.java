package Exercise2;

import java.util.Scanner;

public class BacteriaGrowth {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        int initial;
        double k, time, result;

        System.out.print("Enter initial bacteria amount: ");
        initial = s.nextInt();

        System.out.print("Enter constant growth rate for k: ");
        k = s.nextDouble();

        System.out.print("Enter growth time period in hours: ");
        time = s.nextDouble();

        result = initial * Math.exp(k * time);

        System.out.printf("\n%.1f bacteria will be present in %.1f hours", result, time);

    }
}
