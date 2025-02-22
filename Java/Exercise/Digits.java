package Exercise;

import java.util.*;

public class Digits {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.print("Enter a three-digit number: ");
        int n = s.nextInt();

        int hPlace = n / 100;
        int tPlace = (n % 100) / 10;
        int oPlace = (n % 100) % 10;

        System.out.println("The hundreds-place digit is: " + hPlace);
        System.out.println("The tens-place digit is: " + tPlace);
        System.out.println("The ones-place digit is: " + oPlace);
    }
}
