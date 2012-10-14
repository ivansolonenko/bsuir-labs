package kot01.actions;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import kot01.Action;
import kot01.LibraryService;
import kot01.LibraryServicePortType;

public class FindBookByAuthor implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    String author;

    try {
      author = request.getParameter("author");
    } catch (Exception ex) {
      author = null;
    }

    if (author != null && !author.isEmpty()) {
      LibraryService service = new LibraryService();
      LibraryServicePortType port = service.getLibraryServiceSOAP12PortHttp();
      request.setAttribute("books", port.findBooksByAuthor(author));
    }

    return "/library.jsp";
  }
}
