package Exercise2;

import java.util.*;

public class MathTutor {
    static Scanner s = new Scanner(System.in);
    static Random r = new Random();

    private enum Operation {
        ADDITION,
        SUBTRACTION,
        MULTIPLICATION,
        DIVISION
    }

    private static Operation operation () {
        switch (r.nextInt(1, 5)) {
            case 2:
                return Operation.SUBTRACTION;
            case 3:
                return Operation.MULTIPLICATION;
            case 4:
                return Operation.DIVISION;
            default:
                return Operation.ADDITION;
        }
    }

    public static void main(String[] args) {
        int[] operand = {r.nextInt(1, 11), r.nextInt(1, 11)};
        String operation = "+";
        int solution = 0;

        switch (operation()) {
            case ADDITION -> {
                operation = "+";
                solution = operand[0] + operand[1];
            }

            case SUBTRACTION -> {
                operation = "-";
                solution = operand[0] - operand[1];
            }

            case MULTIPLICATION -> {
                operation = "*";
                solution = operand[0] * operand[1];
            }

            case DIVISION -> {
                operation = "/";
                solution = operand[0] / operand[1];
            }
        }

        System.out.printf("What is %d %s %d? ",operand[0], operation, operand[1]);
        if (s.nextInt() == solution) System.out.println("Correct!");
        else System.out.println("Wrong!");
    }
}
