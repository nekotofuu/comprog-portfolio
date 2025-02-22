package Exercise4;

import java.util.Scanner;

public class PrimeNumber {
    static Scanner s = new Scanner(System.in);

    private static boolean checkPrime(int n) {
        for (int i = 2; i < n; i++) {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static void main(String[] args) {
        System.out.print("Enter a number: ");
        int n = s.nextInt();

        if (checkPrime(n)) System.out.println("Your number is prime!");
        else System.out.println("Your number is not prime.");
    }
}
