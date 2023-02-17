// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//  меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//   выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
using static System.Console;
Clear();


Write("Введите колличество элементов: ");

int size = Convert.ToInt32(ReadLine());

string[] firstArray = new string[size];
string[] secondArray = new string[size];
int length = 3;
int position = 0;

for (int i = 0; i < size; i++)
{
   WriteLine($"Введите {i + 1}-й элемент: ");
   string element = Convert.ToString(ReadLine());
   firstArray[i] = element;

}

for (int j = 0; j < size; j++)
{
   if (firstArray[j].Length <= length)
   {
      secondArray[position] = firstArray[j];
      position++;
   }
}

void PrintArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Write($"{array[i] + " "}");
   }
   WriteLine();
}
WriteLine();
PrintArray(secondArray);