<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="t" tagdir="/WEB-INF/tags/" %>
<t:MasterPage>
  <jsp:body>
    <form action="/lab01/hello/Hello" class="form-inline" method="post">
      <input type="submit" value="Do!" class="btn" />
      <input type="text" value="${helloWorld}" class="input-large" />
    </form>
    <form action="/lab01/hello/Add" class="form-inline" method="post">
      <input type="text" name="x" value="${x}" class="input-small" />
      +
      <input type="text" name="y" value="${y}" class="input-small" />
      <input type="submit" value="=" class="btn" />
      <input type="text" name="z" value="${z}" class="input-small" />
    </form>
  </jsp:body>
</t:MasterPage>
