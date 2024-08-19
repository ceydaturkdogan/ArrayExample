
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


for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = 0; j < array.Length - 1 - i; j++)
    {
        if (array[j] < array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}

foreach (int item in array)
{

Console.WriteLine(item); 
}
