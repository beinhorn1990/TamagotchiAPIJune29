using System;
namespace TamagotchiAPIJune29.Models
{
public class Playtime
{
    public int Id { get; set; }
    public DateTime When { get; set; }
    public int PetID { get; set; }
    public Pet Pet { get; set; }
}
}