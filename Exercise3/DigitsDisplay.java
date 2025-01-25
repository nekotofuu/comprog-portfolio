package Exercise3;

import java.util.Scanner;
import java.util.ArrayList;

public class DigitsDisplay {
    static Scanner s = new Scanner(System.in);

    private static ArrayList<Integer> getDigits (int n) {
        ArrayList<Integer> digits = new ArrayList<>();
        int length = (int)Math.log10(n);

        for (int i = 0; i <= length; i++) {
            digits.add(removeLeadDigits(n, i) / (int)Math.pow(10, length - i));
        }

        return digits;
    }

    private static int removeLeadDigits (int n, int times) {
        int length = (int)Math.log10(n);
        if (times == 0) return n;
        return removeLeadDigits(n % (int)Math.pow(10, length), times - 1);
    }

    public static void main(String[] args) {
        System.out.print("Enter a positive integer: ");
        int n = s.nextInt();

        for (int i : getDigits(n)) System.out.println(i);
    }
}
