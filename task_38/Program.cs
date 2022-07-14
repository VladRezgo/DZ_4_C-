// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void difArray(){
    Console.Write("введите кол-во элементов массива: ");
    int array_size = Convert.ToInt32(Console.ReadLine());
    int[] array1 = new int[array_size];
    for (int i = 0; i < array1.Length; i++){
        array1[i] = new Random().Next(1,100);
    } 
    int max = array1[0];
    int min = array1[0];
    for (int i = 0; i < array1.Length; i++){
        if (array1[i] < min){
            min = array1[i];
        }else if (array1[i] > max){
            max = array1[i];
        }
    }
    Console.WriteLine("Array: [{0}]", string.Join(", ", array1));
    Console.WriteLine($"разница между максимальным и минимальным = {max-min}");
}
difArray();
Console.WriteLine();