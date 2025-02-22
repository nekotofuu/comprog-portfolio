package Exercise4;

import java.util.Scanner;

public class IsoTriangle {
    static Scanner s = new Scanner(System.in);

    private static void addSpaces(int size) {
        for (int i = 1; i <= size; i++) System.out.print(" ");
    }

    private static void drawBar(int size) {
        for (int i = 1; i <= size; i++) System.out.print("*");
    }

    public static void main(String[] args) {
        System.out.print("Enter a size: ");
        int size = s.nextInt();

        for (int i = 1; i <= size; i++) {
            addSpaces(size - i);
            drawBar(2 * i - 1);
            addSpaces(size - i);
            System.out.print("\n");
        }
    }
}
