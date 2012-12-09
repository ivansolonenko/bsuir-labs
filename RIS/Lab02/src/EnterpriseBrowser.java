
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.UUID;
import org.w3c.dom.Element;

public class EnterpriseBrowser {

  private static final BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
  private static final String endpoint = "http://localhost:8080/axis/services/EnterpriseService";
  private static final String storage = "C:\\Users\\Public\\Documents\\enterpriseStorage.xml";
  private static final String separator = "-------------------------------------------------------------------------------";

  private static void display(ArrayList<Element> elements) {
    if (elements.size() > 0) {
      System.out.println(
              String.format(" %-37s| %-9s| %-5s", "Id", "Title", "Year"));
      System.out.println("--------------------------------------------------------");
      for (Element element : elements) {
        Enterprise enterprise = Enterprise.FromXML(element);
        System.out.println(
                String.format(" %-37s| %-9s| %-5d",
                enterprise.getUuid().toString(), enterprise.getTitle(), enterprise.getYear()));
      }
    } else {
      System.out.println("No results");
    }
  }

  private static int menu(BufferedReader br) {
    System.out.println("1 - Get all");
    System.out.println("2 - Add new");
    System.out.println("3 - Find by title");
    System.out.println("0 - Exit");
    System.out.print("$ ");
    try {
      return Integer.parseInt(br.readLine());
    } catch (IOException ex) {
      return -1;
    } catch (NumberFormatException ex) {
      return -1;
    }
  }

  public static void main(String[] args) {
    proxy();

    try {
      HashMap<String, String> params = new HashMap<String, String>();

      int c;
      while ((c = menu(br)) != 0) {
        System.out.println(separator);

        params.clear();
        params.put("filename", storage);

        switch (c) {
          case 1: {
            ArrayList<Element> elements = Soap.createRequest("get", params).getResponse(endpoint).parsePesponse();
            display(elements);
          }
          break;
          case 2: {
            Enterprise enterprise = new Enterprise();
            enterprise.setUuid(UUID.randomUUID());
            System.out.print("Title: ");
            enterprise.setTitle(br.readLine());
            System.out.print("Year: ");
            enterprise.setYear(Integer.parseInt(br.readLine()));

            params.put("uuid", enterprise.getUuid().toString());
            params.put("title", enterprise.getTitle());
            params.put("year", enterprise.getYear().toString());

            Soap.createRequest("add", params).getResponse(endpoint).parsePesponse();
          }
          break;
          case 3: {
            System.out.print("Title to search: ");
            params.put("title", br.readLine());

            ArrayList<Element> elements = Soap.createRequest("find", params).getResponse(endpoint).parsePesponse();
            display(elements);
          }
          break;
          default:
            System.out.println("Incorrect action");
            break;
        }

        System.out.println(separator);
      }
    } catch (Exception e) {
      System.out.println("Error: " + e.getMessage());
    }
  }

  private static void proxy() {
    System.setProperty("http.proxyHost", "127.0.0.1");
    System.setProperty("https.proxyHost", "127.0.0.1");
    System.setProperty("http.proxyPort", "8888");
    System.setProperty("https.proxyPort", "8888");
  }
}
