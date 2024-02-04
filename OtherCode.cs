public static class OtherCode
{
  public static DateTime StartTime { get; set; } = DateTime.UtcNow;

  public static bool IsTheWorkComplete()
  {
    return DateTime.UtcNow - StartTime > TimeSpan.FromSeconds(5);
  }

  public static void StartSomeWork()
  {
    StartTime = DateTime.UtcNow;
  }
}