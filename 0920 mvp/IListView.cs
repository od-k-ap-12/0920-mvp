using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_mvp
{
    public interface IListView
    {
        string PersonName { get;set; }
        string PersonAge { get; set; }
        string NameSearch { get;set; }
        string People { get; set; }  

        event EventHandler<EventArgs> SaveEvent;
        event EventHandler<EventArgs> ShowAllEvent;
        event EventHandler<EventArgs> SearchEvent;
    }
}
