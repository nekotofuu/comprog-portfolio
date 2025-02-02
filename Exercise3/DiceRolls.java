package Exercise3;

import java.util.Random;

public class DiceRolls {
    private static Random r = new Random();

    public static void main(String[] args) {
        System.out.format("%8s %8s %8s\n", "Dice 1", "Dice 2", "Dice 3");
        for (int i = 1; i <= 5; i++) {
            int n1 = r.nextInt(1, 7);
            int n2 = r.nextInt(1, 7);
            System.out.format("%8d %8d %8d\n", n1, n2, n1 + n2);
        }
    }
}
