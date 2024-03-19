int n = 5;
int[] array = { 12, 9, 17, 58, 19 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[i] > max)
    {
        max = array[j];
    }

}
Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}

Console.WriteLine(max);