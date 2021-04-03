using System;
using System.Text;

namespace Imi.Project.Api.Core.Extentions
{
    public static class DurationConvertExtention
    {
        public static string ConvertToStringDuration(this int minutes)
        {
            long newMinutes = (long)minutes;
            var result = newMinutes.ConvertToSTringDuration();
            return result;
        }
        public static string ConvertToStringDateNotation(this DateTime dateNotation)
        {
            return dateNotation.ToString("dddd dd MMMM yyyy");
        }
        public static string ConvertToSTringDuration(this long minutes)
        {
            TimeSpan timeSpan = TimeSpan.FromMinutes(minutes);
            StringBuilder stringBuilder = new StringBuilder();

            if (timeSpan.Days != 0)
                stringBuilder.Append($"{timeSpan.Days} days, ");
            if (timeSpan.Hours != 0)
                stringBuilder.Append($"{timeSpan.Hours} hours, ");

            stringBuilder.Append($"{timeSpan.Minutes.ToString("00")} minutes.");
            //stringBuilder.Append($"{timeSpan.Seconds.ToString("00")} seconds");
            return stringBuilder.ToString();
        }
    }
}
