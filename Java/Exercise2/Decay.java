package Exercise2;

import java.util.Scanner;

public class Decay {
    static Scanner s = new Scanner(System.in);

    private static double decayMass (
            double initMass,
            double halfLife,
            double time
    ) {
        return initMass * Math.exp(-halfLife * time);
    }

    private static double origMass (
            double finalMass,
            double halfLife,
            double time
    ) {
        return finalMass / Math.exp(-halfLife * time);
    }

    private static double halfLife (
            double initMass,
            double finalMass,
            double time
    ) {
        return Math.log(finalMass / initMass) / time;
    }

    public static void main(String[] args) {
        double initMass, finalMass, halfLife, time;

        System.out.println("Welcome to Decay Application");
        System.out.println("Please select a mode.");
        System.out.println("\t1. Final Amount");
        System.out.println("\t2. Initial Amount");
        System.out.println("\t3. Constant (half-life)\n");

        System.out.print("Mode: ");
        int mode = s.nextInt();

        switch (mode) {
            case 1:
                System.out.print("\nEnter initial mass: ");
                initMass = s.nextDouble();
                System.out.print("Enter constant (half-life): ");
                halfLife = s.nextDouble();
                System.out.print("Enter elapsed time in years: ");
                time = s.nextDouble();

                System.out.printf("Final Amount (mass): %.5f", decayMass(initMass, halfLife, time));
                break;
            case 2:
                System.out.print("\nEnter final mass: ");
                finalMass = s.nextDouble();
                System.out.print("Enter constant (half-life): ");
                halfLife = s.nextDouble();
                System.out.print("Enter elapsed time in years: ");
                time = s.nextDouble();

                System.out.printf("Initial Amount (mass): %.5f", origMass(finalMass, halfLife, time));
                break;
            case 3:
                System.out.print("\nEnter initial mass: ");
                initMass = s.nextDouble();
                System.out.print("\nEnter final mass: ");
                finalMass = s.nextDouble();
                System.out.print("Enter elapsed time in years: ");
                time = s.nextDouble();

                System.out.printf("Constant (half-life): %.5f", halfLife(initMass, finalMass, time));
                break;
            default:
                break;
        }
    }
}
