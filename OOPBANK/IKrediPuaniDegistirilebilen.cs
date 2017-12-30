using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public interface IKrediPuaniDegistirilebilen
    { 
        double MusteriKrediPuaniIslemleri(decimal deger, double puanLimit);
    }
}
