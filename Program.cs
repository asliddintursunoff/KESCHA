Console.Write("Enter 1- number: ");
string a = Console.ReadLine();
Console.Write("Enter 2- number: ");
string b = Console.ReadLine();
int x = Convert.ToInt32(a);
int y = Convert.ToInt32(b);
Console.WriteLine($"adding : {x+y}");
Console.WriteLine($"minus : {x-y}");
Console.WriteLine($"product : {x*y}");
Console.WriteLine($"division : {x/y}");
Console.WriteLine($"reminder : {x%y}");


//age difference between me and kesha
int KESHA = 2;
Console.Write("Enter your age: ");
string age= Console.ReadLine();
Console.WriteLine($"DIfference is : {Convert.ToInt32(age)-KESHA}");