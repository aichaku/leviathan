import java.util.ArrayList;
import java.util.HashMap;

public class Digraph {

    private HashMap<Integer, ArrayList<Integer>> adj;

    public Digraph() {
        adj = new HashMap<>();
    }

    public static void main(String[] args) {


        Digraph g = new Digraph();

        g.addEdge(1, 2);
        g.addEdge(1, 3);
        g.addEdge(1, 4);
        g.addEdge(1, 5);

        System.out.println(g.toString());
        System.out.println(g.isConnected(1, 2));
        System.out.println(g.isConnected(6, 1));
    }

    public void addEdge(int v1, int v2) {

        if (adj.containsKey((v1))) {
            if (adj.get(v1).contains(v2)) return;
            adj.get(v1).add(v2);
        } else {
            adj.put(v1, new ArrayList<>());
            adj.get(v1).add(v2);
        }
    }

    public boolean isConnected(int v1, int v2) {
        if (adj.containsKey(v1)) {
            return adj.get(v1).contains(v2);
        }
        return isConnected(v2, v1);
    }

    public String toString() {
        return adj.toString();
    }
}
