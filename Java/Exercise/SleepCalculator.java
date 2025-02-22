package Exercise;

import java.util.Scanner;

public class SleepCalculator {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter your birthdate:");
        System.out.print("Year: ");
        int birthYear = scanner.nextInt();
        System.out.print("Month: ");
        int birthMonth = scanner.nextInt();
        System.out.print("Day: ");
        int birthDay = scanner.nextInt();

        System.out.println("Enter today's date:");
        System.out.print("Year: ");
        int currentYear = scanner.nextInt();
        System.out.print("Month: ");
        int currentMonth = scanner.nextInt();
        System.out.print("Day: ");
        int currentDay = scanner.nextInt();

        int totalDays = 365 * (currentYear - birthYear) + 30 * (currentMonth - birthMonth) + (currentDay - birthDay);
        int totalHoursSlept = totalDays * 8;

        System.out.println("You have been alive for " + totalDays + " days.");
        System.out.println("You have slept " + totalHoursSlept + " hours.");

        scanner.close();
    }
}