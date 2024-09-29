// variables
// char letter = 'a';
// int num = 10;
// double doubleNum = 10.20;
// string userName = "John";
//declaring a empty variable
// bool isTrue;
//assigning empty variable value
// isTrue = false; 
// Console.WriteLine(userName);
// Console.WriteLine(letter);
// Console.WriteLine(num);
// Console.WriteLine(doubleNum);
// Console.WriteLine(isTrue);

// constants
// const string passKey = "004-user";
// Console.WriteLine(passKey);

// display variables
// Console.WriteLine("string - " + userName );
// Console.WriteLine(num + doubleNum );

// declare multiple variables
// int x = 2, y = 4, z = 6;
// Console.WriteLine( x + y + z);  

// data types

// int 4 bytes
// long 8 bytes
// float 4 bytes
// double 8 bytes
// bool 1 bit
// char 2 bytes
// string 2 bytes per character

// type casting

// implicit casting 
// int myInt = 9;
// double myDouble = myInt;  //automatic casting int to double
// Console.WriteLine(myDouble);

// explicit casting
// double myDouble = 9;
// int myInt = (int) myDouble;  //manual casting double to int
// Console.WriteLine(myInt);

// type conversion methods 

// Convert.ToBoolean()
// Convert.ToDouble()
// Convert.ToString()
// Convert.ToInt32()
// Convert.ToInt64() etc.

// int myInt = 10;
// Console.WriteLine(System.Convert.ToString(myInt));


// get user input
// Console.WriteLine("Enter UserName:");
// string UserName = Console.ReadLine(); 
// Console.WriteLine(UserName);

// arithmetic operators
// +
// -
// *
// /
// %
// ++
// --

// assignment operator
// =
// +=
// -=
// *=
// /=
// %=
// &=
// |=
// ^=
// >>=
// <<=

// comparison operator
// ==
// !=
// >=
// <=
// >
// <

// logical operatord
// &&  returns true if both values are true
// || return true if one value is true
// | it reverse the result if the result is true it return false 

//math
// Console.WriteLine(Math.Max(5,129));
// Console.WriteLine(Math.Min(15,47));
// Console.WriteLine(Math.Sqrt(64));
// Console.WriteLine(Math.Abs(-4.6));
// Console.WriteLine(Math.Round(10.55));

// string 

// length property
// string text = "Hello world!";
// Console.WriteLine(text.Length);

// methods 
// it has many methods like Toupper() and Contains()
// string text = "Hello World!";
// Console.WriteLine(text.ToUpper());
// Console.WriteLine(text.Contains('H'));

// concatenation
// string user1 = "Revi";
// string user2 = "John";
// Console.WriteLine( user1 + user2 );
// Console.WriteLine(string.Concat(user1,user2));

// interpolation
// Console.WriteLine($"{user1} {user2}");

// access string
// string user = "Revi";
// Console.WriteLine(user[0]);

//to find a index of a string
// Console.WriteLine(user.IndexOf("v"));

// substring This method used to extract a string 
// Console.WriteLine(user.Substring(0, 3));

// special characters
// string text = "Hello\" Hello ";
// Console.WriteLine(text);
// string text2 = "Hello \nHello";
// Console.WriteLine(text2);

//bool
// int x = 10;
// int y =20;
// bool z = x < y ;  //boolean expression 
// Console.WriteLine(z);

// if 
// bool isTrue = true;
// if(isTrue){
//     Console.WriteLine("it's true");
// };

// if else
// bool isTrue = false;
// if(isTrue){
//     Console.WriteLine("it's true");
// }else{
//     Console.WriteLine("It's False");
// };

// else if

// bool isTrue = false;
// bool isTrue2 = true;

// if(isTrue){
//     Console.WriteLine("It's true");
// } else if(isTrue2){
//     Console.WriteLine("It's true but in else if");
// } else{
//     Console.WriteLine("It's false");
// };

// ternary operator

// bool isTrue = true;

// string ifElseExp = isTrue ? "It's true" : "It's false";
// Console.WriteLine(ifElseExp);