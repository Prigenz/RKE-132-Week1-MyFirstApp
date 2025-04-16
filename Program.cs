//This is a comment to my code
//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //Output
//string - sõne
string username; //Input

username = Console.ReadLine();

Console.WriteLine("Hello" + ", " + username + "!"); //Output

//string interpolation
Console.WriteLine($"Hello, {username}!"); //Output

