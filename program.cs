int k = 0, j = 0, n;

n = Convert.ToInt32(Console.ReadLine());

string[] a = new string[n];
string[] b = new string[n];

for (int i = 0; i < a.Length; i++)
{
    a[i] = Console.ReadLine();
    j++;
}

for(int i = 0; i < j; i++)
{
    if (a[i].Length <= 3)
    {
        b[k] = a[i];
        k++;
    }
    else
    {
        continue;
    }
}

for(int i = 0; i < k; i++)
{
    Console.WriteLine("b[" + i + "]=" + b[i]);
}