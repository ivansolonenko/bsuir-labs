package kot01.actions;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import kot01.Action;
import kot01.LibraryService;
import kot01.LibraryServicePortType;
import kot01.xsd.Book;
import kot01.xsd.ObjectFactory;

public class AddBook implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    String author;
    String title;
    Integer year;
    Integer pages;

    try {
      author = request.getParameter("author");
    } catch (Exception ex) {
      author = null;
    }
    try {
      title = request.getParameter("title");
    } catch (Exception ex) {
      title = null;
    }
    try {
      year = Integer.parseInt(request.getParameter("year"));
    } catch (Exception ex) {
      year = null;
    }
    try {
      pages = Integer.parseInt(request.getParameter("pages"));
    } catch (Exception ex) {
      pages = null;
    }

    if (author != null && title != null && year != null && pages != null
            && !author.isEmpty() && !title.isEmpty()) {
      ObjectFactory of = new ObjectFactory();
      Book book = new Book();
      book.setAuthor(of.createBookAuthor(author));
      book.setTitle(of.createBookTitle(title));
      book.setYear(of.createBookYear(year));
      book.setPages(of.createBookPages(pages));

      LibraryService service = new LibraryService();
      LibraryServicePortType port = service.getLibraryServiceSOAP12PortHttp();
      port.addBook(book);
    }
    return "/library.jsp";
  }
}
