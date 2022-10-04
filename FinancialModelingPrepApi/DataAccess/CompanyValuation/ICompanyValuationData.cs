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
    public interface ICompanyValuationData
    {
        #region Income Statement
        
        [Get(path: "/v3/income-statement/{symbol}")]
        Task<Model.ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync
            (string symbol);

        [Get(path: "/v3/income-statement/{symbol}")]
        Task<Model.ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync
            (string symbol, IncomeStatementParams pathParams);

        #endregion

        #region Income Statement
        
        
        #endregion
    }
}
