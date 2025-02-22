package Exercise4;

public class House {
    private static void addRoof() {
        System.out.println("   /\\");
        System.out.println("  /  \\");
        System.out.println(" /    \\");
        System.out.println("/______\\");
    }

    private static void addBase() {
        System.out.println("|      |");
        System.out.println("|      |");
        System.out.println("|______|");
    }

    private static void addPath() {
        System.out.println("   **");
        System.out.println("   *****************");
    }


    public static void main (String[] args) {
        addRoof();
        addBase();
        addPath();
    }
}
