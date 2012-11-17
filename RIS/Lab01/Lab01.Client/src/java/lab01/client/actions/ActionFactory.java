package lab01.client.actions;

import java.util.Map;

public class ActionFactory {

  public Action create(Map actions, String actionName) {
    Class<?> controllerClass = (Class<?>) actions.get(actionName.toUpperCase());
    if (controllerClass == null) {
      //estatedata.managers.LogManager.AppendLog(new RuntimeException(getClass() + " was unable to find an action named '" + actionName + "'  ."));
    }

    Action controllerInstance = null;
    try {
      controllerInstance = (Action) controllerClass.newInstance();
    } catch (InstantiationException ex) {
      //LogManager.AppendLog(ex);
    } catch (IllegalAccessException ex) {
      //LogManager.AppendLog(ex);
    }
    return controllerInstance;
  }
}
