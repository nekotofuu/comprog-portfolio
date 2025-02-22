package Exercise3;

import java.util.Scanner;

public class CarRecall {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int modelNumber;

        int[] defectiveModels = {119, 179, 189, 190, 191, 192, 193, 194, 195, 221, 780};

        do {
            System.out.print("Enter the car's model number or 0 to quit: ");
            modelNumber = input.nextInt();

            if (modelNumber == 0) break;

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
        } while (true);

        input.close();
    }
}
