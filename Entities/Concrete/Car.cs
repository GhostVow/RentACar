﻿using Core.Entities;


namespace Entities.Concrete
{

    public class Car:IEntity
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public short ModelYear { get; set; }
        public int Kilometer { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }

}
