package Exercise3;

import java.util.Scanner;
import java.util.ArrayList;

public class PrimeFactors {
    static Scanner s = new Scanner(System.in);

    private static boolean checkPrime(int n) {
        for (int i = 2; i < n; i++) {
            if (n % i == 0) return false;
        }
        return true;
    }

    private static ArrayList<Integer> getFactors (int n) {
        ArrayList<Integer> factors  = new ArrayList<>();

        if (checkPrime(n)) {
            factors.add(1);
            factors.add(n);
            return factors;
        }

        int currentNum = n;

        while (!(currentNum == 1)) {
            int currentFactor = getFirstFactor(currentNum);
            factors.add(currentFactor);
            currentNum /= currentFactor;
        }

        return factors;
    }

    private static int getFirstFactor (int n) {
        for (int i = 2; i < n; i++) if (n % i == 0) return i;
        return n;
    }

    public static void main(String[] args) {
        System.out.print("Enter a number: ");
        int n = s.nextInt();

        System.out.printf("The factors of %d are: ", n);
        for (int i : getFactors(n)) System.out.printf("%d * ", i);
        System.out.print("\b\b\b");

    }

}
