package lab01.models;

import java.io.Serializable;
import lombok.Getter;
import lombok.Setter;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Credit implements Serializable {

  @Getter
  @Setter
  private Integer monthsCount;
  //
  @Getter
  @Setter
  private Double creditSum;
  //
  @Getter
  @Setter
  private Double percents;

  public Credit() {
  }

  public Credit(Integer monthsCount, Double creditSum, Double percents) {
    this.monthsCount = monthsCount;
    this.creditSum = creditSum;
    this.percents = percents;
  }

  public double annuitentPayment() {
    return creditSum * (percents / 12 + (percents / 12) / (Math.pow((1 + percents / 12), monthsCount) - 1));
  }

  private static String getTagValue(String sTag, Element eElement) {
    NodeList nlList = eElement.getElementsByTagName(sTag).item(0).getChildNodes();
    Node nValue = (Node) nlList.item(0);
    return nValue.getNodeValue();
  }

  public static Credit FromXML(Element element) {
    Integer monthsCount = Integer.parseInt(getTagValue("monthsCount", element));
    Double creditSum = Double.parseDouble(getTagValue("creditSum", element));
    Double percents = Double.parseDouble(getTagValue("percents", element));

    return new Credit(monthsCount, creditSum, percents);
  }

  public void ToXML(Document doc, Element rootElement) {
    Element creditElement = doc.createElement("credit");
    rootElement.appendChild(creditElement);

    Element monthsCountElement = doc.createElement("monthsCount");
    monthsCountElement.appendChild(doc.createTextNode(monthsCount.toString()));
    creditElement.appendChild(monthsCountElement);

    Element creditSumElement = doc.createElement("creditSum");
    creditSumElement.appendChild(doc.createTextNode(creditSum.toString()));
    creditElement.appendChild(creditSumElement);

    Element percentsElement = doc.createElement("percents");
    percentsElement.appendChild(doc.createTextNode(percents.toString()));
    creditElement.appendChild(percentsElement);
  }
}
