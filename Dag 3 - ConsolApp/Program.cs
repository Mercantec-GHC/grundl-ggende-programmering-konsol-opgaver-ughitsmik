Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "The result is: Heads!" : "The result is: Tails!");