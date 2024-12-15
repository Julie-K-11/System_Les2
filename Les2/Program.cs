using System;
using System.Diagnostics;

namespace Les2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }

        static void Task1()
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = "notepad.exe",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = Process.Start(processInfo);
            process.WaitForExit();
            Console.WriteLine("Програма закрита");
        }

        static void Task2()
        {
            Console.WriteLine("\nВведіть назву програми для запуску:");
            string processName = Console.ReadLine();

            Process process = Process.Start(processName);

            Console.WriteLine("\n1 - Чекати завершення");
            Console.WriteLine("2 - Примусово завершити");
            Console.WriteLine("\nВведіть цифру обраного варінату : ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    process.WaitForExit();
                    Console.WriteLine("Процес завершено");
                    break;
                case "2":
                    process.Kill();
                    Console.WriteLine("Процес примусово завершено");
                    break;
                default:
                    Console.WriteLine("Невірний вибір");
                    break;
            }

        }

        static void Task3()
        {
            Console.WriteLine("\nВведіть перше число:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Введіть друге число:");
            string num2 = Console.ReadLine();

            Console.WriteLine("Введіть дію над числами:");
            string operation = Console.ReadLine();

            Console.WriteLine();

            string command = $"set /a result={num1}{operation}{num2}";
            string filePath = "result.txt";

            var processInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C {command} > \"{filePath}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = Process.Start(processInfo);
            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine($"Результат записано в файл: {filePath}");
            Process.Start("notepad.exe", filePath);
        }

        static void Task4()
        {
            Console.WriteLine("\nВведіть шлях до файлу:");
            string filePath = Console.ReadLine();

            Console.WriteLine("Введіть слово для пошуку:");
            string word = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не знайдено");
                return;
            }

            var processInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C findstr /I /C:\"{word}\" \"{filePath}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = Process.Start(processInfo);
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string fileContent = File.ReadAllText(filePath);
            int count = CountWord(fileContent, word);

            Console.WriteLine($"Слово '{word}' зустрічається {count} разів");
        }

        static int CountWord(string text, string word)
        {
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(word, index)) != -1)
            {
                count++;
                index += word.Length;
            }

            return count;
        }
    }
}
