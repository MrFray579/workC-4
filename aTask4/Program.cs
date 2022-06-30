/*Console.WriteLine("Введите число:");
int a  = Convert.ToInt32(Console.ReadLine());
int [] array = new int[a];

for (int i = 1; i <= a; i++)
{
    array[i - 1] = i * i;
    Console.Write(array[i -1] + ",");

}*/

/*Console.WriteLine("Введите число:");
int a  = Convert.ToInt32(Console.ReadLine());
int [] array = new int[a];
int i = 1;

while (i <= a)
{
    array[i - 1] = i * i;
    Console.Write(array[i -1] + ",");
    i++;

}*/

int[] calculed (int a)
{
    int[] num = new int[a];
    int i = 1;

    while(i <= a)
    {
        num[i - 1] = i * i;
        Console.Write(num[i -1] + ",");
        i++; 
    }
    return num;
}


int result = calculed (6);
