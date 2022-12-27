/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */




// void ThreeCharWordInArray (string[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int array_size = 0;
//         for (int j = 0; j < array[i].Length; j++)
//             {
//                 array_size = array_size + 1;
//             }
//         {
//             if (array_size <= 3)
//             {
//                 Console.WriteLine($"The word consisting of 3 chars is {array[i]}");
//             }
//         }
//     }
// }

// string[] new_array = {Hello, 2, world, :-)”};
// ThreeCharWordInArray(new_array);