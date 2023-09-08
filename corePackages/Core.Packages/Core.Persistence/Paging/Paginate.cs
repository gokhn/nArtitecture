using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Paging;

public class Paginate<T>
{
    public Paginate()
    {
        Items = Array.Empty<T>();
    }

    public int Size { get; set; }  //Kac data var
    public int Index { get; set; }  //Hangi sayfadayiz
    public int Count { get; set; }  //Toplan Kayit Sayisi
    public int Pages { get; set; }  //Toplam Kac Sayfa var

    public IList<T> Items { get; set; }

    public bool HasPrevious => Index > 0;
    public bool HasNext => Index + 1  < Pages; 
}
