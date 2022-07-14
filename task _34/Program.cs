//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


void array(){
    Console.Write("введите число элементов массива: ");
    int array_size = Convert.ToInt32(Console.ReadLine());
    int[] array1 = new int [array_size];
    for (int i = 0; i < array1.Length; i++){
        array1[i] = new Random().Next(100, 999);
    } 
    int count = 0;
    for (int i = 0; i < array1.Length; i++){
        if (array1[i] % 2 == 0) count++;
    }
    Console.WriteLine("Array: [{0}]", string.Join(", ", array1));
    Console.WriteLine($"In array {count} количество положительных чисел");
}
array();
Console.WriteLine();