//#1
//Create a collection of doubles for these)
//For each element, add its index to its value, and output the resulting collection to console

List<double> collection = new List<double>() { 1, 2.5, 3.5, 4.5, 5.0, 6.5, 7.5, 8 };

for (int i = 5; i < collection.Count; i++)
{
    //collection[i] = collection[i] + i;
    collection[i] += i;
}
Console.WriteLine("The result after Task 1");
Console.WriteLine("\n");
foreach (double value in collection)
{
    Console.WriteLine(value + " ");
}
Console.WriteLine();
Console.WriteLine("or");
Console.WriteLine(string.Join(" , " , collection));


//#2
//Output elements of the collection one by one, until user enters "x" to the program

Console.WriteLine("\n");
Console.WriteLine("The result after Task 2 \n");
Console.WriteLine("Press Enter to see the next element or 'x' to exit.");
//foreach (double value in collection)
//{
//Console.Write(value + " \n");
//string input = Console.ReadLine();

//if (input == "x")
//{
//break;
//}
//}
OutputNumberOneByOne(collection);

//#3
//Read numbers one by one from console and save them to new collection. Do that until user enters "not a number" string.

Console.WriteLine("\n");
Console.WriteLine("The result after Task 3 \n");

List<double> newcollection = new List<double>();
do
{
    while (true)
    {
        Console.Write("Enter a number or 'not a number' to exit.");
        string input = Console.ReadLine();

        if (!double.TryParse(input, out double num))
        {
            break;
        }

        newcollection.Add(num);
    }
} while (newcollection.Count == 0);



//#4
//If there are 0 elements in the new cillection after step 3, repeat it (until user enters some numbers), then repeat step 2 (output numbers until user enters "x"
Console.WriteLine("\n");
Console.WriteLine("The result after Task 4 \n");

//foreach (double value in newcollection)
//{
//Console.Write(collection + "\n");
// string input = Console.ReadLine();
//if (input == "x")
//{
//break;
//}
//}
OutputNumberOneByOne(newcollection);
void OutputNumberOneByOne(List<double> collectionToOutput)
{
    foreach (double value in collectionToOutput)
    {
        Console.WriteLine(value);
        string input = Console.ReadLine();
        if (input == "x")
        {
            break;
        }
    }
}

