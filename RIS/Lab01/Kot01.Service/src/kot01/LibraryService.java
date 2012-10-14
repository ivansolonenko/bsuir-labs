package kot01;

import java.util.ArrayList;

public class LibraryService {

  public void AddBook(Book book) {
    Books db = Books.GetInstance();
    db.Load();
    db.Add(book);
    db.Save();
  }

  public void DeleteBook(Book book) {
    Books db = Books.GetInstance();
    db.Load();
    db.Delete(book);
    db.Save();
  }

  public Book[] FindBooksByAuthor(String author) {
    Books db = Books.GetInstance();
    db.Load();
    ArrayList<Book> books = db.Find("author", author);
    return books.toArray(new Book[books.size()]);
  }

  public Book[] GetBooks() {
    Books db = Books.GetInstance();
    db.Load();
    ArrayList<Book> books = db.GetAll();
    return books.toArray(new Book[books.size()]);
  }
}
