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


// switch
// int date = 15;

// switch(date){
//     case 2 :
//         Console.WriteLine(2);
//         break;
//     case 15:
//         Console.WriteLine(15);
//         break;
//     default:
//         break;
// };

// while loop 
// bool isTrue = true;
// int i = 0;
// while(isTrue){
//     Console.WriteLine(i);
//     if(i == 3){
//         isTrue = false;
//     };
//     ++i;
// };

// do-while
// bool isTrue = false;
// do{
//  Console.WriteLine(1);
// } while(isTrue);

// for loop

// for( int i = 0; i <= 10; i++){
//     Console.WriteLine(i);
// };

// foreach
// string[] students = {"revi","kavi","guvi","kevi","paavi"};

// foreach ( string student in students ) {
//     Console.WriteLine(student);
// };

// break 

// for( int i = 0; i < 10; i++){
//     Console.WriteLine(i);
//     if(i == 5){
//         Console.WriteLine(i + " if");
//         break;
//     };
// };

// continue
// for( int i = 0; i < 10; i++){

//     if( i == 6){
//         continue;
//     };

//     Console.WriteLine(i);
// };

// array

// string[] cars = {"BMW","Toyota","Skoda","HM"};
// Console.WriteLine(cars[0]);

// int[] count = { 24,2,4,6,6,6};
// Console.WriteLine(count[0]);

// string[] cars = new string[4] { "BMW", "HM" , "Toyota" , "Skoda"};
// Console.WriteLine(cars[0]);
// cars[3] = "Maruti";
// Console.WriteLine(cars[3]); 

// loop through an array

// string[] cars = {"BMW","HM","Toyota","Mercedes"};
// for(int i = 0; i < cars.Length; i++){
//     Console.WriteLine(cars[i]);
// };

// foreach( string car in cars ) {
//     Console.WriteLine(car);
// };

// sort
// int[] nums = {10,20,30,4,5,6};
// char[] letters = {'z','d','f','m','b'};
// Array.Sort(nums);
// Array.Sort(letters);
// Console.WriteLine(nums[0]);
// Console.WriteLine(letters[0]);
// Console.WriteLine(nums.Max());
// Console.WriteLine(nums.Min());
// Console.WriteLine(nums.Sum ());

int[,] nums2D = { {1,2,3,4} , {4,5,6,7}};

// Console.WriteLine(nums2D[0,2]);
// nums2D[0,2] = 7;
// Console.WriteLine(nums2D[1,2]);
// Console.WriteLine(nums2D[0,2]);

// foreach( int i in  nums2D){
//     Console.WriteLine(i);
// };

// for( int i = 0; i < nums2D.GetLength(0); i++){ 
//     for( int j = 0; j < nums2D.GetLength(1); j++){
//         Console.WriteLine(nums2D[i,j]);
//     };
// };