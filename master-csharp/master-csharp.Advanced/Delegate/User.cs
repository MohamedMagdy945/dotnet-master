using System;
using System.Collections.Generic;

class User
{
    delegate void Notify(string message);

    public void NotifyUsers()
    {
        string userName = "Ahmed";
        int counter = 0;

        Notify consoleNotify = (msg) =>
        {
            counter++;
            Console.WriteLine($"[Console] To {userName}: {msg} (Count: {counter})");
        };

        Notify fileNotify = (msg) =>
        {
            Console.WriteLine($"[File] Log: {msg}");
        };

        Notify emailNotify = SendEmail;

        Notify allNotify = consoleNotify + fileNotify + emailNotify;

        allNotify("Welcome to our system!");

        Console.WriteLine();

        userName = "Sara";
        allNotify("You have new messages!");
    }

    static void SendEmail(string msg)
    {
        Console.WriteLine($"[Email] Sending email: {msg}");
    }
}
public class DelegateUsage
{
    public static void Test()
    {
        User u1 = new User();
        u1.NotifyUsers();
    }
}