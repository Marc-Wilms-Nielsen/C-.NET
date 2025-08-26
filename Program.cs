

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;


int result1 = 0;
var result2 = 0.0m;
float result3 = 0.0f;



// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
decimal devision1 = (decimal)value1 / value2;
result1 = Convert.ToInt32(devision1);

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");



// Your code here to set result2
result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");



// Your code here to set result3
result3 = value3 / value1;

Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");