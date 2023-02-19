
Console.Write("Введите сумму вклада: ");
decimal vkladSum = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите количество лет: ");
int yearCount = Convert.ToInt32(Console.ReadLine());
 
int x = 1;
 
while (x <= yearCount)
{
  if (vkladSum < 100)
  {
    vkladSum = vkladSum + (vkladSum * (decimal)0.05);
  }
  if ((vkladSum > 100) && (vkladSum < 200))
 {
    vkladSum = vkladSum + (vkladSum * (decimal)0.07);
  }
  if (vkladSum > 200)
  {
        vkladSum = vkladSum + (vkladSum * (decimal)0.1);
  }
 
  x++;
}
 
Console.WriteLine("Cумма вклада с начисленными процентами за {0} лет составит: {1}", yearCount, vkladSum);


