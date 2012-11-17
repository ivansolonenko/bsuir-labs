package lab01.client.actions.hello;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import lab01.client.actions.Action;
import lab01.services.Hello;
import lab01.services.HelloPortType;

public class HelloAction implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    Hello service = new Hello();
    HelloPortType port = service.getHelloSOAP12PortHttp();
    String helloWorld = port.hello().getReturn().getValue();
    request.setAttribute("helloWorld", helloWorld);
    return "/hello.jsp";
  }
}
