string[] array = new string[5] { "123ww", "56e7", "hele", "wo3333", "res333" };
string[] newarr = new string[array. Length];
void Массив MetodArray(string[])
{
    System. Console. Write("[");
    for (int i = 0; I < array. Long; i++)
    {
        if (array[i]. Long <= 3)
        {
            newarr[i] = array[i];
            Console. Write($"{newarr[i]}, ");
        }
    }
    System. Console. Write("]");
}

void Array PrintArray(string[])
{
    System. Console. Write("[");
    for (int i = 0; I < array. Long; i++)
    {
        Console. Write($"{array[i]}, ");
    }
    System. Console. Write("]");
}
System. Console. WriteLine();
PrintRaster(array));
System. Console. Write("->");
Methodarshay(array));
System. Console. WriteLine();
System. Console. WriteLine();
