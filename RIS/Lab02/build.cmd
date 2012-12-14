@echo off
goto environment
:end_environment
goto prepare
:end_prepare
goto task_2
:end_task
goto eof

:environment
set JAVA_HOME=C:\Program Files\Java\jdk1.5.0_22
set JRE_HOME=C:\Program Files\Java\jre1.5.0_22
set CATALINA_HOME=C:\Users\cruazer\.tomcat\5.5.35
goto end_environment

:prepare
set CATALINA_APPS=%CATALINA_HOME%\webapps
set AXIS_CLASSES=%CATALINA_APPS%\axis\WEB-INF\classes
set AXIS_LIBS=%CATALINA_APPS%\axis\WEB-INF\lib
set PROJECT_CLASSES_1=build/classes
set PROJECT_CLASSES_2=build\classes
set PROJECT_LIBS=lib
set PROJECT_WSDDS=wsdd
set classpath=.;./%PROJECT_CLASSES_1%;%AXIS_LIBS%\axis.jar;%AXIS_LIBS%\jaxrpc.jar;%AXIS_LIBS%\commons-logging-1.0.4.jar;%AXIS_LIBS%\commons-discovery-0.2.jar;%AXIS_LIBS%\saaj.jar;%AXIS_LIBS%\xercesImpl.jar;%AXIS_LIBS%\xmlParserAPIs.jar;%AXIS_LIBS%\activation.jar;%AXIS_LIBS%\mail.jar;%AXIS_LIBS%\wsdl4j-1.5.1.jar
set PATH=%JAVA_HOME%\bin;%PATH%
set JPDA_ADDRESS=8084
set JPDA_TRANSPORT=dt_socket
mkdir %PROJECT_CLASSES_2%
copy axis.war %CATALINA_APPS%
cmd /c %CATALINA_HOME%\bin\catalina.bat jpda start
ping 1.1.1.1 -n 1 -w 7000 > nul
copy %PROJECT_LIBS% %AXIS_LIBS%
goto end_prepare

:task_1
javac -classpath .;./%PROJECT_CLASSES_1%;./%PROJECT_LIBS%/axis.jar;./lib/saaj.jar -d ./%PROJECT_CLASSES_1% src/StoreMessage.java
javac -classpath .;./%PROJECT_CLASSES_1%;./%PROJECT_LIBS%/axis.jar;./lib/saaj.jar -d ./%PROJECT_CLASSES_1% src/StoreService.java
copy %PROJECT_CLASSES_2%\StoreService.class %AXIS_CLASSES%
java org.apache.axis.client.AdminClient %PROJECT_WSDDS%/StoreService.wsdd
java StoreMessage
goto end_task

:task_2
javac -classpath .;./%PROJECT_CLASSES_1%;./%PROJECT_LIBS%/axis.jar;./lib/saaj.jar -d ./%PROJECT_CLASSES_1% src/Soap.java src/Enterprise.java src/EnterpriseBrowser.java
javac -classpath .;./%PROJECT_CLASSES_1%;./%PROJECT_LIBS%/axis.jar;./lib/saaj.jar -d ./%PROJECT_CLASSES_1% src/Soap.java src/Enterprise.java src/Enterprises.java src/EnterpriseService.java
copy %PROJECT_CLASSES_2%\Enterprise.class %AXIS_CLASSES%
copy %PROJECT_CLASSES_2%\Enterprises.class %AXIS_CLASSES%
copy %PROJECT_CLASSES_2%\EnterpriseService.class %AXIS_CLASSES%
copy %PROJECT_CLASSES_2%\Soap.class %AXIS_CLASSES%
java org.apache.axis.client.AdminClient %PROJECT_WSDDS%/EnterpriseService.wsdd
java EnterpriseBrowser
goto end_task

:eof