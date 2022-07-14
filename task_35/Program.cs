/* Задача 36: Задайте одномерный массив, заполненный случайными числами
 Найдите сумму элементов, стоящих на нечётных позициях */

void negArray(){
    
    int[] array = new int [6];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(1,100);
    } 
    int negSum = 0;
    for (int i = 1; i < array.Length; i = i + 2){
        negSum += array[i];
    }
    Console.WriteLine("Array: [{0}]", string.Join(", ", array));
    Console.WriteLine($"сумма нечетных элементов {negSum}.");
}

negArray();
Console.WriteLine();