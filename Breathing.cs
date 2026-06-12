using System.Reflection.Metadata.Ecma335;

public class Breathing: Activity
{
    private int jbBreatheDuration = 5;
    DateTime jbstartingtime = DateTime.Now;
    DateTime jbbreathing = jbstartingtime.AddSeconds(5);
    int jbbreathe = int.Parse(jbbreathing);


 private void BreathingActivity(int jbbreatheduration)
    {
        {
        while (jbBreatheDuration/5 >0)
        Console.Clear();
        Console.WriteLine ("Breathe In.");
        Console.Clear();
        Console.Write (5);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (4);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (3);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (2);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (1);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (0);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write ("Breathe Out");
        Console.Clear();
        Console.Write ("/b /b");
        Console.Write (5);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (4);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (3);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (2);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (1);
        Thread.Sleep(1000);
        Console.Write ("/b /b");
        Console.Write (0);
        Thread.Sleep(1000);
        Console.Write ("/b /b");

    }
    Console.Clear();
    }   
}


