package lab01.client.actions.hello;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import lab01.client.actions.Action;

public class Index implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    return "/hello.jsp";
  }
}
