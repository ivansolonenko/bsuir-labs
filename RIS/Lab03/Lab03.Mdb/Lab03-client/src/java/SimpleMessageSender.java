
import javax.annotation.Resource;
import javax.jms.*;

public class SimpleMessageSender {

  @Resource(mappedName = "jms/ConnectionFactory")
  private static ConnectionFactory connectionFactory;
  @Resource(mappedName = "jms/Queue")
  private static Queue queue;
  private static final int NUMBER_OF_MESSAGES = 5;
  private static final long TIMEOUT = 20;

  public static void main(String[] args) {

    try {
      int i;
      Connection connection = connectionFactory.createConnection();
      Session session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);
      MessageProducer producer = session.createProducer(queue);
      TextMessage message = session.createTextMessage();

      for (i = 0; i < NUMBER_OF_MESSAGES; i++) {
        message.setText("This is message " + (i + 1));
        System.out.println("Sending message: " + message.getText());
        producer.send(message);
      }

      Thread.sleep(TIMEOUT * 1000);

      for (; i < NUMBER_OF_MESSAGES * 2; i++) {
        message.setText("This is message " + (i + 1));
        System.out.println("Sending message: " + message.getText());
        producer.send(message);
      }

      System.out.println("Connection closed");
      session.close();
      connection.close();
    } catch (InterruptedException e) {
      System.out.println("Exception occurred: " + e.toString());
    } catch (JMSException e) {
      System.out.println("Exception occurred: " + e.toString());
    } finally {
      System.exit(0);
    }
  }
}
