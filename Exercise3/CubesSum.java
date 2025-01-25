package Exercise3;

import java.util.ArrayList;
import java.util.Scanner;

public class CubesSum {
    private static Scanner s = new Scanner(System.in);

    private static ArrayList<Integer> getDigits (int n) {
        ArrayList<Integer> digits = new ArrayList<>();
        int length = (int)Math.log10(n);

        for (int i = 0; i <= length; i++) {
            digits.add(removeLeadDigits(n, i, length) / (int)Math.pow(10, length - i));
        }

        return digits;
    }

    private static int removeLeadDigits (int n, int times, int length) {
        if (times == 0) return n;
        return removeLeadDigits(n % (int)Math.pow(10, length), times - 1, length - 1);
    }

    public static void main(String[] args) {
        System.out.print("Enter a positive integer: ");
        int n = s.nextInt();
        int cubeSum = 0;

        for (int i : getDigits(n)) cubeSum += (int)Math.pow(i, 3);

        System.out.printf("The sum of the cubes of the digits is: %d\n", cubeSum);

    }
}
