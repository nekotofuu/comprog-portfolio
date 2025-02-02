package Exercise3;

import java.util.Scanner;

public class CountVowels {
    private static Scanner s = new Scanner(System.in);

    public static void main (String[] args) {
        System.out.print("Enter text: ");
        String text = s.nextLine();

        int vowels = 0;
        for (char c : text.toCharArray()) {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') vowels++;
        }

        System.out.printf("Your text has %d vowels.", vowels);

    }
}