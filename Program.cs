// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int [] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int CountHet(int []array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         // проверка на четность, если четное - добавляем в переменную "count"
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }

// Console.WriteLine("Ведите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число от 100 до 999: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число от 100 до 999: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);
// int сountHet = CountHet(array);
// Console.WriteLine();
// Console.WriteLine($"Колличество четных чисел в массиве = {сountHet} шт." );


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int [] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int SumNeg(int []array){
//     int sumneg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         // проверка на нечетность, если индекс нечетный - прибавляем число в переменную "sumneg"
//         if (i % 2 != 0) sumneg += array[i];
        
//     }
//     return sumneg;
// }

// Console.WriteLine("Ведите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число : ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число : ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);
// int sumneg = SumNeg(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {sumneg}." );


// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// int [] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int MaxMin(int []array){
//     int min = array[0];
//     int max = array[0];
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min){ 
//             min = array[i];
//         }
//         else 
//             max = array[i];  
//         result = max - min;     
//     }
//     return result;
// }

// Console.WriteLine("Ведите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число : ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число : ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);
// int maxmin = MaxMin(array);
// Console.WriteLine();
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {maxmin}." );



