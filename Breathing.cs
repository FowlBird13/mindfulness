using System.Reflection.Metadata.Ecma335;

public class Breathing: Activity
{
     private double duration;
     DateTime jbstartingtime = DateTime.Now;
     DateTime jbbreathing = jbstartingtime.AddSeconds(duration);
     private int jbbreathe = int.Parse(jbbreathing);
   
     private int jbbreatheduration = jbbreathe;
     private void BreathingActivity(int jbbreatheduration)
    {
        {
        while (jbbreatheduration/5 >0)
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


