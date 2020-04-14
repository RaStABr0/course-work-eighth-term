using System;

namespace CPServerPart.PresentationLayer
{
    public abstract class Model
    {
        /// <summary> PK </summary>
        public Guid? Id { get; set; }
    }
}