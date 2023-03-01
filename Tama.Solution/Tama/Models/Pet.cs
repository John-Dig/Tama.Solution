using System.Collections.Generic;
using System.Threading;
namespace Tama.Models
{
  public class Pet
  {
    public int Content { get; set; }
    public int Rested { get; set; }
    public int Fed { get; set; }

    public Pet(int content, int rested, int fed)
    {
      Content = content;
      Rested = rested;
      Fed = fed;
    }

    public void Play()
    {
      this.Content += 10;
    }

    public void Feed()
    {
      this.Fed += 10;
    }

    public void Sleep()
    {
      this.Rested += 10;
    }

    public void Timer()
    {
      this.Content -= 1;
      this.Rested -= 1;
      this.Fed -= 1;
    }
  }
}

using System;
using System.Threading;

class Program {
    static void Main(string[] args) {
        Timer timer = new Timer(MyCallback, null, TimeSpan.Zero, Timeout.InfiniteTimeSpan);

        // Wait for the timer to finish
        Console.ReadLine();
    }

    static void MyCallback(object state) {
        Console.WriteLine("Timer callback executed at {0}", DateTime.Now);

        // Restart the timer
        Timer timer = (Timer) state;
        timer.Change(TimeSpan.FromSeconds(5), Timeout.InfiniteTimeSpan);
    }
}
