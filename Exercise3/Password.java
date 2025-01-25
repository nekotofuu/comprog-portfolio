package Exercise3;

import java.util.Scanner;

public class Password {
    private static Scanner s = new Scanner(System.in);


    public static void main(String[] args) {
        String password = "nigger";
        String input;
        int accessAttempt = 1;
        boolean allowAccess = false;

        do {
            System.out.print("Enter your password: ");
            input = s.nextLine();

            if (password.equals(input)) {
                allowAccess = true;
                break;
            }

            System.out.print("The password you typed is incorrect.\n");
            accessAttempt++;
        } while (accessAttempt <= 3);

        if (allowAccess) System.out.println("Welcome");
        else System.out.println("Access denied");
    }
}
