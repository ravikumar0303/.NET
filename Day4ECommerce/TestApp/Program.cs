

using TestApp;

SalesDashboard salesDashboard= new SalesDashboard();
salesDashboard.Refresh(); ;

CustomerDetails customerDetails = salesDashboard;
customerDetails.ShowDetails();

Console.WriteLine("***********");
OrderDetails orderDetails = salesDashboard;
orderDetails.ShowDetails();


