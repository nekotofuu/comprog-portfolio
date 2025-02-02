package Exercise;

import java.util.Scanner;

public class Election {
    public static void main (String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.println("Enter the election results for Awbrey in:");
        System.out.print("New York: ");
        int awbreyNY = s.nextInt();
        System.out.print("New Jersey: ");
        int awbreyNJ = s.nextInt();
        System.out.print("Conneticut: ");
        int awbreyCO = s.nextInt();

        System.out.println("\nEnter the election results for Mertinez in:");
        System.out.print("New York: ");
        int martinezNY = s.nextInt();
        System.out.print("New Jersey: ");
        int martinezNJ = s.nextInt();
        System.out.print("Conneticut: ");
        int martinezCO = s.nextInt();

        int awbreyTotal = awbreyNJ + awbreyNY + awbreyCO;
        int martinezTotal = martinezNJ + martinezNY + martinezCO;
        int totalVotes = awbreyTotal + martinezTotal;

        double awbreyPercent = (awbreyTotal / (double)totalVotes) * 100;
        double martinezPercent = (martinezTotal / (double)totalVotes) * 100;

        System.out.format("%12s %10s %10s", "Candidates", "Votes", "Percentage");
        System.out.format("%12s %10.2f %9.2f%%", "Awbrey", awbreyTotal, awbreyPercent);
        System.out.format("%12s %10.2f %9.2f%%", "Martinez", martinezTotal, martinezPercent);

    }
}
