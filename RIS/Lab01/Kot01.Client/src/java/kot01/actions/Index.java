package kot01.actions;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import kot01.Action;

public class Index implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    return "/library.jsp";
  }
}
