
import javax.annotation.Resource;
import javax.jms.*;

public class SimpleMessageReceiver {

  @Resource(mappedName = "jms/ConnectionFactory")
  private static ConnectionFactory connectionFactory;
  @Resource(mappedName = "jms/Queue")
  private static Queue queue;
  private static final long TIMEOUT = 15;

  public static void main(String[] args) {
    try {
      Connection connection = connectionFactory.createConnection();
      Session session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);
      MessageConsumer consumer = session.createConsumer(queue);

      connection.start();

      while (true) {
        //System.out.println(String.format("Waiting for %d seconds...", TIMEOUT));
        Message message = consumer.receive(TIMEOUT * 1000);
        if (message == null) {
          break;
        } else if (message instanceof TextMessage) {
          TextMessage textMessage = (TextMessage) message;
          System.out.println(String.format("Message received: %s", textMessage.getText()));
        } else {
          System.out.println(String.format("Incorrect message format"));
        }
      }

      System.out.println("Connection closed");
      session.close();
      connection.close();
    } catch (JMSException e) {
      System.out.println("Exception occurred: " + e.toString());
    } finally {
      System.exit(0);
    }
  }
}
