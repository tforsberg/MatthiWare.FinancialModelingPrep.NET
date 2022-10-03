using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep;

public class Rootobject
{
    public Class1[] Property1 { get; set; }
}

public class Class1
{
    public string date { get; set; }
    public string symbol { get; set; }
    public string reportedCurrency { get; set; }
    public string cik { get; set; }
    public string fillingDate { get; set; }
    public string acceptedDate { get; set; }
    public string calendarYear { get; set; }
    public string period { get; set; }
    public long revenue { get; set; }
    public long costOfRevenue { get; set; }
    public long grossProfit { get; set; }
    public float grossProfitRatio { get; set; }
    public long researchAndDevelopmentExpenses { get; set; }
    public float generalAndAdministrativeExpenses { get; set; }
    public float sellingAndMarketingExpenses { get; set; }
    public long sellingGeneralAndAdministrativeExpenses { get; set; }
    public float otherExpenses { get; set; }
    public long operatingExpenses { get; set; }
    public long costAndExpenses { get; set; }
    public long interestIncome { get; set; }
    public long interestExpense { get; set; }
    public long depreciationAndAmortization { get; set; }
    public long ebitda { get; set; }
    public float ebitdaratio { get; set; }
    public long operatingIncome { get; set; }
    public float operatingIncomeRatio { get; set; }
    public long totalOtherIncomeExpensesNet { get; set; }
    public long incomeBeforeTax { get; set; }
    public float incomeBeforeTaxRatio { get; set; }
    public long incomeTaxExpense { get; set; }
    public long netIncome { get; set; }
    public float netIncomeRatio { get; set; }
    public float eps { get; set; }
    public float epsdiluted { get; set; }
    public long weightedAverageShsOut { get; set; }
    public long weightedAverageShsOutDil { get; set; }
    public string link { get; set; }
    public string finalLink { get; set; }
}


