using System.Collections.Generic;

namespace Tama.Models
{
  public class Pet 
  {
    public int Content { get; set;}
    public int Rested { get; set;}
    public int Fed { get; set;}

    public Pet(int content, int rested, int fed )
    {
      Content = content;
      Rested = rested;
      Fed = fed;
    }

    public void Play()
    {
      this.Content+=10;
    }

    public void Feed()
    {
      this.Fed+=10;
    }
  }

}