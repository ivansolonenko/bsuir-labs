
import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.UUID;
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

public class Enterprises {

  //<editor-fold defaultstate="collapsed" desc="Singleton">
  private static Enterprises instance;

  public static Enterprises GetInstance() {
    return (instance == null) ? (instance = new Enterprises()) : instance;
  }
  //</editor-fold>
  private ArrayList<Enterprise> enterprises;

  public void Add(HashMap<String, String> map) {
    Enterprise enterprise = new Enterprise();
    enterprise.setUuid(UUID.fromString(map.get("uuid")));
    enterprise.setTitle(map.get("title"));
    enterprise.setYear(Integer.parseInt(map.get("year")));
    Add(enterprise);
  }

  public void Add(Enterprise enterprise) {
    if (enterprises == null) {
      enterprises = new ArrayList<Enterprise>();
    }
    enterprises.add(enterprise);
  }

  public void Delete(Enterprise enterprise) {
    enterprises.remove(enterprise);
  }

  public ArrayList<Enterprise> FindByTitle(String value) {
    ArrayList<Enterprise> findResults = new ArrayList<Enterprise>();
    if (enterprises != null && value != null) {
      for (Enterprise enterprise : enterprises) {
        if (value.equals(enterprise.getTitle())) {
          findResults.add(enterprise);
        }
      }
    }
    return findResults;
  }

  public ArrayList<Enterprise> FindByYear(Integer value) {
    ArrayList<Enterprise> findResults = new ArrayList<Enterprise>();
    if (enterprises != null && value != null) {
      for (Enterprise enterprise : enterprises) {
        if (value.equals(enterprise.getYear())) {
          findResults.add(enterprise);
        }
      }
    }
    return findResults;
  }

  public Enterprise Get(int index) {
    return enterprises != null ? enterprises.get(index) : null;
  }

  public ArrayList<Enterprise> GetAll() {
    return enterprises == null ? (enterprises = new ArrayList<Enterprise>()) : enterprises;
  }

  public void Load(String dbFilename) {
    try {
      DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
      DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
      Document doc = dBuilder.parse(dbFilename);
      doc.getDocumentElement().normalize();

      NodeList nodeList = doc.getElementsByTagName("enterprise");
      enterprises = new ArrayList<Enterprise>();

      for (int i = 0; i < nodeList.getLength(); i++) {
        Node node = nodeList.item(i);
        if (node.getNodeType() == Node.ELEMENT_NODE) {
          Element element = (Element) node;
          enterprises.add(Enterprise.FromXML(element));
        }
      }
    } catch (Exception ex) {
      System.out.println(ex.getMessage());
    }
  }

  public void Save(String dbFilename) {
    try {
      DocumentBuilderFactory docFactory = DocumentBuilderFactory.newInstance();
      DocumentBuilder docBuilder = docFactory.newDocumentBuilder();
      Document doc = docBuilder.newDocument();
      Save(dbFilename, doc);
    } catch (ParserConfigurationException ex) {
      System.out.println(ex.getMessage());
    }
  }

  public void Save(String dbFilename, Document doc) {
    try {
      Element rootElement = doc.createElement("enterprises");
      doc.appendChild(rootElement);

      for (Enterprise enterprise : enterprises) {
        enterprise.ToXML(doc, rootElement);
      }

      TransformerFactory transformerFactory = TransformerFactory.newInstance();
      Transformer transformer = transformerFactory.newTransformer();
      DOMSource source = new DOMSource(doc);
      StreamResult result = new StreamResult(new File(dbFilename));

      transformer.transform(source, result);
    } catch (TransformerException ex) {
      System.out.println(ex.getMessage());
    }
  }
}
