package kot01;

import java.io.File;
import java.util.ArrayList;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Books {

  //<editor-fold defaultstate="collapsed" desc="Singleton">
  private static Books instance;

  public static Books GetInstance() {
    return (instance == null) ? (instance = new Books()) : instance;
  }
  //</editor-fold>
  private final String dbFilename = "C:\\Users\\Public\\Documents\\bookStorage.xml";
  private ArrayList<Book> books;

  public void Add(Book book) {
    if (books == null) {
      books = new ArrayList<Book>();
    }
    books.add(book);
  }

  public void Delete(Book book) {
    books.remove(book);
  }

  public ArrayList<Book> Find(String key, String value) {
    if (books == null) {
      return (books = new ArrayList<Book>());
    }
    if (key == null || value == null) {
      return new ArrayList<Book>();
    }

    ArrayList<Book> result = new ArrayList<Book>();

    for (Book book : books) {
      if (key.equals("author") && value.equals(book.getAuthor())) {
        result.add(book);
      }
    }
    return result;
  }

  public Book Get(int index) {
    return books != null ? books.get(index) : null;
  }

  public ArrayList<Book> GetAll() {
    return books == null ? (books = new ArrayList<Book>()) : books;
  }

  public void Load() {
    try {
      File fXmlFile = new File(dbFilename);
      DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
      DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
      Document doc = dBuilder.parse(fXmlFile);
      doc.getDocumentElement().normalize();

      NodeList nodeList = doc.getElementsByTagName("book");
      books = new ArrayList<Book>();

      for (int temp = 0; temp < nodeList.getLength(); temp++) {
        Node node = nodeList.item(temp);
        if (node.getNodeType() == Node.ELEMENT_NODE) {
          Element element = (Element) node;
          books.add(Book.FromXML(element));
        }
      }
    } catch (Exception ex) {
      System.out.println(ex.getMessage());
    }
  }

  public void Save() {
    try {
      DocumentBuilderFactory docFactory = DocumentBuilderFactory.newInstance();
      DocumentBuilder docBuilder = docFactory.newDocumentBuilder();

      Document doc = docBuilder.newDocument();
      Element rootElement = doc.createElement("books");
      doc.appendChild(rootElement);

      for (Book book : books) {
        book.ToXML(doc, rootElement);
      }

      TransformerFactory transformerFactory = TransformerFactory.newInstance();
      Transformer transformer = transformerFactory.newTransformer();
      DOMSource source = new DOMSource(doc);
      StreamResult result = new StreamResult(new File(dbFilename));

      transformer.transform(source, result);

    } catch (ParserConfigurationException ex) {
      System.out.println(ex.getMessage());
    } catch (TransformerException ex) {
      System.out.println(ex.getMessage());
    }
  }
}
