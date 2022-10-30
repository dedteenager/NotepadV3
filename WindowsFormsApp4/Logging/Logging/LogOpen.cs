using System.IO;

namespace Logging
{
    public class LogOpen
    {
     void openLogging()
        {
            string pathToFile = "/log.txt";
            File.AppendAllText(pathToFile, Environment.NewLine);
            File.AppendAllText(pathToFile, "Открыт файл: " + openFileDialog1.FileName + " Дата: " + DateTime.Now.ToString("dd MMMM yyyy ") + DateTime.Now.ToString("HH:mm:ss"));
        }

        void saveLogging()
        {
            string pathToFile = "/log.txt";
            File.AppendAllText(pathToFile, Environment.NewLine);
            File.AppendAllText(pathToFile, "Сохранён файл: " + saveFileDialog1.FileName + " Дата: " + DateTime.Now.ToString("HH:mm:ss ") + DateTime.Now.ToString("dd MMMM yyyy"));
        }
    }
}