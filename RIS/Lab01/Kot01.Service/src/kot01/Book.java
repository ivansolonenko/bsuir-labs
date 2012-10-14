package kot01;

import java.io.Serializable;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Book implements Serializable {

  private String author;
  private String title;
  private Integer year;
  private Integer pages;

  public String getAuthor() {
    return author;
  }

  public void setAuthor(String author) {
    this.author = author;
  }

  public Integer getPages() {
    return pages;
  }

  public void setPages(Integer pages) {
    this.pages = pages;
  }

  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public Integer getYear() {
    return year;
  }

  public void setYear(Integer year) {
    this.year = year;
  }

  public Book() {
  }

  public Book(String author, String title, Integer year, Integer pages) {
    this.author = author;
    this.title = title;
    this.year = year;
    this.pages = pages;
  }

  private static String getTagValue(String sTag, Element eElement) {
    NodeList nlList = eElement.getElementsByTagName(sTag).item(0).getChildNodes();
    Node nValue = (Node) nlList.item(0);
    return nValue.getNodeValue();
  }

  public static Book FromXML(Element element) {
    String author = getTagValue("author", element);
    String title = getTagValue("title", element);
    Integer year = Integer.parseInt(getTagValue("year", element));
    Integer pages = Integer.parseInt(getTagValue("pages", element));

    return new Book(author, title, year, pages);
  }

  public void ToXML(Document document, Element rootElement) {
    Element bookElement = document.createElement("book");
    rootElement.appendChild(bookElement);

    Element authorElement = document.createElement("author");
    authorElement.appendChild(document.createTextNode(this.author));
    bookElement.appendChild(authorElement);

    Element titleElement = document.createElement("title");
    titleElement.appendChild(document.createTextNode(this.title));
    bookElement.appendChild(titleElement);

    Element yearElement = document.createElement("year");
    yearElement.appendChild(document.createTextNode(year.toString()));
    bookElement.appendChild(yearElement);

    Element pagesElement = document.createElement("pages");
    pagesElement.appendChild(document.createTextNode(pages.toString()));
    bookElement.appendChild(pagesElement);
  }
}
