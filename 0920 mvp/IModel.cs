using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0920_mvp
{
    public interface IModel
    {
        string PersonName { get; set; }
        string PersonAge { get; set; }

        void Save();
        string ShowAll();
    }
}
