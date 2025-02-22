package Exercise;

import java.util.Scanner;
public class ObjectHeight {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.print("Enter a Time less than 4.5 seconds: ");

        double time = s.nextDouble();

        if (time > 4.5) {
            System.out.println("Invalid Time. Time must be less than 4.5 seconds. ");
            return;

        }

        double height = 100 - 4.9 * time * time;
        System.out.printf("The Height of the object is: %.1f Meters" , height);


        s.close();

    }
}
