string[] DataArray(string str)
{
    Console.WriteLine(str);
    str = Console.ReadLine();
    char[] separators = new char[] { ',', ' ' };
    string[] subs = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return subs;
}
string[] ArrayFormation(string[] array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            length += 1;
    }
    string[] arr = new string[length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[count] = array[i];
            count+=1;
        }
    }
    return arr;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write($"{array[i]}");
        else
            Console.Write($"{array[i]}, ");
    }
    Console.Write($"]");
}
string[] result = DataArray("Введите массив строк через запятую или пробел:");
string[] result1 = ArrayFormation(result);
PrintArray(result);
PrintArray(result1);