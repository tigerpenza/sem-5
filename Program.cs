// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.


// int [] CreateRandomArray (int size, int minvalue, int maxValue)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     newArray [i] = new Random().Next (minvalue, maxValue + 1);
//     return newArray;


// }

// void ShowArray (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)

//     Console.WriteLine (array [i] + " ");        
//     Console.WriteLine ( );          // не дописал 
// }


// int FindPositivSum(int [] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
    
//         if ( array[i] > 0) sum += array [i];   // sum = sum + a 
//         return sum;

    
// }

// int FindNegativSum(int [] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
    
//         if ( array[i] < 0) sum += array [i];   
//         return sum;

    
// }

// Console.Write("введите размер массива" );  
// int size = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите мин возможное значние " );  
// int min = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите макс  возможное значние" );  
// int max = Convert.ToInt32 ( Console.ReadLine());

// int[] myArray = CreateRandomArray (size, min , max);
// ShowArray (myArray);
//  int positivesum = FindPositivSum (myArray);
//  int negativsum = FindNegativSum (myArray);

//  Console.WriteLine  ($"сумма положительный {positivesum} \n сумма отрицательный элементов {negativsum}" );






// ЗАДАЧИ В ЗАЛАХ 





//  ЗАДАЧА 1 Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// возмем массик перевернет элементы и вернет обратно массив 


// int [] CreateRandomArray (int size, int minvalue, int maxValue)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     newArray [i] = new Random().Next (minvalue, maxValue + 1);
//     return newArray;


// }

// void ShowArray (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)

//         Console.WriteLine (array [i] + " ");        
//         Console.WriteLine ( );           
// }

// int FindReverse (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//      array[i] *=(-1);

// return array;
// }

// int size = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите мин возможное значние " );  
// int min = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите макс  возможное значние" );  
// int max = Convert.ToInt32 ( Console.ReadLine());

// int [] myArray = CreateRandomArray (size, min, max);

// ShowArray (myArray);

// int [] ReverseArray = FindReverse (array);

// ShowArray (ReverseArray);









// ЗАДАЧА 2 Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// берем на вход массив и заданое число некоторое (2 аргумента ) возвращать bool =  да или нет  ( истина или ложь )


// int [] CreateRandomArray (int size, int minvalue, int maxValue)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     newArray [i] = new Random().Next (minvalue, maxValue + 1);
//     return newArray;


// }

// void ShowArray (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
// }
//         Console.WriteLine (array [i] + " ");        
//     Console.WriteLine ( );      

//     bool ServegeNum (int [] array, int num)
//     {

//     for (int i = 0; i < size; i++);
//     if (array [i] == num)
//     {

//         return true;
//     }
//      return false;

//     }


// int size = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите размер массива  " );  
// int size = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите мин возможное значние " );  
// int min = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите макс  возможное значние" );  
// int max = Convert.ToInt32 ( Console.ReadLine());

// int number = Convert.ToInt32 ( Console.ReadLine())

// Console.Write("введите число");  

// int [] myArray = CreateRandomArray (size, min, max);

// ShowArray (myArray);
// Console.Write ($ " искомое число {number} {ServegeNum (myArray, number) " );  







// ЗАДАЧА 3 Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// необходимо написать метод который посчитаем колличество двухзначных чисел в массиве 


// int [] CreateRandomArray (int size, int minvalue, int maxValue)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     newArray [i] = new Random().Next (minvalue, maxValue + 1);
//     return newArray;


// }

// void ShowArray (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)

//         Console.WriteLine (array [i] + " ");        
//         Console.WriteLine ( );         
// }

// int Poisk (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
// }


// КОНЕЦ СЕССИИ В ЗАЛЕ !



// NextDouble() от 0 до 1  создает генерирует число 
// сгенерировать вещ число как сумму 
