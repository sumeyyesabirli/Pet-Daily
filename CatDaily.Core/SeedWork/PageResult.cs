using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDaily.Core.SeedWork
{
    public class PageResult
    {
        //Mevcut sayfa numarası
        public int CurrentPage { get; set; }
        //Sayfa başına öğe sayısını - bir sayfada 10 öğe 
        public int PageSize { get; set; }
        //Toplam veri satır sayısını
        public int TotalRowCount { get; set; }
        // yukarıya doğru yuvarlama
        public int TotalPageCount => (int)Math.Ceiling((double)TotalRowCount / PageSize);
        //Mevcut sayfada kaç verinin atlanacağı
        public int Skip => (CurrentPage - 1) * PageSize;
    }
}
