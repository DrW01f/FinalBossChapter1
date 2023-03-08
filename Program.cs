
string[] Input()
{
    string[] array = { "LastHomeWork", "123", "_", "456", "три", "efdhgrthsrh", "()" };
    Console.WriteLine("Если хотите ввести новый массив нажмите Y");
    Console.WriteLine($"Иначе нажмите любую клавищу и будет использован текущий: {string.Join(", ", array)} ");

    string condition = Console.ReadLine()!;
    if (condition.ToLower() == "y")
    {
        string newString = string.Empty;
        Console.Write("Введите элементы массива через запятую: ");
        newString = Console.ReadLine()!;
        newString = newString.Replace(" ", "");  // убираю пробелы    
        array = newString.Split(","); //разделяю на массив строк        
    }
    return array;
}

string[] Cutting(string[] inputArray)
{
    int n = inputArray.Length;
    int count = 0; //количество подходящих элементов для выделения ячеек/памяти
    for (int i = 0; i < n; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            newArray[j] = inputArray[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]}" + ", ");
    }
}

void Main()
{
    Console.Clear();
    string[] array = Input();
    string[] resultArray = Cutting(array);
    PrintArray(resultArray);

}

Main();