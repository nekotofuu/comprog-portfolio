package Exercise4;

import java.util.*;

public class PythagoreanTriple {

    private static class Triple {
        int a;
        int b;
        int c;

        public boolean compare (Triple t) {
            return a == t.a && b == t.b && c == t.c;
        }

        public String display () {
            return String.format("%d, %d, %d", a, b, c);
        }

        public Triple (int n1, int n2, int n3) {
            this.a = n1;
            this.b = n2;
            this.c = n3;
        }
    }

    private static int sqr (int n) { return (int)Math.pow(n, 2); }

    private static boolean isPerfectSquare (int n) {
        double root = Math.sqrt(n);
        return root % Math.floor(root) == 0;
    }

    public static void main(String[] args) {
         ArrayList<Triple> pythagoreanTriples = new ArrayList<>();
         HashMap<Integer, Integer> pairs = new HashMap<>();


         for (int i = 2; i <= 100; i++) {
             for (int j = 2; j <= 100; j++) {
                 if (
                         isPerfectSquare(sqr(i) + sqr(j)) &&
                         !pairs.containsValue(i) &&
                         !pairs.containsKey(j)
                 ) {
                     pythagoreanTriples.add(new Triple(i, j, (int)Math.sqrt(sqr(i) + sqr(j))));
                     pairs.put(i, j);
                 }
             }
         }

         for (Triple i : pythagoreanTriples) System.out.println(i.display());
    }
}
