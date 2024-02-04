OtherCode.StartSomeWork();
while (!OtherCode.IsTheWorkComplete())
{
  Console.WriteLine("Working...");
  Thread.Sleep(1000);
}
Console.WriteLine("Work is complete");