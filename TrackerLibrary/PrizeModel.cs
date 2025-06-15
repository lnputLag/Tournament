using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Демонстрирует какой будет приз за определённое место
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Уникальный идентификатор приза
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Числовой идентификатор места (2 для второго места и т. д.)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Конкретное название места (второе место, первое место и т. д.)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Фиксированная сумма, которую зарабатывает это может быть место, или ноль, если оно не используется.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Число, обозначающее процент от общего дохода, или ноль, если оно не используется. 
        /// Процент равен дроби (то есть 0,5 для 50%).
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel() 
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage) 
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
