

//finding duplicates in array

//int [] array = { 3,30, 8,5,5,5, 1,3, 5 ,3 ,320 };

// List<int> duplicates = new List<int>();

//for(int i = 0; i < array.Length; i++)
//{
//    for(int j =i+1; j < array.Length; j++)
//    {
//        if (array[i] == array[j])
//        {
//            if (!duplicates.Contains(array[i]))
//            {
//                duplicates.Add(array[j]);
//            } 
//        }

//    }

//}

//foreach (var item in duplicates)
//{
//    Console.WriteLine(item);
//}




// Buble Sort Algorithm

int[] Array = { 30, 8, 5, 5, 5, 1, 3, 5, 3, 320 };

Console.WriteLine("Before swapping:");
printArray(Array);

for (int i = 0; i < Array.Length - 1; i++)
{
    for (int j = 0; j < Array.Length - i - 1; j++)
    {
        if (Array[j] > Array[j + 1])
        {
            int temp = Array[j];
            Array[j] = Array[j + 1];
            Array[j + 1] = temp;

        }
    }
}
Console.WriteLine("After swap:");
printArray(Array);

static void printArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine(); // For new line after printing array
}



