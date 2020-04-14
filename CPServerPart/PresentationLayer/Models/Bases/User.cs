using System;
using CPServerPart.Infrastructure;

namespace CPServerPart.PresentationLayer
{
    /// <summary> Пользователь системы </summary>
    public class User : Model
    {
        /// <summary> Логин </summary>
        public string Login { get; set; }
        
        /// <summary> Пароль </summary>
        public string Password { get; set; }
        
        /// <summary> Секретный вопрос </summary>
        public string SecretQuestion { get; set; }
        
        /// <summary> Ответ на контрольный вопрос </summary>
        public string Answer { get; set; }
        
        /// <summary> Номер телефона </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary> Полное имя </summary>
        public string FullName { get; set; }
        
        /// <summary> Электронная почта </summary>
        public string Email { get; set; }

        /// <summary> Статус пользователя в системе </summary>
        public UserStatus Status { get; set; }
    }
}