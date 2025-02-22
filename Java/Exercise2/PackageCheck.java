package Exercise2;

import java.util.Scanner;

public class PackageCheck {
    static Scanner s = new Scanner(System.in);

    public static void main(String[] args) {
        double length, width, height, weight;

        System.out.print("Enter the weight in kilograms: ");
        weight = s.nextDouble();
        System.out.print("Enter the length in centimeters: ");
        length = s.nextDouble();
        System.out.print("Enter the width in centimeters: ");
        width = s.nextDouble();
        System.out.print("Enter the length in centimeters: ");
        height = s.nextDouble();

        if (length * width * height > 100000 && weight > 27) System.out.println("Too heavy and too large");
        else {
            if (length * width * height > 100000) System.out.println("Too large");
            else if (weight > 27) System.out.println("Too heavy");
            else System.out.println("Package accepted");
        }

    }
}
