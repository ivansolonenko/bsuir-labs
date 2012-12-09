
import javax.annotation.Resource;
import javax.jms.*;

public class SimpleMessageClient {

  @Resource(mappedName = "jms/ConnectionFactory")
  private static ConnectionFactory connectionFactory;
  @Resource(mappedName = "jms/Queue")
  private static Queue queue;

  public static void main(String[] args) {
    Connection connection = null;
    Session session = null;
    MessageProducer messageProducer = null;
    TextMessage message = null;
    final int NUM_MSGS = 3;

    try {
      connection = connectionFactory.createConnection();
      session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);
      messageProducer = session.createProducer(queue);

      message = session.createTextMessage();

      for (int i = 0; i < NUM_MSGS; i++) {
        message.setText("This is message " + (i + 1));
        System.out.println("Sending message: " + message.getText());
        messageProducer.send(message);
      }

      System.out.println("To see if the bean received the messages, check ");
      System.out.println("<inst_dir>/domains/domain1/logs/server.log.");
    } catch (JMSException e) {
      System.out.println("Exception occurred: " + e.toString());
    } finally {
      if (connection != null) {
        try {
          connection.close();
        } catch (JMSException e) {
        }
      } // if
      System.exit(0);
    } // finally
  } // main
} // class
