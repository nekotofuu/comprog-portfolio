package Exercise4;

import java.util.*;

public class Nim {
    private static Scanner s = new Scanner(System.in);
    private static Random r = new Random();

    private static boolean isValidMove (int query, int stones) {
        return ((query <= 3 && query >= 1) || query < stones);
    }

    private static int userTurn (int stones) {
        int query = s.nextInt();
        if (isValidMove(query, stones)) return query;
        return 0;
    }

    private static int drawStones (int stones) {
        int query = r.nextInt(1, 4);
        if (stones <= 3) return stones;
        return query;
    }

    public static void main(String[] args) {
        int stones = r.nextInt(15, 31);

        boolean isPlayerTurn = r.nextBoolean();
        do {
            isPlayerTurn = !isPlayerTurn;
            System.out.printf("There are %d stones. ", stones);

            if (isPlayerTurn) {
                System.out.print("How many would you like? ");
                int query = userTurn(stones);

                if (query == 0) {
                    System.out.println("Invalid move!");
                    continue;
                }

                stones -= query;
            } else {
                int query = drawStones(stones);
                stones -= query;
                System.out.printf("The computer takes %d stones\n", query);
            }
        } while (stones > 0);

        if (!isPlayerTurn) System.out.println("\nThe player beats the computer!");
        else System.out.println("\nThe computer beats the player!");
    }
}
