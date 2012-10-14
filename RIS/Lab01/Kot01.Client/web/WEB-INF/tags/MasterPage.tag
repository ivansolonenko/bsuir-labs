<%@tag description="Generic Page Template" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <link href="/kot01/resources/bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="/kot01/resources/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet"/>
  </head>
  <body style="padding-top: 10px;">
    <div class="container-flurid">
      <div class="row-flurid">
        <div class="span2">
          <ul class="nav nav-pills nav-stacked">
            <li>
              <a href="/kot01/library">Library Service Client</a>
            </li>
            <li>
              <a href="/axis2/services/LibraryService?wsdl">Library Service WSDL</a>
            </li>
          </ul>
        </div>
        <div class="span10">
          <jsp:doBody/>
        </div>
      </div>
  </body>
</html>
