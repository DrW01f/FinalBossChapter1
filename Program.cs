
string[] Input()
{
    string[] array = { "LastHomeWork", "123", "_", "456", "три", "efdhgrthsrh" };

    Console.WriteLine("Если хотите ввести новый массив нажмите Y");
    Console.Write("Иначе нажмите N будет использован текущий: ", array);
    string condition = Console.ReadLine()!;
    if (condition.ToLower()  == "y")
    {
        string newArray = string.Empty;
        Console.Write("Введите элементы массива через запятую");
        newArray = Console.ReadLine()!;
        newArray = newArray.Replace(" ", "");  // убираю пробелы
        array = newArray.Split(","); //разделяю на массив строк
    }
    return array;
}

string[] Cutting (string[] inputArray)
{
    int n = inputArray.Length;
    string[] newArray = {};
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if(inputArray[i].Length <=3)
        {
            newArray[j] = inputArray[i];
            j++;
        } 
    }
    return newArray;
}

void PrintArray(string[] array)
{
    int length = array.Length;
    
    for (int i = 0; i < length - 1; i++)
    {        
        Console.Write($"{array[i]}", ", ");        
    }
    Console.Write($"{array[length - 1]}");
}

void Main()
{
    Console.Clear();
    string[] array = Input();
    string[] resultArray = Cutting(array);
    PrintArray(resultArray);

}

Main();