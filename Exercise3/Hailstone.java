package Exercise3;

import java.util.ArrayList;

/*
    Answers to question in the module:
    a) Yes
    b) 125 iterations until the next 4-2-1 loop; 171
 */

public class Hailstone {

    private static int getNextHailstoneNum(int n) {
        if (n % 2 == 0) return n / 2;
        else return 3 * n + 1;
    }

    public static void main(String[] args) {
        for (int i = 2; i <= 200; i++) {
            ArrayList<Integer> sequence = new ArrayList<>();
            int currentNum = i;

            while (getNextHailstoneNum(currentNum) != 4) {
                sequence.add(currentNum);
                currentNum = getNextHailstoneNum(currentNum);
            }

            sequence.add(currentNum);
            sequence.add(4);
            sequence.add(2);
            sequence.add(1);

            for (int j : sequence) System.out.printf("%d ", j);
            System.out.print("\n");
        }
    }
}
