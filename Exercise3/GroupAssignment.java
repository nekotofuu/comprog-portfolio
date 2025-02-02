package Exercise3;

import java.util.Scanner;

public class GroupAssignment {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter your first name: ");
        String firstName = input.nextLine();

        System.out.print("Enter your last name: ");
        String lastName = input.nextLine();

        char firstLetter = lastName.toUpperCase().charAt(0);
        int groupNumber;

        if (firstLetter >= 'A' && firstLetter <= 'I') {
            groupNumber = 1;
        } else if (firstLetter >= 'J' && firstLetter <= 'S') {
            groupNumber = 2;
        } else {
            groupNumber = 3;
        }

        System.out.println(firstName + " " + lastName + " is assigned to Group " + groupNumber);
        input.close();
    }
}
