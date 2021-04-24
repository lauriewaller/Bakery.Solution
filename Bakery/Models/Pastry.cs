namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public Pastry()
    {
      Price = 2;
    }

    public int DeterminePastryPrice(int pastryNumber)
    {
      if (pastryNumber <= 2)
      {
        return pastryNumber * Price;
      }
      else
      {
        int salePrice = DetermineSalePrice(pastryNumber);
        return salePrice;
      }
    }

    public int DetermineSalePrice(int pastryNumber)
    {
      int normalPrice = pastryNumber * Price;
      int sale = pastryNumber / 3;
      return normalPrice - sale;
    }    
  }
}