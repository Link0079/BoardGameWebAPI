using System;
using System.Text;

namespace Imi.Project.Api.Core.Extentions
{
    public static class DurationConvertExtention
    {
        public static string ConvertToStringDuration(this int minutes)
        {
            TimeSpan timeSpan = TimeSpan.FromMinutes(minutes);
            StringBuilder stringBuilder = new StringBuilder();

            if (timeSpan.Hours != 0)
                stringBuilder.Append($"{timeSpan.Hours}h ");
            stringBuilder.Append($"{timeSpan.Minutes.ToString("00")}");
            //stringBuilder.Append(timeSpan.Seconds.ToString("00"));
            return stringBuilder.ToString();
        }
        public static string ConvertToStringDateNotation(this DateTime dateNotation)
        {
            return dateNotation.ToString("dddd dd MMMM yyyy");
        }
    }
}
