package lab01.models;

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

public class DbManager {

  //<editor-fold defaultstate="collapsed" desc="Singleton">
  private static DbManager instance;

  public static DbManager GetInstance() {
    return (instance == null) ? (instance = new DbManager()) : instance;
  }
  //</editor-fold>
  private final String dbFilename = "C:\\Users\\cruazer\\storage.xml";
  private ArrayList<Credit> credits;

  public void Add(Credit credit) {
    if (credits == null) {
      credits = new ArrayList<Credit>();
    }
    credits.add(credit);
  }

  public Credit Get(int index) {
    return credits != null ? credits.get(index) : null;
  }

  public ArrayList<Credit> GetAll() {
    return credits == null ? (credits = new ArrayList<Credit>()) : credits;
  }

  public void Load() {
    try {

      File fXmlFile = new File(dbFilename);
      DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
      DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
      Document doc = dBuilder.parse(fXmlFile);
      doc.getDocumentElement().normalize();

      NodeList nList = doc.getElementsByTagName("credit");

      credits = new ArrayList<Credit>();

      for (int temp = 0; temp < nList.getLength(); temp++) {

        Node nNode = nList.item(temp);
        if (nNode.getNodeType() == Node.ELEMENT_NODE) {
          Element eElement = (Element) nNode;
          credits.add(Credit.FromXML(eElement));
        }
      }
    } catch (Exception e) {
      e.printStackTrace();
    }
  }

  public void Save() {
    try {
      DocumentBuilderFactory docFactory = DocumentBuilderFactory.newInstance();
      DocumentBuilder docBuilder = docFactory.newDocumentBuilder();

      Document doc = docBuilder.newDocument();
      Element rootElement = doc.createElement("credits");
      doc.appendChild(rootElement);

      for (Credit credit : credits) {
        credit.ToXML(doc, rootElement);
      }

      TransformerFactory transformerFactory = TransformerFactory.newInstance();
      Transformer transformer = transformerFactory.newTransformer();
      DOMSource source = new DOMSource(doc);
      StreamResult result = new StreamResult(new File(dbFilename));

      transformer.transform(source, result);

    } catch (ParserConfigurationException pce) {
      pce.printStackTrace();
    } catch (TransformerException tfe) {
      tfe.printStackTrace();
    }
  }

  private static String getTagValue(String sTag, Element eElement) {
    NodeList nlList = eElement.getElementsByTagName(sTag).item(0).getChildNodes();
    Node nValue = (Node) nlList.item(0);
    return nValue.getNodeValue();
  }
}
