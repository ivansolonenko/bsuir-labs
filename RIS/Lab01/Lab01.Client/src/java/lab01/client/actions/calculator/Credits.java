package lab01.client.actions.calculator;

import java.util.List;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import lab01.client.actions.Action;
import lab01.models.xsd.Credit;
import lab01.services.CreditCalculator;
import lab01.services.CreditCalculatorPortType;

public class Credits implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    CreditCalculator service = new CreditCalculator();
    CreditCalculatorPortType port = service.getCreditCalculatorSOAP12PortHttp();
    List<Credit> credits = port.getCredits().getReturn();
    request.setAttribute("credits", credits);
    return "/calculator.jsp";
  }
}
