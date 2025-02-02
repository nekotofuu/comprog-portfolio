package Exercise3;

import java.util.Scanner;

public class RemoveString {
    private static Scanner s = new Scanner(System.in);

    public static void main (String[] args) {
        System.out.print("Enter a sentence: ");
        String sentence = s.nextLine();

        System.out.print("Enter a sting to remove: ");
        String targetString = s.nextLine();

        System.out.print(sentence.replaceAll(targetString, ""));
    }
}
