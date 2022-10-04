// See https://aka.ms/new-console-template for more information
using System;
using MatthiWare.FinancialModelingPrep;


Console.WriteLine("Hello, World!");

//Services.AddFinancialModelingPrepApiClient(new FinancialModelingPrepOptions()
//{
//});

//var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

//// do something with api like getting the latest Apple Stock Quote
//var quoteResult = await api.CompanyValuation.GetQuoteAsync("AAPL");


FinancialModelingPrepOptions financialModelingPrepOptions = new FinancialModelingPrepOptions()
{
    ApiKey = "API-KEY-HERE"
};

var api = FinancialModelingPrepApiClientFactory.CreateClient(financialModelingPrepOptions);

var quoteResult = await api.CompanyValuation.GetIncomeStatementAsync("TSLA");

//var r = await api.

Console.WriteLine(quoteResult.Data);


