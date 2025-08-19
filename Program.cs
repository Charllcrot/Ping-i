// Pingüi
using System;
using System.Diagnostics;

public class Program
{

    public static string title = "Pingüi";
    public static int mssages = 0;
    public static string[] messages = {
        "Remember: 'sudo !!' repeats the last command as root",
        "You can search packages with 'apt search <package>'",
        "Did you know 'htop' is better than 'top' for monitoring processes?",
        "'chmod +x <file>' makes a script executable",
        "'man <command>' opens the manual for any command",
        "'df -h' shows disk space in a readable format",
        "'du -sh *' shows the size of each folder",
        "With 'alias ll=\"ls -la\"' you can create useful shortcuts",
        "Linux is free and you can always modify it as you like",
        "C# is like C++ but with more coffee",
        "Git commit or die trying",
        "rm -rf / is a joke, don't do it",
        "sudo make me a sandwich",
        "404: Humor not found",
        "Kernel panic! But just kidding",
        "I use Linux because Windows sends me to the trash",
        "The penguin can't fly, but you can learn Linux",
        "Linux has over 600 active distributions",
        "MyDoom was one of the most famous Windows viruses",
        "The penguin Tux was designed by Larry Ewing in 1996",
        "Supermassive black holes exist at the center of almost all galaxies",
        "The first Linux operating system was created by Linus Torvalds in 1991",
        "MinosPlus is an esoteric language, like Brainfuck but different, made by the creator. Here's the github: https://github.com/Charllcrot/MinosPlus",
        "Open source allows anyone to audit and improve the code",
        "Always believe in your soul, even if it's digital",
        "You are indestructible in the terminal!",
        "Don't underestimate the power of a penguin with sudo",
        "Errors are opportunities disguised as bugs",
        "If you don't know what to do, run 'man life'",
        "Remember: even the simplest scripts can change the world",
        "Winter is coming!"        
    };
    public static void Main(string[] args)
    {
        while (!Console.KeyAvailable)
        {
            mssages++;
            ShowInfoWindow(title, messages[new Random().Next(messages.Length)]);
            System.Threading.Thread.Sleep(new Random().Next(5000)); // Espera 5 segundos antes de mostrar la ventana nuevamente
            System.Console.WriteLine(mssages.ToString());
        }
    }

    public static void ShowInfoWindow(string title, string message)
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "zenity",
                Arguments = $"--info --title=\"{title}\" --text=\"{message}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al mostrar la ventana: {ex.Message}");
        }
    }
}
