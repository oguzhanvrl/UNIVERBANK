using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public interface IlkHesapAlabilen
    {
        KrediHesap EkHesapAC(Banka BANKAM, long id);

        VadesizHesap VadesizTLAC(Banka BANKAM, long id);
    }
}
