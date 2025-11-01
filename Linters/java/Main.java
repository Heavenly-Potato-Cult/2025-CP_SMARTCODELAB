public class Main {
public String bar(String string) {
  // should be &&
    if (string!=null || !string.equals(""))
        return string;
  // should be ||
    if (string==null && string.equals(""))
        return string;
}
}