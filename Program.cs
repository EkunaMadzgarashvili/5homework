
#region Task1
Console.WriteLine("Enter the length");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
Console.WriteLine("Now enter numbers");
for(int i = 0; i < size; i++)
{

    numbers[i] = int.Parse(Console.ReadLine());
}
List<int> odd = new List<int>();
List<int> even = new List<int>();
for(int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] %2 == 0)
    {
        even.Add(numbers[j]);
    }
    else
    {
        odd.Add(numbers[j]);
    }
}

Console.WriteLine("The even sequence ");
Console.WriteLine(string.Join(", ", even));
Console.WriteLine("The odd sequence ");
Console.WriteLine(string.Join(", ", odd));
#endregion

#region Task2

Console.WriteLine("Contacts");
Dictionary<string, int> contacts = new Dictionary<string, int>();
while (true)
{
    Console.WriteLine("Which operation do you want? Add  |  Delete  |  Update");
    string answer = Console.ReadLine();
    if (answer == "Add")
    {
        Console.WriteLine("Write name and number please");
        String name1 = Console.ReadLine();
        int number1 = int.Parse(Console.ReadLine());
        if (contacts.ContainsKey(name1) || contacts.ContainsValue(number1))
        {
            Console.WriteLine("Contact already exists.");
        }
        else
        {
            contacts.Add(name1, number1);
        }
    }
    else if (answer == "Delete")
    {
        Console.WriteLine("Choose contact to delete");
        String name2 = Console.ReadLine();
        if (!contacts.ContainsKey(name2))
        {
            Console.WriteLine("Contact does not exist.");

        }
        else
        {
            contacts.Remove(name2);
        }
    }
    else if (answer == "Update")
    {
        Console.WriteLine("Write name and number please");
        String name3 = Console.ReadLine();
        int number3 = int.Parse(Console.ReadLine());
        if (!contacts.ContainsKey(name3))
        {
            Console.WriteLine("Contact does not exist.");
        }
        else
        {
            contacts[name3] = number3;
        }
    }
    else
    {
        break;
    }

}
#endregion

#region Task3
Console.WriteLine("Enter length");
int massiveSize = int.Parse(Console.ReadLine());
int[] massive = new int[massiveSize];
Dictionary<int, int> dict = new Dictionary<int, int>();
Console.WriteLine("Now enter numbers");
for (int k = 0; k < massiveSize; k++)
{

    massive[k] = int.Parse(Console.ReadLine());
    if (!dict.ContainsKey(massive[k]))
    {
        dict.Add(massive[k], 1);
    }
    else
    {
        dict[massive[k]]++;
    }
}
foreach (KeyValuePair<int, int> pair in dict)
{
    int product = pair.Key * pair.Value;
    Console.WriteLine($"{pair.Key} appears {pair.Value} times sum {product}");
}
#endregion

#region Task4
int[] arr = new int[] { 1, 4, 3, 2, 8, 7, 6, 9, 10, 5 };
for (int index1 = 0; index1 < arr.Length - 1; index1++)
{
    for (int index2 = index1 + 1; index2 < arr.Length; index2++)
    {
        if (arr[index1] > arr[index2])
        {
            int tmp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = tmp;
        }
    }
}

Console.WriteLine($"The top 2 score : {arr[arr.Length - 2]} and {arr[arr.Length - 1]} ");
#endregion





