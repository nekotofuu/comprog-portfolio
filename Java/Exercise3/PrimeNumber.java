package Exercise3;

import java.util.Scanner;

public class PrimeNumber {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.print("Enter a number: ");
        int n = s.nextInt();
        boolean isPrime = true;

        for (int i = 2; i < n; i++) {
            if (n % i == 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime) System.out.println("Your number is prime!");
        else System.out.println("Your number is not prime.");
    }
}
