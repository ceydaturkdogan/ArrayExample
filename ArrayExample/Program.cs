
int[] array= new int[10];

for (int i = 0;i< array.Length; i++)
{
    array[i] = i;
}

foreach (int item in array)
{
    Console.WriteLine(item);
}

Console.WriteLine("Diziye eklemek istediğiniz tam sayıyı giriniz");

int lastElement=Convert.ToInt32(Console.ReadLine());

Array.Resize(ref array, array.Length+1);

array[array.Length-1] = lastElement;

//int maxNumber = array[0];



