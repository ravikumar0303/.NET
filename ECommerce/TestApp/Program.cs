
using Catalog;
using CRM;
using Membership;
using OrderProcessing;
using ShoppingCart;


//Property Initializer
Product p1=new Product{ Id=117,
                        Title="Gerbera",
                         Description="Wedding Flower",
                         UnitPrice=10,
                         Quantity=56000};

p1.Title="Jasmine";
Console.WriteLine("ID--> "+p1.Id + " Title--> "+ p1.Title + "Description--> "+ p1.Description+"UnitPrice--> "+p1.UnitPrice+"Quantity--> "+p1.Quantity);
