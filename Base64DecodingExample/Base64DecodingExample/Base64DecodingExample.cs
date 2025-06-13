using System;
using System.Text;

class Base64DecodingExample
{
    static void Main()
    {
        string base64Encoded = "MTIzNDU2";

        // Base64 문자열을 바이트 배열로 디코딩한 후 UTF-8 문자열로 변환
        string decoded = Encoding.UTF8.GetString(
            Convert.FromBase64String(base64Encoded));

        Console.WriteLine($"디코딩된 문자열: {decoded}");
    }
}
