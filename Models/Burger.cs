using burgershack.Enums;
using burgershack.Interfaces;

namespace burgershack.Models
{
  public class Burger : IMenuItem
  {
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Cost { get; set; }
    public int Quantity { get; set; }
    public string Modifications { get; set; } = "";
    public ItemType ItemType
    {
      get => ItemType.Burger;
    }
  }
}