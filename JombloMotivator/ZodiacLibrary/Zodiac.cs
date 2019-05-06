using System;

namespace ZodiacLibrary
{
    public class Zodiac
    {
        /// <summary>
        /// Get the zodiac by using short date time, yakinkan kulturnya adalah id-ID
        /// </summary>
        /// <param name="shortDateTime">You can use conversion ToShortDateString from DateTime class</param>
        /// <returns>zodiac sign</returns>
        public static string FindZodiac(string shortDateTime)
        {
            string zodiacSign = null;
            string[] date = shortDateTime.Split('/');
            zodiacSign = FindZodiac(Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));
            return zodiacSign;
        }

        /// <summary>
        /// Get the zodiac using month and day
        /// </summary>
        /// <param name="month">Three digit of month i.e. Jan, May </param>
        /// <param name="day">number</param>
        /// <returns></returns>
        public static string FindZodiac(int month, int day)
        {
            string txtZodiac = string.Empty;


            if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 1 || day <= 20)))
            {
                txtZodiac = "Aries";
                return txtZodiac;
            }
            if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 1 || day <= 21)))
            {
                txtZodiac = "Taurus";
                return txtZodiac;
            }
            if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 1 || day <= 21)))
            {
                txtZodiac = "Gemini";
                return txtZodiac;
            }
            if (((month == 6) && (day >= 22 || day <= 31)) || ((month == 7) && (day >= 1 || day <= 22)))
            {
                txtZodiac = "Cancer";
                return txtZodiac;
            }
            if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 1 || day <= 22)))
            {
                txtZodiac = "leo";
                return txtZodiac;
            }
            if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 1 || day <= 21)))
            {
                txtZodiac = "Virgo";
                return txtZodiac;
            }
            if (((month == 9) && (day >= 22 || day <= 31)) || ((month == 10) && (day >= 1 || day <= 22)))
            {
                txtZodiac = "Libra";
                return txtZodiac;
            }
            if (((month == 10) && (day >= 23 || day <= 31)) || ((month == 11) && (day >= 1 || day <= 21)))
            {
                txtZodiac = "Scorpio";
                return txtZodiac;
            }
            if (((month == 11) && (day >= 22 || day <= 31)) || ((month == 12) && (day >= 1 || day <= 21)))
            {
                txtZodiac = "Sagitarius";
                return txtZodiac;
            }
            if (((month == 12) && (day >= 22 || day <= 31)) || ((month == 1) && (day >= 1 || day <= 20)))
            {
                txtZodiac = "Capricorn";
                return txtZodiac;
            }

            if (((month == 1) && (day >= 21 || day <= 31)) || ((month == 2) && (day >= 1 || day <= 19)))
            {
                txtZodiac = "Aquarius";
                return txtZodiac;
            }

            if (((month == 2) && (day >= 20 || day <= 31)) || ((month == 3) && (day >= 1 || day <= 20)))
            {
                txtZodiac = "Pisces";
                return txtZodiac;
            }

            return txtZodiac;


        }
    }
}

