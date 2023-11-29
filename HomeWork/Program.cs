namespace HomeWork
{
    class Program
    {
        /*
            Объедините две предыдущих работы (практические работы 2 и 3): поиск файла и поиск текста в файле написав 
            утилиту которая ищет файлы определенного расширения с указанным текстом. Рекурсивно. Пример вызова утилиты: utility.exe txt текст.
        */
        static void Main(string[] args)
        {
            string directory = "222";
            string fileName = "1.txt";
            string pathFile = Path.Combine(directory, fileName);
            string searchValue = "искомый_текст";

            SearcheFile.SearchFile(directory, fileName);
            SearcheFile.SearchValue(pathFile, searchValue);
        }        
    }
}