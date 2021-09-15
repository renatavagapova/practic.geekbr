using System;
using System.Linq;
using System.Diagnostics;

namespace lesson6._1
{
    class Program
    {
        //завершение процесса
        static void StopProcess ()
        {
            Console.WriteLine("Введите ID процесса, который нужно будет удалить");
            string id = Console.ReadLine();
            Process myProc = null;
            try
            {
                int i = int.Parse(id);
                myProc = Process.GetProcessById(i);
                myProc.Kill();
                Console.WriteLine("Процесс удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            //Получение списка запущенных процессов
            var allProcess = from pr in Process.GetProcesses(".")
                             select pr;
            int i = 0;
            foreach (var proc in allProcess)
            {
                i++;
                string inf = string.Format(@"-->{0}: 
    ID: {1}
    Process name: {2}
", i, proc.Id,  proc.ProcessName);
                Console.Write(inf);
            }
            Console.ReadLine();
            StopProcess();
            
            Console.WriteLine("Создадим новый процесс, чтобы показать удаление указанного процесса)");
            Process notepad = Process.Start("notepad.exe");
            Console.WriteLine("Нажмите любую клавишу для завершения процесса");
            Console.ReadKey();
            notepad.Kill();
            Console.WriteLine(notepad.ExitCode);
        }
    }
}
