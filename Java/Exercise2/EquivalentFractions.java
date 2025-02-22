package Exercise2;

import java.util.*;

class Fraction {
    private int N = 0;
    private int D = 0;

    public int getNum () {
        return N;
    }

    public int getDenom () {
        return D;
    }

    public int getWhole () {
        if (N < D) return 0;
        else return N / D;
    }

    public static String displayFrac (Fraction f) {
        return String.format("%d/%d", f.getNum(), f.getDenom());
    }

    public static String displayWhole (Fraction f) {
        return String.format("%d %d/%d", f.getWhole(), f.getNum() - (f.getWhole() * f.getDenom()), f.getDenom());
    }

    public static Fraction rewrite (Fraction f, int mult) {
        return new Fraction(f.getNum() * mult, f.getDenom() * mult);
    }

    Fraction (int numerator, int denominator, int whole) {
        N = numerator + (whole * denominator);
        D = denominator;
    }

    Fraction (int numerator, int denominator) {
        N = numerator;
        D = denominator;
    }
}

public class EquivalentFractions {
    static Scanner s = new Scanner(System.in);
    static Random r = new Random();

    enum Difficulty {
        EASY,
        HARD
    }

    private static boolean probTest (double probValue) {
        if (probValue >= 1 || r.nextDouble() <= probValue) return true;
        else return false;
    }

    public static void main(String[] args) {

        final Difficulty gameDifficulty;

        final int[] numberEasy = {1, 2, 3, 4, 5, 6, 7, 8};
        final int[] numberHard = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Choose a difficulty
        System.out.println("Welcome to Equivalent Fractions!");
        System.out.println("Please choose a difficulty:");

        System.out.println("\t1. Easy");
        System.out.println("\t2. Hard\n");

        System.out.print("Enter your choice: ");
        int userDiff = s.nextInt();

        switch (userDiff) {
            case 1:
                gameDifficulty = Difficulty.EASY;
                break;
            case 2:
                gameDifficulty = Difficulty.HARD;
                break;
            default:
                System.out.println("Invalid choice. Exiting...");
                return;
        }

        // Generate pairing solutions
        HashMap<Integer, Integer> pairs = new HashMap<>();
        HashMap<Integer, Integer> index = new HashMap<>();
        ArrayList<Integer> shufflePairs = new ArrayList<>();

        switch (gameDifficulty){
            case EASY -> { for (int i : numberEasy) shufflePairs.add(i); }
            case HARD -> {for (int i : numberHard) shufflePairs.add(i);}
        }

        Collections.shuffle(shufflePairs, r);

        for (int i = 0; i < shufflePairs.size(); i += 2) {
            index.put(shufflePairs.get(i), shufflePairs.get(i + 1));
            pairs.put(shufflePairs.get(i), shufflePairs.get(i + 1));
            pairs.put(shufflePairs.get(i + 1), shufflePairs.get(i));
        }

        // Generate fractions
        LinkedList<Fraction> baseFraction = new LinkedList<>();
        ArrayList<Fraction> choices = new ArrayList<>();

        switch (gameDifficulty) {
            case EASY -> {
                while (choices.size() < 8) choices.add(null);
                for (int i = 0; i < 4; i++) baseFraction.offer(new Fraction(r.nextInt(1, 11), r.nextInt(1, 11)));

                for (int key : index.keySet()) {
                    Fraction f = baseFraction.poll();
                    choices.set(key - 1, Fraction.rewrite(f, r.nextInt(1, 6)));
                    choices.set(pairs.get(key) - 1, Fraction.rewrite(f, r.nextInt(1, 6)));
                }
            }

            case HARD -> {
                while (choices.size() < 10) choices.add(null);
                for (int i = 0; i < 5; i++) baseFraction.offer(new Fraction(r.nextInt(1, 21), r.nextInt(1, 21)));

                for (int key : index.keySet()) {
                    Fraction f = baseFraction.poll();
                    choices.set(key - 1, Fraction.rewrite(f, r.nextInt(1, 11)));
                    choices.set(pairs.get(key) - 1, Fraction.rewrite(f, r.nextInt(1, 11)));
                }
            }
        }

        // Game Time
        int i = 0;
        int matchKey = 0;

        switch (gameDifficulty) {
            case EASY -> matchKey = r.nextInt(1, 9);
            case HARD -> matchKey = r.nextInt(1, 11);
        }

        System.out.println("\nGame Start!");
        for (Fraction f : choices) {
            i++;

            boolean isWhole = false;
            switch (gameDifficulty) {
                case EASY -> isWhole = probTest(0.12);
                case HARD -> isWhole = probTest(0.45);
            }

            if (isWhole && f.getNum() > f.getDenom() && f.getNum() % f.getWhole() != 0) System.out.printf("\t%d. %s\n", i, Fraction.displayWhole(f));
            else System.out.printf("\t%d. %s\n", i, Fraction.displayFrac(f));
        }

        System.out.printf("Which of these fractions is equivalent to #%d? ", matchKey);
        int userInput = s.nextInt();

        if (userInput == pairs.get(matchKey)) System.out.println("Correct!");
        else System.out.printf("Incorrect. It is #%d.", pairs.get(matchKey));
    }
}
