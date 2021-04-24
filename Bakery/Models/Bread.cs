namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }

    public Bread()
    {
      Price = 5;
    }
    public int DetermineBreadPrice(int breadNumber)
    {
      return breadNumber * Price;
    }
  }
}

// constructor test 
// 