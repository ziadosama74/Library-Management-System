using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

public class Borrowing
{
    public int borrow_id { get; set; }
    public int UserID { get; set; }
    public int ISBNBook { get; set; }
    public string TitleBook { get; set; }
    public DateTime borrow_date { get; set; }
    public DateTime due_date { get; set; }
    public DateTime return_date { get; set; }
    public string status { get; set; }
}

