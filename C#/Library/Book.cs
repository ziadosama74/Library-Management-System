using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    public int ISBN { get; set; }
    public string Title { get; set; }
    public int CategoryID { get; set; }
    public int TotalCopies { get; set; }
    public int AvaliableCopies { get; set; }
    public int AuthorID { get; set; }
}
