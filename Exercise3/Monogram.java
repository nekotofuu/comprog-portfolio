package Exercise3;

import java.util.Scanner;

public class Monogram {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter your first name: ");
        String firstName = input.nextLine();

        System.out.print("Enter your middle initial: ");
        String middleInitial = input.nextLine();

        System.out.print("Enter your last name: ");
        String lastName = input.nextLine();


        String monogram = firstName.toLowerCase().charAt(0) + lastName.toUpperCase().charAt(0) + middleInitial.toLowerCase();


        System.out.println("Your monogram is: " + monogram);
        input.close();
    }
}
