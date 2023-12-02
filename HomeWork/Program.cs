using System.Text.Json;
using System.Xml;

namespace HomeWork
{
    class Program
    {
        /* 
            Напишите приложение, конвертирующее произвольный JSON в XML. Используйте JsonDocument.
        */
        static void Main(string[] args)
        {
            string jsonData = "{\"VDD\": 44,\"REAL\": 0,\"Perem\": 1,\"ID\": \"_6QI0HB878014\",\"ND\": \"31426\",\"DD\": \"2023-10-16T00:00:00\",\"ORGANIZ\": 1,\"ORG_1C\": \"000002575\",\"CM_1C\": \"00000057345\"}";

            // Конвертирование JSON в XML
            var xmlData = ConvertJsonToXml(jsonData);

            // Сохраняем XML документ в файл
            xmlData.Save("output.xml");

            // Вывод результата
            Console.WriteLine(xmlData.OuterXml);
        }

        static XmlDocument ConvertJsonToXml(string jsonData)
        {
            // Парсинг JSON
            JsonDocument jsonDoc = JsonDocument.Parse(jsonData);

            // Создание XML-документа с корневым элементом "root"
            var xmlDoc = new XmlDocument();
            var rootElement = xmlDoc.CreateElement("root");
            xmlDoc.AppendChild(rootElement);

            // Рекурсивное добавление элементов в XML
            ParseJson(xmlDoc, rootElement, jsonDoc.RootElement);

            // Преобразование XML в строку
            return xmlDoc;
        }

        static void ParseJson(XmlDocument xmlDoc, XmlNode parentNode, JsonElement jsonElement)
        {
            switch (jsonElement.ValueKind)
            {
                case JsonValueKind.Object:
                    foreach (var property in jsonElement.EnumerateObject())
                    {
                        var subElement = xmlDoc.CreateElement(property.Name);
                        parentNode.AppendChild(subElement);
                        ParseJson(xmlDoc, subElement, property.Value);
                    }
                    break;
                case JsonValueKind.Array:
                    int index = 1;
                    foreach (var item in jsonElement.EnumerateArray())
                    {
                        var subElement = xmlDoc.CreateElement("item");
                        parentNode.AppendChild(subElement);
                        ParseJson(xmlDoc, subElement, item);
                        index++;
                    }
                    break;
                default:
                    parentNode.InnerText = jsonElement.ToString();
                    break;
            }
        }
    }
}