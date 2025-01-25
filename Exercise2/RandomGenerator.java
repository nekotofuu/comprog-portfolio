package Exercise2;

public class RandomGenerator {
    private static int randomLCM(int a, int c, int m, int x) {
        return (a * x + c) % m;
    }

    public static void main(String[] args) {
        final int a = 1246;
        final int c = 200;
        final int m = 50;

        int seed = 11;

        System.out.printf("Seed = %d, a = %d, c = %d, m = %d\n\n", seed, a, c, m);
        int x = seed;
        for (int i = 1; i <= 20; i++) {
            System.out.printf("(%d * %d + %d) %% %d = %d\n", a, x, c, m, randomLCM(a, c, m, x));
            x = randomLCM(a, c, m, x);
        }

    }
}
