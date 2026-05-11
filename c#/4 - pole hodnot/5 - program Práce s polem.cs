decimal[] pole = new decimal[45];

pole[0] = 1;
pole[1] = 2;

for (int i = 2; i < pole.Length; i++)
{
    pole[i] = pole[i - 1] + pole[i - 2];
}

foreach (decimal cislo in pole)
{
    Console.Write(cislo + " ");
}
