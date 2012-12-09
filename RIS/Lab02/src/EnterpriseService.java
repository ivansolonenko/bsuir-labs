
import java.util.ArrayList;
import java.util.HashMap;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.apache.axis.message.SOAPEnvelope;
import org.w3c.dom.Document;
import org.w3c.dom.Element;

public class EnterpriseService {

  private Document createDocument(ArrayList<Enterprise> enterprises) {
    try {
      Document doc = DocumentBuilderFactory.newInstance().newDocumentBuilder().newDocument();
      Element rootElement = doc.createElement("enterprises");
      doc.appendChild(rootElement);

      for (Enterprise enterprise : enterprises) {
        enterprise.ToXML(doc, rootElement);
      }

      return doc;
    } catch (ParserConfigurationException ex) {
      Logger.getLogger(EnterpriseService.class.getName()).log(Level.SEVERE, null, ex);
    }
    return null;
  }

  public void enterpriseService(SOAPEnvelope request, SOAPEnvelope response)
          throws Exception {
    HashMap<String, String> params = new HashMap<String, String>();
    String command = Soap.parseRequest(request, params);
    String fileName = params.get("filename");
    ArrayList<Enterprise> enterprises = new ArrayList<Enterprise>();
    Enterprises.GetInstance().Load(fileName);

    if (command.equals("get")) {
      enterprises = Enterprises.GetInstance().GetAll();
      Document document = createDocument(enterprises);
      response = Soap.createResponse(response, document);
    } else if (command.equals("add")) {
      Enterprises.GetInstance().Add(params);
      Enterprises.GetInstance().Save(fileName);
      response = Soap.createResponse(response, "status", "ok");
    } else if (command.equals("find")) {
      enterprises = Enterprises.GetInstance().FindByTitle(params.get("title"));
      Document document = createDocument(enterprises);
      response = Soap.createResponse(response, document);
    } else {
      response = null;
    }
  }
}
