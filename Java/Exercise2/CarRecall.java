package Exercise2;

import java.util.Scanner;

public class CarRecall {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int modelNumber;

        int[] defectiveModels = {119, 179, 189, 190, 191, 192, 193, 194, 195, 221, 780};

        System.out.print("Enter the car's model number: ");
        modelNumber = input.nextInt();

        boolean isDefective = false;
        for (int model : defectiveModels) {
            if (modelNumber == model) {
                isDefective = true;
                break;
            }
        }

        if (isDefective) {
            System.out.println("Your car is defective. It must be repaired.");
        } else {
            System.out.println("Your car is not defective.");
        }
        input.close();
    }
}
