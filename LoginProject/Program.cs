using System;
using System.Diagnostics;

public class LoginTest
{
    public static void Main(string[] args)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
          UseShellExecute = false,
          WorkingDirectory =  Directory.GetParent(Directory.GetCurrentDirectory()).FullName,
          WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden, FileName = "cmd.exe",
          RedirectStandardInput = true,
          RedirectStandardOutput = true
        };

        Process process = new Process { StartInfo = startInfo };

        Console.WriteLine("Iniciando Testes Cypress");

        process.Start();

        process.StandardInput.WriteLine($"npx cypress run & exit");
        string output = process.StandardOutput.ReadToEnd();
        Console.WriteLine(output);

        process.WaitForExit();

        Console.WriteLine("Testes Finalizados");
    }
}

