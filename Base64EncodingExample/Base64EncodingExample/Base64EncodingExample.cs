using System;
using System.Text;

class Base64EncodingExample
{
    static void Main()
    {
        string originalText = "123456";

        // 문자열을 UTF-8 바이트 배열로 변환한 뒤 Base64로 인코딩
        string base64Encoded = 
            Convert.ToBase64String(Encoding.UTF8.GetBytes(originalText));

        Console.WriteLine($"원본 문자열: {originalText}");
        Console.WriteLine($"Base64 인코딩 결과: {base64Encoded}");
    }
}