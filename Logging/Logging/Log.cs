namespace Logging
{
    public class Log
    {
        public static void Log_Open(string filenameP) {
            string pathToFile = "/log.txt";
            File.AppendAllText(pathToFile, Environment.NewLine);
            File.AppendAllText(pathToFile, "Открыт файл: " + filenameP + " Дата: " + DateTime.Now.ToString("HH:mm:ss ") + DateTime.Now.ToString("dd MMMM yyyy"));
        }
        public static void Log_Save(string filenameP)
        {
            string pathToFile = "/log.txt";
            File.AppendAllText(pathToFile, Environment.NewLine);
            File.AppendAllText(pathToFile, "Сохранён файл: " + filenameP + " Дата: " + DateTime.Now.ToString("HH:mm:ss ") + DateTime.Now.ToString("dd MMMM yyyy"));
        }

    }
}