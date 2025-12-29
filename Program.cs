using System.Net.Http.Json;
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
    WriteIndented = true,
    PropertyNameCaseInsensitive = true
};

Console.Write("id: ");
string id = Console.ReadLine()!;

var result = await http.GetFromJsonAsync<Information>($"{api}/{id}");

result.ShowInformation();

