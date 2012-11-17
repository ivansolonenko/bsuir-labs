package lab01.client.servlets;

import java.util.HashMap;
import java.util.Map;
import lab01.client.actions.calculator.AnnuitentPayment;
import lab01.client.actions.calculator.Credits;
import lab01.client.actions.calculator.Index;

public class CalculatorServlet extends GenericServlet {

  @Override
  protected Map actions() {
    HashMap map = new HashMap();
    map.put("Index".toUpperCase(), Index.class);
    map.put("AnnuitentPayment".toUpperCase(), AnnuitentPayment.class);
    map.put("Credits".toUpperCase(), Credits.class);
    return map;
  }
}
