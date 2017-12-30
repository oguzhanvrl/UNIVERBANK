using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public interface ISıfreKriptolanabilen
    {
        string passSifreleme(string Sifre, long MusteriID);
    }
}
