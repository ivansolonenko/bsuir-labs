import java.io.IOException;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.soap.*;
import javax.xml.transform.TransformerException;
import org.apache.axis.AxisFault;
import org.apache.axis.MessageContext;
import org.apache.axis.message.SOAPBodyElement;
import org.apache.axis.message.SOAPEnvelope;
import org.w3c.dom.Node;
import org.w3c.dom.*;
import org.w3c.dom.Text;
import org.xml.sax.SAXException;

public class StoreService {

  public String getFileName(SOAPEnvelope req)
          throws SOAPException, AxisFault {
    SOAPBodyElement reqBody = (SOAPBodyElement) req.getBodyElements().get(0);
    String str = "";
    NodeList nodes = reqBody.getChildNodes();
    for (int i = 0; i < nodes.getLength(); i++) {
      Node currentNode = nodes.item(i);
      if (currentNode instanceof Element) {
        Element element = (Element) currentNode;
        Text textNode = (Text) element.getFirstChild();
        str = textNode.getData().trim();
      }
    }
    return str;
  }

  public SOAPEnvelope createSOAPResponse(String fileName, SOAPEnvelope resp)
          throws SOAPException, ParserConfigurationException, IOException, SAXException {
    DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
    DocumentBuilder builder = dbFactory.newDocumentBuilder();
    Document document = builder.parse(fileName);

    MessageContext msgCntxt = MessageContext.getCurrentContext();
    SOAPMessage respMess = msgCntxt.getMessage();

    SOAPPart soapPart = respMess.getSOAPPart();
    SOAPEnvelope envelope = (SOAPEnvelope) soapPart.getEnvelope();
    SOAPHeader header = resp.getHeader();

    SOAPBody body = resp.getBody();
    header.detachNode();

    SOAPBodyElement docElement = (SOAPBodyElement) body.addDocument(document);
    return envelope;
  }

  public void storeService(SOAPEnvelope req, SOAPEnvelope resp)
          throws Exception, TransformerException, IOException {
    String fileName = getFileName(req);
    resp = createSOAPResponse(fileName, resp);
  }
}
