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
      if (breadNumber <= 2)
      {
        return breadNumber * Price;
      }
      else
      {
        int salePrice = DetermineSalePrice(breadNumber);
        return salePrice;
      }
    }
    public int DetermineSalePrice(int breadNumber)
    {
      int normalPrice = breadNumber * Price;
      int sale = (breadNumber / 3) * 5;
      return normalPrice - sale;
    }

  }
}

// constructor test 
// 