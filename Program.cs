using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Unicode;
using System.Text.Encodings.Web;

using practic_8;


HttpClient http = new HttpClient();
string api = "https://seadox.ru/api/seadocs";


var options = new JsonSerializerOptions
{
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
    WriteIndented = true
};

Console.Write("id: ");
string id = Console.ReadLine()!;

var request = await http.GetAsync($"{api}/{id}");

var json = JsonNode.Parse(await request.Content.ReadAsStringAsync());

var result = JsonSerializer.Deserialize<Information>(json);

result.ShowInformation();

