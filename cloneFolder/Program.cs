using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string sourceDirectory = @"C:\Users\joao.oliveira\Downloads\Nova pasta"; 
        string targetDirectory = @"C:\Users\joao.oliveira\Downloads\en-US";

        Copy(sourceDirectory, targetDirectory);
    }

    private static void Copy(string sourceDirectory, string targetDirectory)
    {
        DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
        DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

        CopyAll(diSource, diTarget);
    }

    private static void CopyAll(DirectoryInfo source, DirectoryInfo target)
    {
        foreach (DirectoryInfo dir in source.GetDirectories())
        {
            DirectoryInfo nextTargetSubDir =
            target.CreateSubdirectory(dir.Name);
            CopyAll(dir, nextTargetSubDir);
        }
    }
}