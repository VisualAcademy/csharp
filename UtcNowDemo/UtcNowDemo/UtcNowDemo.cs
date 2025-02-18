using static System.Console;

class UtcNowDemo
{
    static void Main()
    {
        WriteLine("로컬 시간: " + DateTime.Now);
        WriteLine("UTC 시간: " + DateTime.UtcNow);
        WriteLine("UTC를 로컬 시간으로 변환: " + DateTime.UtcNow.ToLocalTime());

        WriteLine("UTC 시간: " + DateTimeOffset.UtcNow);
        WriteLine("UTC를 로컬 시간으로 변환: " + DateTimeOffset.UtcNow.ToLocalTime());

        WriteLine("로컬 시간: " + DateTimeOffset.Now.DateTime);
    }
}
