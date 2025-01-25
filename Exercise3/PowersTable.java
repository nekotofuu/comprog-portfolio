package Exercise3;

public class PowersTable {
    public static void main(String[] args) {
        System.out.format("%6s %6s %6s %6s %6s\n", "x^1", "x^2", "x^3", "x^4", "x^5");
        for (int i = 1; i <= 6; i++) System.out.format("%6.0f %6.0f %6.0f %6.0f %6.0f\n", Math.pow(i, 1), Math.pow(i, 2), Math.pow(i, 3), Math.pow(i, 4), Math.pow(i, 5));
    }
}
