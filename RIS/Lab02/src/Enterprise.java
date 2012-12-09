
import java.util.UUID;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Enterprise {

  private UUID uuid;
  private String title;
  private Integer year;

  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public UUID getUuid() {
    return uuid;
  }

  public void setUuid(UUID uuid) {
    this.uuid = uuid;
  }

  public Integer getYear() {
    return year;
  }

  public void setYear(Integer year) {
    this.year = year;
  }

  public Enterprise() {
  }

  public Enterprise(UUID uuid, String title, Integer year) {
    this.uuid = uuid;
    this.title = title;
    this.year = year;
  }

  private static String getTagValue(String sTag, Element eElement) {
    NodeList nlList = eElement.getElementsByTagName(sTag).item(0).getChildNodes();
    Node nValue = (Node) nlList.item(0);
    return nValue.getNodeValue();
  }

  public static Enterprise FromXML(Element element) {
    UUID id = UUID.fromString(getTagValue("uuid", element));
    String title = getTagValue("title", element);
    Integer year = Integer.parseInt(getTagValue("year", element));

    return new Enterprise(id, title, year);
  }

  public void ToXML(Document doc, Element rootElement) {
    Element creditElement = doc.createElement("enterprise");
    rootElement.appendChild(creditElement);

    Element monthsCountElement = doc.createElement("uuid");
    monthsCountElement.appendChild(doc.createTextNode(uuid.toString()));
    creditElement.appendChild(monthsCountElement);

    Element creditSumElement = doc.createElement("title");
    creditSumElement.appendChild(doc.createTextNode(title.toString()));
    creditElement.appendChild(creditSumElement);

    Element percentsElement = doc.createElement("year");
    percentsElement.appendChild(doc.createTextNode(year.toString()));
    creditElement.appendChild(percentsElement);
  }

  @Override
  public boolean equals(Object obj) {
    if (obj == null) {
      return false;
    }
    if (getClass() != obj.getClass()) {
      return false;
    }
    final Enterprise other = (Enterprise) obj;
    if (this.uuid != other.uuid && (this.uuid == null || !this.uuid.equals(other.uuid))) {
      return false;
    }
    return true;
  }

  @Override
  public int hashCode() {
    int hash = 7;
    hash = 83 * hash + (this.uuid != null ? this.uuid.hashCode() : 0);
    hash = 83 * hash + (this.title != null ? this.title.hashCode() : 0);
    hash = 83 * hash + (this.year != null ? this.year.hashCode() : 0);
    return hash;
  }

  public String fromString() {
    return "Enterprise{" + "uuid=" + uuid + ", title=" + title + ", year=" + year + '}';
  }

  @Override
  public String toString() {
    return "Enterprise{" + "uuid=" + uuid + ", title=" + title + ", year=" + year + '}';
  }
}
