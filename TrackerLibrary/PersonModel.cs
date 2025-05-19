using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Представляет одного человека
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Имя 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Основной адрес электронной почты 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Основной номер телефона 
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
