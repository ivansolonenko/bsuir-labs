<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@taglib prefix="fn" uri="http://java.sun.com/jsp/jstl/functions" %>
<%@taglib prefix="t" tagdir="/WEB-INF/tags/" %>
<t:MasterPage>
  <jsp:body>
    <form action="/kot01/library/GetBooks" method="post" style="display: inline; float: left; padding-right: 4px;">
      <input type="submit" value="Show All" class="btn" />
    </form>
    <form action="/kot01/library/FindBooksByAuthor" class="form-search" method="post">
      <input type="text" class="input-medium search-query" id="auhtor" name="author"/>
      <input type="submit" class="btn" value="Search"/>
    </form>
    <div style="clear: both;"></div>
    <c:choose>
      <c:when test="${books == null || fn:length(books) == 0}">
        <span class="error">Nothing Found</span>
      </c:when>
      <c:otherwise>
        <table class="table table-bordered table-condensed table-striped">
          <tr>
            <td>Author</td>
            <td>Title</td>
            <td>Year</td>
            <td>Pages</td>
          </tr>
          <c:forEach items="${books}" var="book">
            <tr>
              <td>
                <c:out value="${book.author.value}" />
              </td>
              <td>
                <c:out value="${book.title.value}" />
              </td>
              <td>
                <c:out value="${book.year.value}" />
              </td>
              <td>
                <c:out value="${book.pages.value}" />
              </td>
            </tr>
          </c:forEach>
        </table>
      </c:otherwise>
    </c:choose>
    <hr/>
    <form action="/kot01/library/AddBook" method="post">
      <div class="control-group">
        <label class="control-label" for="author">Author:</label>
        <div class="controls">
          <input type="text" id="author" name="author" value="${author}"/>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="title">Title:</label>
        <div class="controls">
          <input type="text" id="title" name="title" value="${title}" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="year">Year:</label>
        <div class="controls">
          <input type="text" id="year" name="year" value="${year}"/>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="pages">Pages</label>
        <div class="controls">
          <input type="text" id="pages" name="pages" value="${pages}"/>
        </div>
      </div>
      <input type="submit" value="Add" class="btn" />
    </form>
  </jsp:body>
</t:MasterPage>
