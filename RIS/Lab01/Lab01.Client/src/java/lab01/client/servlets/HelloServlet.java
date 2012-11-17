package lab01.client.servlets;

import java.util.HashMap;
import java.util.Map;
import lab01.client.actions.hello.AddAction;
import lab01.client.actions.hello.HelloAction;
import lab01.client.actions.hello.Index;

public class HelloServlet extends GenericServlet {

  @Override
  protected Map actions() {
    HashMap map = new HashMap();
    map.put("Index".toUpperCase(), Index.class);
    map.put("Hello".toUpperCase(), HelloAction.class);
    map.put("Add".toUpperCase(), AddAction.class);
    return map;
  }
}
