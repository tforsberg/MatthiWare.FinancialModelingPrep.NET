using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.CompanyValuation;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MatthiWare.FinancialModelingPrep.DataAccess.CompanyValuation
{
    public interface IIncomeStatementData
    {
        [Get(path: "/income-statement/{symbol}")]
        Task<IncomeStatementResponse> GetIncomeStatement(string symbol);

        [Get(path: "/income-statement/{symbol}")]
        Task<Model.ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40);

    }
}
