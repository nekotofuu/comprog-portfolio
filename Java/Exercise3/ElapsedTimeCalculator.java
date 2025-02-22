package Exercise3;

import java.util.Scanner;

public class ElapsedTimeCalculator {
    static Scanner s = new Scanner(System.in);

    private static boolean flip (boolean b) {
        return !b;
    }

    public static void main(String[] args) {
        System.out.print("Enter the starting hour: ");
        int startHour = s.nextInt();

        boolean isAM;
        while (true) {
            System.out.print("Enter am or pm: ");
            String suffix = s.next();

            if (suffix.equalsIgnoreCase("AM")) {
                isAM = true;
                break;
            } else if (suffix.equalsIgnoreCase("PM")) {
                isAM = false;
                break;
            }

            System.out.println("Invalid input.");
        }

        System.out.print("Enter the elapsed time in hours: ");
        int elapsedTime = s.nextInt();
        int newHour;

        if ((startHour + elapsedTime) % 12 == 0) {
            newHour = 12;
            if (((startHour + elapsedTime) / 12) % 2 == 1) isAM = flip(isAM);
        } else if (startHour + elapsedTime < 12) {
            newHour = (startHour + elapsedTime) % 12;
        } else {
            newHour = (startHour + elapsedTime) % 12;
            if (((startHour + elapsedTime) / 12) % 2 == 1) isAM = flip(isAM);
        }

        if (isAM) System.out.printf("The time is %2d:00 am", newHour);
        else System.out.printf("The time is %02d:00 pm", newHour);

    }
}
