
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.annotation.Resource;
import javax.ejb.MessageDriven;
import javax.ejb.MessageDrivenContext;
import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.MessageListener;
import javax.jms.TextMessage;

@MessageDriven(mappedName = "jms/Queue")
public class SimpleMessageBean implements MessageListener {

  static final Logger logger = Logger.getLogger("SimpleMessageBean");
  @Resource
  private MessageDrivenContext mdc;

  public SimpleMessageBean() {
  }

  @Override
  public void onMessage(Message inMessage) {
    TextMessage msg = null;

    try {
      if (inMessage instanceof TextMessage) {
        msg = (TextMessage) inMessage;
        logger.log(Level.INFO, "MESSAGE BEAN: Message received: {0}", msg.getText());
      } else {
        logger.log(Level.WARNING, "Message of wrong type: {0}", inMessage.getClass().getName());
      }
    } catch (JMSException e) {
      e.printStackTrace();
      mdc.setRollbackOnly();
    } catch (Throwable te) {
      te.printStackTrace();
    }
  }
}
