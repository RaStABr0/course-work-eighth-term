using System;

namespace CPServerPart.PresentationLayer
{
    /// <summary> Чек за покупку </summary>
    public class Check : Model
    {
        /// <summary> PK сотрудника, пробивавшего покупку </summary>
        public Guid? EmployeeId { get; set; }
        
        /// <summary> PK покупателя, совершавшего покупку </summary>
        public Guid? CustomerId { get; set; }
        
        /// <summary> Дата, когда производилась покупка </summary>
        public DateTime? Date { get; set; }
        
        /// <summary> PK магазина, в котором произодилась покупка </summary>
        public Guid? ShopId { get; set; }
        
        /// <summary> Стоимость покупки </summary>
        public float Value { get; set; }
    }
}