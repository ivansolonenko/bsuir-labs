import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.Iterator;
import javax.xml.soap.*;
import javax.xml.transform.TransformerException;

public class StoreMessage {

  static String fileXml;
  static SOAPMessage reqMess, respMess;

  public void createSOAPRequest()
          throws SOAPException, TransformerException {
    MessageFactory factory = MessageFactory.newInstance();
    reqMess = factory.createMessage();

    SOAPPart soapPart = reqMess.getSOAPPart();
    SOAPEnvelope envelope = soapPart.getEnvelope();
    SOAPHeader header = envelope.getHeader();
    SOAPBody body = envelope.getBody();
    header.detachNode();

    Name bodyName = envelope.createName("GetFile");
    SOAPBodyElement bodyElement = body.addBodyElement(bodyName);

    Name name = envelope.createName("file");
    SOAPElement fileName = bodyElement.addChildElement(name);
    fileName.addTextNode(fileXml);
  }

  public static void displayMessage(SOAPMessage mess)
          throws SOAPException {
    SOAPBody body = mess.getSOAPBody();
    Iterator it = body.getChildElements();
    SOAPBodyElement bodyElement = (SOAPBodyElement) it.next();
    System.out.println(bodyElement);
  }

  public void start() {
    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    try {
      System.out.println("Enter the file XML:");
      fileXml = br.readLine();
    } catch (IOException e) {
      e.printStackTrace();
    }
  }

  public static void main(String[] args)
          throws SOAPException, MalformedURLException, TransformerException {

    StoreMessage client = new StoreMessage();
    client.start();
    client.createSOAPRequest();

    SOAPConnectionFactory soapConnectionFactory = SOAPConnectionFactory.newInstance();
    SOAPConnection connection = soapConnectionFactory.createConnection();

    URL endpoint = new URL("http://localhost:8080/axis/services/StoreService");

    respMess = connection.call(reqMess, endpoint);

    displayMessage(respMess);
  }
}
