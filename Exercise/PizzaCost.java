package Exercise;

import java.util.Scanner;

public class PizzaCost {

    public static void main(String[] args) {
        Scanner i = new Scanner(System.in);

        System.out.print("Enter the diameter of the pizza in inches: ");
        double diameter = i.nextDouble();

        double laborCost = 0.75;
        double rentCost = 1.00;
        double materialsCost = 0.05 * diameter * diameter;

        double totalCost = laborCost + rentCost + materialsCost;

        System.out.printf("The cost of making the pizza is: $%.2f ", totalCost);

        i.close();
    }
}
