package Exercise2;

import java.util.Scanner;

public class Grade {
    static Scanner s = new Scanner(System.in);


    private static String grade (double percentage) {
        if (percentage >= 90) return "A";
        else if (percentage >= 80) return "B";
        else if (percentage >= 70) return "C";
        else if (percentage >= 60) return "D";
        else return "F";
    }
    public static void main(String[] args) {
        System.out.print("Enter the percentage: ");
        double d = s.nextDouble();

        System.out.printf("The corresponding letter grade is: %s", grade(d));
    }
}
