package Exercise;

import java.util.Scanner;

public class TimeConversion {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter the time in minutes: ");
        int totalMinutes = input.nextInt();

        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;

        System.out.printf("The time is: %d:%02d\n", hours, minutes);

        input.close();
    }
}