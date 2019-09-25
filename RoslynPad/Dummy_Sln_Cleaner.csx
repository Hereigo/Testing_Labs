using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

private static int count = 0;
private static string[] searchedDirs = { "BIN", "OBJ", "BUILD", "PACKAGES" };
try
{
    string rootDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    string[] projectsDirs = {
    $"{rootDir}\\repos\\",
    };

    for (int i = 0; i < projectsDirs.Length; i++)
    {
        Del_Bin_Obj_Build_Packg(projectsDirs[i].Trim());
        Console.WriteLine($"{i + 1}. Folders Deleted : {count}");
        count = 0;
        ProcessStartInfo psi = new ProcessStartInfo { 
            FileName = @"C:\Program Files\7-Zip\7zG.exe",
            Arguments = $"a -mx -r -x!.git -x!.vs {rootDir}\\Arch.7z {projectsDirs[i]}"
        };
        Process process = Process.Start(psi);
        process.WaitForExit();
        Console.WriteLine($"{i + 1} done.");
    }
}
catch (Exception exc)
{
    Console.WriteLine(exc.Message);
}
Console.WriteLine("\r\n Finished.");

private static void Del_Bin_Obj_Build_Packg(string currRootDir)
{
    foreach (string everyDir in Directory.GetDirectories(currRootDir))
    {
        if (Directory.Exists(everyDir))
        {
            Del_Bin_Obj_Build_Packg(everyDir);

            if (searchedDirs.Contains(Path.GetFileName(everyDir).ToUpper()))
            {
                Directory.Delete(everyDir, true);
                count++;
            }
        }
    }
}