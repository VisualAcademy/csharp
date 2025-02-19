using System.Text.Json;

public class Shirt
{
    public string? Name { get; set; }
    public DateTime Created { get; set; }
    public List<string>? Sizes { get; set; }
}

public class JsonSerializerDemo
{
    static void Main()
    {
        //[1] 직렬화(Serialize) 데모
        Shirt shirt1 = new Shirt
        {
            Name = "Red Shirt",
            Created = new DateTime(2025, 03, 01),
            Sizes = new List<string> { "Small" }
        };
        string json1 = JsonSerializer.Serialize(shirt1);
        Console.WriteLine(json1);

        //[2] 역직렬화(Deserialize) 데모: 축자 문자열 리터럴로 큰 따옴표를 포함한 JSON 표현 
        string json2 = @"{
            ""Name"": ""Black Shirt"",
            ""Created"": ""2025-12-31T00:00:00"",
            ""Sizes"": [""Large""]
        }";
        Shirt? shirt2 = JsonSerializer.Deserialize<Shirt>(json2);
        Console.WriteLine($"{shirt2!.Name} - {shirt2.Created}");
    }
}
