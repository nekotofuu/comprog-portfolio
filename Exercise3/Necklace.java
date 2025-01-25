package Exercise3;

import java.util.Scanner;
import java.util.ArrayList;

public class Necklace {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        ArrayList<Integer> sequence = new ArrayList<>();
        System.out.print("Enter the first starting number: ");
        int n1 = s.nextInt();

        System.out.print("Enter the second starting number: ");
        int n2 = s.nextInt();

        sequence.add(n1);
        sequence.add(n2);
        sequence.add((n1 + n2) % 10);

        do {
            sequence.add((sequence.getLast() + sequence.get(sequence.size() - 2)) % 10);
        } while (!(sequence.get(sequence.size() - 2) == n1 && sequence.getLast() == n2));

        for (int i : sequence) System.out.printf("%d ", i);
    }
}
