package Exercise4;

import java.util.Scanner;

public class MetricConversion {

    private static String convertFtToCm (double value) {
        return String.format("%f %s is equal to %f %s", value, "feet", 30 * value, "centimeters");
    }

    private static String convertCmToFt (double value) {
        return String.format("%f %s is equal to %f %s", value, "centimeters", value / 30, "feet");
    }

    private static String convertInToCm (double value) {
        return String.format("%f %s is equal to %f %s", value, "inches", value * 2.54, "centimeters");
    }

    private static String convertCmToIn (double value) {
        return String.format("%f %s is equal to %f %s", value, "centimeters", value / 2.54, "inches");
    }

    private static String convertYdToMeter (double value) {
        return String.format("%f %s is equal to %f %s", value, "yards", value * 0.91, "meters");
    }

    private static String convertMeterToYd (double value) {
        return String.format("%f %s is equal to %f %s", value, "meters", value / 0.91, "yards");
    }

    private static String convertMiToKm (double value) {
        return String.format("%f %s is equal to %f %s", value, "miles", value * 1.6, "kilometers");
    }

    private static String convertKmToMi (double value) {
        return String.format("%f %s is equal to %f %s", value, "kilometers", value / 1.6, "miles");
    }

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.print("Enter a number: ");
        double n = s.nextDouble();

        System.out.println("Convert:");
        System.out.format("%30s %30s\n", "1. Inches to Centimeters", "5. Centimeters to Inches");
        System.out.format("%30s %30s\n", "2. Feet to Centimeters", "6. Centimeters to Feet");
        System.out.format("%30s %30s\n", "3. Yards to Meters", "7. Meters to Yards");
        System.out.format("%30s %30s\n", "4. Miles to Kilometers", "8. Kilometers to Miles");

        System.out.print("Enter your choice: ");
        int choice = s.nextInt();

        switch (choice) {
            case 1:
                System.out.println(convertInToCm(n));
                break;
            case 2:
                System.out.println(convertFtToCm(n));
                break;
            case 3:
                System.out.println(convertYdToMeter(n));
                break;
            case 4:
                System.out.println(convertMiToKm(n));
                break;
            case 5:
                System.out.println(convertCmToIn(n));
                break;
            case 6:
                System.out.println(convertCmToFt(n));
                break;
            case 7:
                System.out.println(convertMeterToYd(n));
                break;
            case 8:
                System.out.println(convertKmToMi(n));
                break;
            default:
                System.out.println("Invalid conversion mode.");
                break;
        }

    }
}
