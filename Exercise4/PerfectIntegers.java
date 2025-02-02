package Exercise4;

import java.util.ArrayList;
import java.util.HashMap;

public class PerfectIntegers {


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

        for (int i = 1; i <= Math.sqrt(n); i++) {
            if (n % i == 0 && n / i == i) {
                factors.add(i);
            } else if (n % i == 0) {
                int f2 = n / i;

                factors.add(i);
                factors.add(f2);
            }
        }

        return factors;
    }

    private static boolean isPerfect (int n) {
        int sum = 0;
        for (int i : getFactors(n)) sum += i;
        sum -= n;

        return (sum == n);
    }

    public static void main(String[] args) {
        for (int i = 1; i <= 100; i++) {
            if (isPerfect(i)) System.out.println(i);
        }
    }
}
