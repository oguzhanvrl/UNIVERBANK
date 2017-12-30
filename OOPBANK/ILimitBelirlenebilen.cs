using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public interface IKrediLimitBelirlenebilen
    {
        decimal KrediLimitHesapla(double puanLimit,double krediFaizDeger);
    }
}
