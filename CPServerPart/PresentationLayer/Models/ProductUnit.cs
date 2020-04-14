using System;

namespace CPServerPart.PresentationLayer
{
    //TODO: комменты
    public class ProductUnit : Model
    {
        public Guid? ProductId { get; set; }
        public float Cost { get; set; }
        public Guid? CheckId { get; set; }
    }
}