
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.HashMap;
import javax.xml.soap.*;
import javax.xml.transform.TransformerException;
import org.apache.axis.AxisFault;
import org.apache.axis.MessageContext;
import org.apache.axis.message.SOAPEnvelope;
import org.w3c.dom.Node;
import org.w3c.dom.*;
import org.w3c.dom.Text;

public class Soap {

  private SOAPMessage requestMessage;
  private SOAPMessage responseMessage;

  private Soap(SOAPMessage requestMessage) {
    this.requestMessage = requestMessage;
  }

  public static Soap createRequest(String command, HashMap<String, String> params)
          throws SOAPException, TransformerException {
    MessageFactory factory = MessageFactory.newInstance();
    SOAPMessage requestMessage = factory.createMessage();

    SOAPPart soapPart = requestMessage.getSOAPPart();
    javax.xml.soap.SOAPEnvelope envelope = soapPart.getEnvelope();
    SOAPHeader header = envelope.getHeader();
    SOAPBody body = envelope.getBody();
    header.detachNode();

    Name bodyName = envelope.createName(command);
    SOAPBodyElement bodyElement = body.addBodyElement(bodyName);

    for (String key : params.keySet()) {
      Name name = envelope.createName(key);
      SOAPElement element = bodyElement.addChildElement(name);
      element.addTextNode(params.get(key));
    }

    return new Soap(requestMessage);
  }

  public static String parseRequest(SOAPEnvelope request, HashMap<String, String> map)
          throws SOAPException, AxisFault {
    SOAPBodyElement body = (SOAPBodyElement) request.getBodyElements().get(0);

    NodeList nodes = body.getChildNodes();
    for (int i = 0; i < nodes.getLength(); i++) {
      Node currentNode = nodes.item(i);
      if (currentNode instanceof Element) {
        Element element = (Element) currentNode;
        if (element.hasChildNodes()) {
          NodeList childNodes = element.getChildNodes();
          for (int j = 0; j < childNodes.getLength(); j++) {
            Text textNode = (Text) childNodes.item(0);
            map.put(currentNode.getNodeName(), textNode.getData().trim());
          }
        }
      }
    }
    return body.getNodeName();
  }

  public static SOAPEnvelope createResponse(SOAPEnvelope response, Document document)
          throws SOAPException {
    MessageContext messageContext = MessageContext.getCurrentContext();
    SOAPMessage responseMessage = messageContext.getMessage();

    SOAPPart soapPart = responseMessage.getSOAPPart();
    SOAPEnvelope envelope = (SOAPEnvelope) soapPart.getEnvelope();
    SOAPHeader header = response.getHeader();

    SOAPBody body = response.getBody();
    header.detachNode();

    body.addDocument(document);

    return envelope;
  }

  public static SOAPEnvelope createResponse(SOAPEnvelope response, String sName, String value)
          throws SOAPException {
    MessageContext messageContext = MessageContext.getCurrentContext();
    SOAPMessage responseMessage = messageContext.getMessage();

    SOAPPart soapPart = responseMessage.getSOAPPart();
    SOAPEnvelope envelope = (SOAPEnvelope) soapPart.getEnvelope();
    SOAPHeader header = response.getHeader();

    SOAPBody body = response.getBody();
    header.detachNode();

    Name bodyName = envelope.createName("response");
    SOAPBodyElement bodyElement = body.addBodyElement(bodyName);

    Name name = envelope.createName(sName);
    SOAPElement element = bodyElement.addChildElement(name);
    element.addTextNode(value);

    return envelope;
  }

  public Soap getResponse(String endpoint)
          throws SOAPException, MalformedURLException, TransformerException {
    SOAPConnectionFactory soapConnectionFactory = SOAPConnectionFactory.newInstance();
    SOAPConnection connection = soapConnectionFactory.createConnection();
    this.responseMessage = connection.call(requestMessage, new URL(endpoint));
    return this;
  }

  public ArrayList<Element> parsePesponse()
          throws SOAPException {
    SOAPBody body = responseMessage.getSOAPBody();
    SOAPBodyElement bodyElement = (SOAPBodyElement) body.getChildElements().next();

    NodeList nodeList = bodyElement.getChildNodes();
    ArrayList<Element> elements = new ArrayList<Element>();

    for (int i = 0; i < nodeList.getLength(); i++) {
      Node node = nodeList.item(i);
      if (node.getNodeType() == Node.ELEMENT_NODE) {
        elements.add((Element) node);
      }
    }

    return elements;
  }
}
