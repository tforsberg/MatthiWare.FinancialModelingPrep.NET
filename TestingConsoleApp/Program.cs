// See https://aka.ms/new-console-template for more information
using System;
using MatthiWare.FinancialModelingPrep;


Console.WriteLine("Hello, World!");

//Services.AddFinancialModelingPrepApiClient(new FinancialModelingPrepOptions()
//{
//    ApiKey = "API-KEY-HERE"
//});

//var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

//// do something with api like getting the latest Apple Stock Quote
//var quoteResult = await api.CompanyValuation.GetQuoteAsync("AAPL");


FinancialModelingPrepOptions financialModelingPrepOptions = new FinancialModelingPrepOptions()
{
    ApiKey = "7a711b4efd6f42664961b587f8944130"
};

var api = FinancialModelingPrepApiClientFactory.CreateClient(financialModelingPrepOptions);

// do something with api like getting the latest Apple Stock Quote
var quoteResult = await api.CompanyValuation.GetQuoteAsync("TSLA");

Console.WriteLine(quoteResult.Data);


