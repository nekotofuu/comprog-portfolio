package Exercise3;

import java.util.ArrayList;

public class CubesSum2 {

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
        ArrayList<Integer> cubes = new ArrayList<>();

        for (int i = 10; i <= 9999; i++) {
            int cubeSum = 0;
            for (int j : getDigits(i)) cubeSum += (int) Math.pow(j, 3);
            if (cubeSum == i) cubes.add(i);
        }

        System.out.print("The numbers whose sum of the cubes of their digits is equal to itself are: ");
        for (int i : cubes) System.out.printf("%d, ", i);
        System.out.print("\b\b");
    }
}
