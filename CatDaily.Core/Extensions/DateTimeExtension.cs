namespace CatDaily.Core.Extensions
{
    public static class DateTimeExtension
    {
        public static string ToTrShortDateTime(this DateTime dateTime)
        {
            return dateTime.ToString("dd-MM-yyyy");
        }

        public static string ToUsaShortDateTime(this DateTime dateTime)
        {
            return dateTime.ToString("MM-dd-yyyy");
        }
    }
}
