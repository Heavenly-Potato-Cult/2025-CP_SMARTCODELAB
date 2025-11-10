import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String word = sc.nextLine();
        String lastWord = "";
        char[] stringChar = word.toCharArray();
        for(int i = word.length() - 1; i >= 0; i--){
            if(stringChar[i] == ' ')
                break;
            lastWord = stringChar[i] + lastWord;
        }
        System.out.println(lastWord.length());
    }
}