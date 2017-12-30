using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public interface IVadeliVadesizHesapAcabilen
    {
        VadesizHesap VadesizHesapAC(Banka BANKAM, long id, VadesizHesap hesap);

        VadeliHesap VadeliHesapAC(Banka BANKAM, long id,VadeliHesap hesap);
    }
}
