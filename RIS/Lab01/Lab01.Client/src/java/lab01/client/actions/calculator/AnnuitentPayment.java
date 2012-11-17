package lab01.client.actions.calculator;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import lab01.client.actions.Action;
import lab01.services.CreditCalculator;
import lab01.services.CreditCalculatorPortType;

public class AnnuitentPayment implements Action {

  @Override
  public String perform(HttpServletRequest request, HttpServletResponse response) {
    Integer monthsCount;
    Double creditSum;
    Double percents;

    try {
      monthsCount = Integer.parseInt(request.getParameter("monthsCount"));
    } catch (NumberFormatException ex) {
      monthsCount = 0;
    }
    try {
      creditSum = Double.parseDouble(request.getParameter("creditSum"));
    } catch (NumberFormatException ex) {
      creditSum = 0.0;
    }
    try {
      percents = Double.parseDouble(request.getParameter("percents"));
    } catch (NumberFormatException ex) {
      percents = 0.0;
    }

    CreditCalculator service = new lab01.services.CreditCalculator();
    CreditCalculatorPortType port = service.getCreditCalculatorSOAP12PortHttp();
    Double payment = port.getAnnuitentPayment(monthsCount, creditSum, percents);

    request.setAttribute("monthsCount", monthsCount);
    request.setAttribute("creditSum", creditSum);
    request.setAttribute("percents", percents);
    request.setAttribute("payment", payment);

    return "/calculator.jsp";
  }
}
