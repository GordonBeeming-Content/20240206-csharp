OtherCode.StartSomeWork();
if (OtherCode.IsTheWorkComplete())
{
  Console.WriteLine("Work is complete");
  return;
}
Console.WriteLine("Working...");
Thread.Sleep(1000);

if (OtherCode.IsTheWorkComplete())
{
  Console.WriteLine("Work is complete");
  return;
}
Console.WriteLine("Working...");
Thread.Sleep(1000);