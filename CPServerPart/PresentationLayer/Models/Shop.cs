using System;
using CPServerPart.Infrastructure;

namespace CPServerPart.PresentationLayer
{
    /// <summary> Магазин сети </summary>
    public class Shop : Model
    {
        /// <summary> Адрес </summary>
        public string Address { get; set; }
        
        /// <summary> Статус (обычный, гипер, супер итд) </summary>
        public ShopStatus Status { get; set; }
        
        /// <summary> PK директора </summary>
        public Guid? ChiefId { get; set; } 
    }
}