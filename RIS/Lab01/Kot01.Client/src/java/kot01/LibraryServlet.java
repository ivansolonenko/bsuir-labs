package kot01;

import java.util.HashMap;
import kot01.actions.*;

public class LibraryServlet extends GenericServlet {

  @Override
  protected HashMap actions() {
    HashMap<String, Class<?>> map = new HashMap<String, Class<?>>();
    map.put("Index".toUpperCase(), Index.class);
    map.put("AddBook".toUpperCase(), AddBook.class);
    map.put("DeleteBook".toUpperCase(), DeleteBook.class);
    map.put("FindBooksByAuthor".toUpperCase(), FindBooksByAuthor.class);
    map.put("GetBooks".toUpperCase(), GetBooks.class);
    return map;
  }
}
