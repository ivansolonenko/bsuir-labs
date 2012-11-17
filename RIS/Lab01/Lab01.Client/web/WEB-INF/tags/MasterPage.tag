<%@tag description="Generic Page Template" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
  <head>
    <title> Lab 01</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <link href="/lab01/resources/bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="/lab01/resources/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet"/>
  </head>
  <body style="padding-top: 10px;">
    <div class="container-flurid">
      <div class="row-flurid">
        <div class="span2">
          <ul class="nav nav-pills nav-stacked">
            <li>
              <a href="/lab01/hello">Hello World Client</a>
            </li>
            <li>
              <a href="/axis2/services/Hello?wsdl">Hello World Service</a>
            </li>
            <li>
              <a href="/lab01/calculator">Credit Calculator Client</a>
            </li>
            <li>
              <a href="/axis2/services/CreditCalculator?wsdl">Credit Calculator Service</a>
            </li>
          </ul>
        </div>
        <div class="span10">
          <jsp:doBody/>
        </div>
      </div>
  </body>
</html>
