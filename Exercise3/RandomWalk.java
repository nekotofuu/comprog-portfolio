package Exercise3;

import java.util.Random;

public class RandomWalk {
    public static Random r = new Random();

    private static int step () {
        if (r.nextBoolean()) return 1;
        else return -1;
    }

    public static void main(String[] args) {
        int stepsAfter = 0;
        double stepAvg = 0;
        int maxSteps = 0;

        boolean hasSteppedOff = false;
        int currentPosition = 0;
        for (int i = 1; i <= 50; i++) {
            int step = step();
            currentPosition += step;
            stepAvg += ((double)step / 50);

            if (Math.abs(currentPosition) > maxSteps) maxSteps = currentPosition;
            if (Math.abs(currentPosition) > 3 && !hasSteppedOff) {
                stepsAfter = i;
                hasSteppedOff = true;
            }
        }

        System.out.println("Random Walk Results");
        if (stepAvg >= 0) System.out.printf("You have walked an average of %.2f steps to the right from the center of the bridge\n", Math.abs(stepAvg));
        else System.out.printf("You have walked an average of %.2f steps to the left from the center of the bridge\n", Math.abs(stepAvg));

        if (hasSteppedOff) System.out.printf("You got off the bridge after %d steps!\n", stepsAfter);
        else System.out.println("You did not get off the bridge after 50 steps...");

        System.out.printf("You achieved a maximum of %d steps away from the center of the bridge", maxSteps);
    }
}
