using Newtonsoft.Json;
using System.Xml.Serialization;

namespace USTALYAAA
{
    public class Class1
    {
        public void S(string text)
        {
            string json = JsonConvert.SerializeObject(text);
            File.WriteAllText("C:\\Users\\mazmm\\JsonPract.json", json);

        }
        public string D()
        {
            string text = File.ReadAllText("C:\\Users\\mazmm\\JsonPract.json");
            string jstext = JsonConvert.DeserializeObject<string>(text);
            return jstext;

        }

    }
}
