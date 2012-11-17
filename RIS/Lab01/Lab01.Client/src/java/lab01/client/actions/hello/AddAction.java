package lab01.client.actions.hello;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import lab01.client.actions.Action;
import lab01.services.Hello;
import lab01.services.HelloPortType;

public class AddAction implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    Integer x, y;
    try {
      x = Integer.parseInt(request.getParameter("x"));
    } catch (NumberFormatException ex) {
      x = 0;
    }
    try {
      y = Integer.parseInt(request.getParameter("y"));
    } catch (NumberFormatException ex) {
      y = 0;
    }

    Hello service = new Hello();
    HelloPortType port = service.getHelloSOAP12PortHttp();
    Integer z = port.add(x, y);

    request.setAttribute("x", x);
    request.setAttribute("y", y);
    request.setAttribute("z", z);

    return "/hello.jsp";
  }
}
