using System;

public class Activity
{
    private string _GBname;
    private string _GBdescription;
    private int _GBduration;

    public Activity()
    {
        _GBname = "No name";
        _GBdescription = "No description";
        _GBduration = 0;
    }
    public Activity(string name, string description)
    {
        _GBname = name;
        _GBdescription = description;
        _GBduration = 0;
    }
    public Activity(string name, string description, int duration)
    {
        _GBname = name;
        _GBdescription = description;
        _GBduration = duration;
    }

    public void setName(string name)
    {
        _GBname = name;
    }
    public void setDescrip(string description)
    {
        _GBdescription = description;
    }
    public void setDuration(int duration)
    {
        _GBduration = duration;
    }
    public string getName()
    {
        return _GBname;
    }
    public string getDescrip()
    {
        return _GBdescription;
    }
    public int getDuration()
    {
        return _GBduration;
    }

    public void beginMsg()
    {
        Console.WriteLine($"Welcome to the {_GBname} Activity.");
        Console.WriteLine(_GBdescription);
    }
    public void endMsg()
    {
        Console.WriteLine("Well done!!");
        DisplaySpinner(3);
        Console.WriteLine($"You have completed another {_GBduration} seconds of {_GBname} Activity.");
        DisplaySpinner(3);
    }
    public void userSetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like your session?");
        _GBduration = int.Parse(Console.ReadLine());
    }
    public void DisplayCountdown(int duration)
    {
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(duration);
        while (now < future)
        {
            Console.WriteLine(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration --;

        }
    }
    public void DisplaySpinner(int duration)
    {
        string[] spinner = new string[]
        {"|", "/","⟋", "—","⟍", @"\"};
        
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(duration);
        int i = 0;
        while (now < future)
        {
            Console.WriteLine(spinner[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i ++;
            if (i >= 5)
            {
                i = 0;
            }

        }    }
    public void clearConsole()
    {
        
    }
}