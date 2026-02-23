// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

#region Writing Comments in C#

// ************* Writing Comments in C# **************

// Console.Write("This is a single-line comment"); // This is a single-line comment
// Console.WriteLine("This is a multi-line comment"); // This is a multi-line comment
//
// Console.WriteLine("This is a multi-line comment");

// Console.WriteLine("***** Food Categories *****");
// Console.WriteLine();
// Console.WriteLine("1. Fruits");
// Console.WriteLine("2. Vegetables");
// Console.WriteLine("3. Dairy Products");
// Console.WriteLine("4. Grains"); 
// Console.WriteLine("5. Salads");
// Console.WriteLine("***** Food Categories *****");

#endregion

#region Variables in C#

//************** Variables in C# **************

//String Variable
// String name;
// name = "John Doe";  
// Console.WriteLine(name);

// string customerName;
// string customerAddress;
// string customerCity;
// string customerState , email , phoneNumber;
// customerName = "John Doe";
// customerAddress = "123 Main Street";
// customerCity = "Berlin";
// customerState = "Germany";
// email = "exampl@gmail.com";
// phoneNumber = "1234567890";
//
// Console.WriteLine("************** Customer Information **************");
// Console.WriteLine();
// Console.WriteLine("Customer Name: " + customerName);
// Console.WriteLine("Customer Address: " + customerAddress);
// Console.WriteLine("Customer City and State: " + customerCity + " and " + customerState);
// Console.WriteLine("Customer Email: " + email);
// Console.WriteLine("Customer Phone Number: " + phoneNumber);
//
// customerName = "Ayse Yılmaz";
// Console.WriteLine("Customer Name: " + customerName);

#endregion


#region Int Variables in C#

//************** Int Variables in C# **************
// int tamsayialr ile ilgili işlemler yapabiliriz

// int number = 10;
// Console.WriteLine("Number: " + number);

int hamburgerPrice = 5;
int friesPrice = 3;
int waterPrice = 2;
int pizzaPrice = 8;
int lemonadePrice = 4;
int totalPrice = hamburgerPrice + friesPrice + waterPrice + pizzaPrice + lemonadePrice;

Console.WriteLine("*************** Restaurant Menu ***************");
Console.WriteLine("***************************************************");
Console.WriteLine();
Console.WriteLine("---------- Hamburger: " + hamburgerPrice + " $");
Console.WriteLine("---------- Fries: " + friesPrice + " $");
Console.WriteLine("---------- Water: " + waterPrice + " $");
Console.WriteLine("---------- Pizza: " + pizzaPrice + " $");
Console.WriteLine("---------- Lemonade: " + lemonadePrice + " $");
Console.WriteLine("********************************");
Console.WriteLine("Your Bill ");

Console.WriteLine();

int hamburgercount;
int friescount;
int watercount;
int pizzacount;
int lemonadecount;
int totalHamburgerPrice = 0 ;
int totalFriesPrice = 0 ;
int totalWaterPrice = 0 ;
int totalPizzaPrice = 0 ;
int totalLemonadePrice = 0 ;

hamburgercount = 3;
friescount = 4;
watercount = 5;
pizzacount = 8;
lemonadecount = 4;

totalHamburgerPrice = hamburgercount * hamburgerPrice;
totalFriesPrice = friescount * friesPrice;
totalWaterPrice = watercount * waterPrice;
totalPizzaPrice = pizzacount * pizzaPrice;
totalLemonadePrice = lemonadecount * lemonadePrice;

totalPrice= totalHamburgerPrice + totalFriesPrice + totalWaterPrice + totalPizzaPrice + totalLemonadePrice;


Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------- Fries Count: " + friescount +  " " +"Total Fries Price: " + totalFriesPrice + " $");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------- Hamburger Count: " + hamburgercount + " " + "Total Hamburger Price: " + totalHamburgerPrice + " $");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------- Water Count: " + watercount + " " + "Total Water Price: " + totalWaterPrice + " $");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------- Pizza Count: " + pizzacount + " " + "Total Pizza Price: " + totalPizzaPrice + " $");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------- Lemonade Count: " + lemonadecount + " " + "Total Lemonade Price: " + totalLemonadePrice + " $");
Console.WriteLine("---------------------------------------------");

Console.WriteLine("Total Price: " + totalPrice + " $");

#endregion



Console.Read(); // This is runing the code to until the user press a Enter key
