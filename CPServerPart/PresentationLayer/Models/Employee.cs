using System;

namespace CPServerPart.PresentationLayer
{
    /// <summary> Сотрудник </summary>
    public class Employee : User
    {
        /// <summary> Паспортные данные </summary>
        public string PassportData { get; set; }
        
        /// <summary> PK магазина </summary>
        public Guid? ShopId { get; set; }
    }
}