//using System.Diagnostics;

//namespace Les2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //string tempFile = Path.Combine(Path.GetTempPath(), "test.txt");
//            ////File.Create(tempFile);

//            //File.WriteAllText(tempFile, "Hello Notepad");

//            //Process.Start("notepad.exe", tempFile);
//            //Process.Start("notepad.exe");

//            //var process = Process.GetProcessesByName("notepad");

//            //Thread.Sleep(5000);

//            //foreach(var item in process)
//            //{
//            //    //Console.WriteLine(item.StartInfo.FileName);
//            //    item.Kill();
//            //    item.WaitForExit();
//            //    Console.WriteLine($"{item.ProcessName}");
//            //}

//            //Process.Start("notepad.exe");
//            //Process.Start("notepad.exe", "text.txt");
//            //Process.Start("notepad.exe", tempFile);

//            /*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

//            //var processes = Process.GetProcesses();
//            //foreach (var item in processes)
//            //{
//            //    Console.WriteLine($"Id - {item.Id}, Name - {item.ProcessName}");  
//            //}


//            //var processes = Process.GetProcesses().ToList().OrderBy(x => x.ProcessName);
//            //foreach (var item in processes)
//            //{
//            //    Console.WriteLine($"Id - {item.Id}, Name - {item.ProcessName}");
//            //}


//            //var processes = Process.GetProcesses().ToList();
//            //processes.Sort((p1, p2) => p1.ProcessName.CompareTo(p2.ProcessName)); //сортування через колекцію
//            //foreach (var item in processes)
//            //{
//            //    Console.WriteLine($"Id - {item.Id}, Name - {item.ProcessName}");
//            //}


//            //var processes = Process.GetProcesses()
//            //                       .OrderBy(x => x.ProcessName)
//            //                       .ToList();

//            //foreach (var item in processes)
//            //{
//            //    Console.WriteLine($"Id - {item.Id}, Name - {item.ProcessName}");
//            //}

//            /*------------------------------------------------------------------------------------------------------------------------------------------------------*/
//            //var processInfo = new ProcessStartInfo
//            //{
//            //    FileName = "ping",
//            //    Arguments = "google.com",
//            //    RedirectStandardOutput = true,
//            //    UseShellExecute = false,
//            //    CreateNoWindow = true,
//            //};

//            /////Process.Start(process);

//            //var process = Process.Start(processInfo);
//            //string output = process.StandardOutput.ReadToEnd();

//            //process.WaitForExit();
//            //Console.WriteLine(output);

//            /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

//            //var processInfo = new ProcessStartInfo
//            //{
//            //    FileName = "cmd.exe",
//            //    RedirectStandardOutput = true,
//            //    RedirectStandardInput = true,
//            //    UseShellExecute = false,
//            //    CreateNoWindow = true,
//            //};


//            //var process = Process.Start(processInfo);

//            //process.StandardInput.WriteLine("echo Hello from C#");
//            //process.StandardInput.WriteLine("exit");

//            //string output = process.StandardOutput.ReadToEnd();

//            //process.WaitForExit();
//            //Console.WriteLine(output);

//            /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

//            //var process = new Process();
//            //process.StartInfo.FileName = "notepad.exe";
//            //process.EnableRaisingEvents = true;

//            //process.Exited += (sender, e) =>
//            //{
//            //    //Console.WriteLine($"Sender - {sender.ToString}, Event - {e.ToString}");
//            //    Console.WriteLine("Program exited");
//            //};

//            //process.Start();

//            //for (int i = 0; i < 30; i++) 
//            //{ 
//            //    Thread.Sleep(1000);
//            //    Console.WriteLine(i);
//            //    if (i == 10)
//            //    {
//            //        process.Kill();
//            //    }
//            //}

//            //process.WaitForExit();
//            //Console.WriteLine("1111111111111111111");

              /*-----------------------------------------------------------------------------*/

            //string choice = Console.ReadLine();

            //var processInfo = new ProcessStartInfo
            //{
            //    FileName = "notepad.exe",
            //    RedirectStandardOutput = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = true
            //};

            //Console.WriteLine("\n1 Чекати завершення");
            //Console.WriteLine("2 Примусово завершити");
            //Console.WriteLine("\nведіть цифру обраного варінату : ");

            //var process = Process.Start(processInfo);

            //switch (choice)
            //{
            //    case "1":
            //        process.WaitForExit();
            //        Console.WriteLine($"Процес завершено");
            //        Console.WriteLine($"Код завершення: {process.ExitCode}");
            //        break;
            //    case "2":
            //        process.Kill();
            //        Console.WriteLine("Процес примусово завершено");
            //        break;
            //    default:
            //        Console.WriteLine("Невірний вибір");
            //        break;
            //}
//        }
//    }
//}
