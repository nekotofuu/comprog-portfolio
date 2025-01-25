package Exercise3;

import java.util.Scanner;
import java.util.LinkedList;

public class PrimeNumber2 {
    static Scanner s = new Scanner(System.in);

    private static boolean checkPrime(int n) {
        for (int i = 2; i < n; i++) {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static void main(String[] args) {
        LinkedList<Integer> primes = new LinkedList<>();
        System.out.println("Please enter two numbers.");

        System.out.print("\tFirst number: ");
        int n1 = s.nextInt();

        System.out.print("\tSecond number: ");
        int n2 = s.nextInt();

        for (int i = Math.min(n1, n2); i <= Math.max(n1, n2); i++) {
            if (checkPrime(i)) primes.add(i);
        }

        System.out.printf("The primes between %d and %d are:\n", Math.min(n1,n2), Math.max(n1, n2));
        for (int i : primes) System.out.printf("\t%d\n ", i);

    }
}
