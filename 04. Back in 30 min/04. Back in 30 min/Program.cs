int h = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int n = m + 30;

if (h >= 0 && h <= 23 && n >= 00 && n >= 59)
    {
        h++;
        n = n - 60;
    }

   if (h > 23)
    {
        h = 0;
    }
Console.WriteLine($"{h}:{n:d2}");
