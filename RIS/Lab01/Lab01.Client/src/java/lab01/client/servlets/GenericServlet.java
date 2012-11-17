package lab01.client.servlets;

import java.io.IOException;
import java.util.Map;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import lab01.client.actions.Action;
import lab01.client.actions.ActionFactory;

public abstract class GenericServlet extends HttpServlet {

  protected ActionFactory factory = new ActionFactory();

  protected abstract Map actions();

  protected String getActionName(HttpServletRequest request) {
    //String path = request.getServletPath();
    String path = request.getPathInfo();
    if (path == null) {
      return "index";
    } else {
      return path.substring(1);
    }
  }

  @Override
  public void service(HttpServletRequest request, HttpServletResponse response)
          throws ServletException, IOException {
    Action action = factory.create(actions(), getActionName(request));
    String url = action.perform(request, response);
    if (url != null) {
      getServletContext().getRequestDispatcher(url).forward(request, response);
    }
  }
}
