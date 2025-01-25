package Exercise2;

import java.util.Scanner;

public class Volumes {
    static Scanner s = new Scanner(System.in);

    private static void prism (){
        double l, w, h;
        System.out.print("Rectangular Prism\n");
        System.out.print("\tEnter the length: ");
        l = s.nextDouble();
        System.out.print("\tEnter the width: ");
        w = s.nextDouble();
        System.out.print("\tEnter the height: ");
        h = s.nextDouble();

        System.out.printf("\nThe volume is %.2f", l * w * h);
    }

    private static void sphere (){
        double r;
        System.out.print("Sphere\n");
        System.out.print("\tEnter the radius: ");
        r = s.nextDouble();

        System.out.printf("\nThe volume is %.2f", Math.PI / 6 * Math.pow(2 * r, 3));
    }

    private static void cube (){
        double side;
        System.out.print("Cube\n");
        System.out.print("\tEnter the length of each side: ");
        side = s.nextDouble();

        System.out.printf("\nThe volume is %.2f", Math.pow(side, 3));
    }

    public static void main(String[] args) {
        prism();
        sphere();
        cube();
    }
}
