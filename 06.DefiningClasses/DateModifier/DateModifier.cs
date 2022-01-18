using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int CalculateDateDifferenceInDays(string firstDate, string secondDate)
        {
            DateTime dayone = DateTime.Parse(firstDate);
            DateTime daytwo = DateTime.Parse(secondDate);

            int days = Math.Abs((dayone - daytwo).Days);

            return days;
        }
    }
}
