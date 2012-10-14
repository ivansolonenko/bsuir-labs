package kot01.actions;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import kot01.Action;
import kot01.LibraryService;
import kot01.LibraryServicePortType;

public class DeleteBook implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    return "/library.jsp";
  }
}
