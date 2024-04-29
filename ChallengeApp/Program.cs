var number = 56765453;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
char[] numbers = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

Console.WriteLine(numberInString);

Console.WriteLine("Number for check -> " + number);
Console.WriteLine("Powtażalność cyfr");

foreach (var num in numbers)

{
    var counter = 0;

    foreach (var let in letters)
    {
        if (numbers == letters)
            counter++;
        
    }
    Console.WriteLine(number + "->" + counter);
}