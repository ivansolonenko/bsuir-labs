<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@taglib prefix="t" tagdir="/WEB-INF/tags/" %>
<t:MasterPage>
  <jsp:body>
    <%--<form action="/lab01/calculator/Credits" class="form-inline" method="post">
      <c:choose>
        <c:when test="${credits == null || credits.size() == 0}">
          <input type="submit" value="Show History" class="btn" />
        </c:when>
        <c:otherwise>
          <div>
            <input type="submit" value="Refresh" class="btn" />
            <hr/>
          </div>
          <table class="table table-bordered table-condensed table-striped">
            <c:forEach items="${credits}" var="credit">
              <tr>
                <td>
                  <c:out value="${credit}" />
                </td>
                <td>
                  <c:out value="${credit.creditSum}" />
                </td>
                <td>
                  <c:out value="${credit.monthsCount}" />
                </td>
                <td>
                  <c:out value="${credit.percents}" />
                </td>
              </tr>
            </c:forEach>
          </table>
        </c:otherwise>
      </c:choose>
    </form>--%>
    <form action="/lab01/calculator/AnnuitentPayment" class="form-horizontal" method="post">
      <div class="control-group">
        <label class="control-label">Months Count:</label>
        <div class="controls">
          <input type="text" name="monthsCount" value="${monthsCount}"/>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label">Credit Sum:</label>
        <div class="controls">
          <input type="text" name="creditSum" value="${creditSum}" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label">Percents:</label>
        <div class="controls">
          <input type="text" name="percents" value="${percents}"/>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label">Payment:</label>
        <div class="controls">
          <input type="text" name="payment" value="${payment}" readonly="readonly" />
        </div>
      </div>
      <input type="submit" value="Calculate!" class="btn" />
    </form>
  </jsp:body>
</t:MasterPage>
