using System.Collections.Generic;
using System.Timers;
using System;

namespace Tama.Models
{
  public class Pet
  {
    public static Timer _timer;
    public int Content { get; set; }
    public int Rested { get; set; }
    public int Fed { get; set; }

    public Pet(int content, int rested, int fed)
    {
      Content = content;
      Rested = rested;
      Fed = fed;
      StartTimer();
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
    public void StartTimer()
    {
      _timer = new System.Timers.Timer();
      _timer.Interval = 5000;
      _timer.Elapsed += DockPoints;
      _timer.AutoReset = true;
      _timer.Enabled = true;
    }
    public void DockPoints(Object source, System.Timers.ElapsedEventArgs e)
    {
      this.Content -= 1;
      this.Rested -= 1;
      this.Fed -= 1;
      if (this.Content < 0) { this.Content = 0; }
      if (this.Rested < 0) { this.Rested = 0; }
      if (this.Fed < 0) { this.Fed = 0; }
    }



  }
}
