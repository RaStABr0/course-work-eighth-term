using System;
using System.ComponentModel.DataAnnotations;

namespace CPServerPart.PresentationLayer
{
    /// <summary> Товар </summary>
    public class Product : Model
    {
        /// <summary> Производитель </summary>
        public string Manufacturer { get; set; }

        /// <summary> Модель </summary>
        public string Model { get; set; }

        /// <summary> Количество на складе </summary>
        public int Count { get; set; }
        
        /// <summary> Цена товара </summary>
        public int Cost { get; set; }
    }
}