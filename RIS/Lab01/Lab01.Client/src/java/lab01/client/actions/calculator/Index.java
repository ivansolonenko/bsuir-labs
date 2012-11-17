package lab01.client.actions.calculator;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import lab01.client.actions.Action;

public class Index implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    return "/calculator.jsp";
  }
}
