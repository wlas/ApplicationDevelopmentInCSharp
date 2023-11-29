namespace HomeWork
{
    public class SearcheFile
    {
        public static void SearchFile(string directory, string fileName)
        {
            var files = Directory.EnumerateFiles(directory, fileName, SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine($"Искомый файл {fileName} находится по пути: {file}");
            }
        }

        public static void SearchValue(string fileName, string searchValue)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(searchValue))
                        {
                            Console.WriteLine($"Найдено значение {searchValue} в файле {fileName}: {line}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
        }
    }
}
