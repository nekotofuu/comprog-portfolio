package Exercise3;

public class Investment {
    public static void main(String[] args) {
        final double investment = 2500;
        final double rate = 0.075;
        final double goal = 5000;

        System.out.printf("The time it'll take to grow $%.2f to $%.2f with a %.2f%% interest rate is %.2f years", investment, goal, rate, (Math.log(goal) - Math.log(investment)) / Math.log(1 + rate));
    }
}
