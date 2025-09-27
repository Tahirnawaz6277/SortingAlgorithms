

//finding duplicates in array v1

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

// //finding duplicates in array v2
 //int [] array = { 3,30, 8,5,5,5, 1,3, 5 ,3 ,320 };

// for(int i = 0; i < array.Length-1;i++){
//     for(int j = i+1;j<array.Length-1;j++){
//         if(array[i] == array[j]){
//            Console.WriteLine("duplicated element:",array[i]);
//         }
//     }
// }


// //reverse array without using builtin functions
// //int [] array = { 3,30, 8,5,5,5, 1,3, 5 ,3 ,320 };

// for(int i = array.Length-1; i >= 0;i--){
//     Console.WriteLine("print array in reverse order :",array[i]);   
// }





// Buble Sort Algorithm, Its Time Complexity is O(n²)

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
    Console.WriteLine();
}


// //Selection sort Algorithm, Its Time Complexity O(n²)
//  int [] array = { 3,30, 8,5,5,5, 1,3, 5 ,3 ,320 };

// for(int i = 0; i < array.Length-1; i++){
//        int smallestIndex = i;
//     for(int j = i+1; j<array.Length; j++){
//         if(array[j] < array[smallestIndex]){
//             smallestIndex = j;
//         }    
//     }
//   // Swap the found minimum element with the first element
// int temp =  array[i]; 
//  array[i] = array[smallestIndex];
//  array[smallestIndex] = temp;
// }

//ref and out usage:
//In C#, ref and out keywords are used to pass arguments by reference, allowing a method to modify the original variable passed from the calling code. 

  //Using out:
        //Declaration: Declare the parameter in the method signature with the out keyword.
             static void GetNewValueOut(out int outn)
            {
                outn = 10; // Must assign a value before the method returns
            }
        //Calling: When calling the method, the argument passed can be uninitialized, but it must be preceded by the out keyword.
        int outn; // No initialization required
        GetNewValueOut(out outn);
           Console.WriteLine (outn); // outn is now 10

        //Purpose: Use out when a method is intended to assign a new value to a variable, The method must assign a value to the out parameter before it returns.


        // Using ref:
      //Declaration: Declare the parameter in the method signature with the ref keyword.
        
        static void UpdateExistingValueRef(ref string refn)
        {
            refn = "29"; // Modifies the original 'refn'
        }
        
        //Calling: When calling the method, the argument passed must be initialized and also preceded by the ref keyword.
        string refn = "100";
        UpdateExistingValueRef(ref refn);
         Console.WriteLine (refn); // refn is now "29"
         
         //Purpose: Use ref when you want a method to potentially modify an existing, initialized variable.






