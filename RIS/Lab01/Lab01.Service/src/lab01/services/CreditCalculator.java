package lab01.services;

import java.util.ArrayList;
import lab01.models.Credit;
import lab01.models.DbManager;

public class CreditCalculator {

  public Double GetAnnuitentPayment(int monthsCount, double creditSum, double percents) {
    DbManager db = DbManager.GetInstance();
    db.Load();
    Credit credit = new Credit(monthsCount, creditSum, percents);
    db.Add(credit);
    db.Save();
    return credit.annuitentPayment();
  }

  public Credit[] GetCredits() {
    DbManager db = DbManager.GetInstance();
    db.Load();
    ArrayList<Credit> credits = db.GetAll();
    return credits.toArray(new Credit[credits.size()]);
  }
}
