using System;

namespace TamagotchiAPIJune29.Models
{
    public class Feeding
    {
        public int Id { get; set; }

        public DateTime When { get; set; }

        public int PetId { get; set; }
    }
}
