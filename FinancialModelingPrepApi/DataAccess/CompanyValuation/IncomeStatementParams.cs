using MatthiWare.FinancialModelingPrep.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.DataAccess.CompanyValuation
{
    public class IncomeStatementParams
    {
        //  (string symbol, Period period = Period.Quarter, int? limit = 40);

        //public string Symbol { get; set; }

        public Period? Period { get; set; }

        public int? Limit { get; set; }
    }
}
