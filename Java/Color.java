// public class Color {
//     public static void main(String[] args) {
//         System.out.println("\033[31mThis text is red \033[0m");
//         System.out.println("\033[32mThis text is green\033[0m");
//         System.out.println("\033[33mThis text is yellow\033[0m");
//         System.out.println("\033[34mThis text is blue\033[0m");
//         System.out.println("\033[35mThis text is purple\033[0m");
//         System.out.println("\u001B[36mThis text is cyan\u001B[0m");
//     }
// }
public class Color {
    
    public static final String ANSI_RESET = "\u001B[0m";
    public static final String ANSI_RED = "\u001B[31m";
    public static final String ANSI_GREEN = "\u001B[32m";
    public static final String ANSI_YELLOW = "\u001B[33m";
    public static final String ANSI_BLUE = "\u001B[34m";
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_CYAN = "\u001B[36m";

public static void main(String[] args){
    System.out.println(ANSI_RED + "This text is red."+ANSI_RESET);
    System.out.println(ANSI_GREEN + "This text is green."+ANSI_RESET);
    System.out.println(ANSI_YELLOW + "This text is yellow."+ANSI_RESET);
    System.out.println(ANSI_BLUE + "This text is blue."+ANSI_RESET);
    System.out.println(ANSI_PURPLE + "This text is purple."+ANSI_RESET);
    System.out.println(ANSI_CYAN + "This text is cyan."+ANSI_RESET);
}
}