namespace CatDaily.Core.Extensions
{
    public static class IntExtension
    {
        public static int faktoriyel(this int sayi)
        {
            int sonuc = 1;
            for(int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }
    }
}
//bi double alıcak ve tl olarak dönücek. 10000-> 10.000