using System;

namespace CPServerPart.PresentationLayer
{
    /// <summary> Покупатель </summary>
    public class Customer : User
    {
        /// <summary> Любимый магазин </summary>
        public Guid? FavouriteShop { get; set; }       
        
        /// <summary> Процент скидки </summary>
        public int Discount { get; set; }
    }
}