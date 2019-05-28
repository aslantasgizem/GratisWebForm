using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Gratis1
{
    public class Service1 : IService1
    {

        string IService1.GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        bool IService1.GirisYap(int GratisCardNo, int parola)
        {


            List<int> CardNo = new List<int>();
            CardNo.Add(012345);
            CardNo.Add(987654);
            CardNo.Add(456321);


            List<int> Parola = new List<int>();

            Parola.Add(1010);
            Parola.Add(2020);
            Parola.Add(3030);



            if (CardNo.Contains(GratisCardNo) && Parola.Contains(parola))

            {
                return true;
            }

            else
                return false;
        }

        bool IService1.KartOnay(int KartNo, int sifre)
        {
            List<int> KrediNo = new List<int>();
            KrediNo.Add(10000000);
            KrediNo.Add(22002200);
            KrediNo.Add(58585758);

            List<int> Sifre = new List<int>();
            Sifre.Add(1234);
            Sifre.Add(4321);
            Sifre.Add(9876);

            if (KrediNo.Contains(KartNo) && Sifre.Contains(sifre))

            {
                return true;
            }

            else
                return false;





        }

        int IService1.OdemeKontrolu(int kod)
        {
            Stack yigin = new Stack();
            yigin.Push(232323);
            yigin.Push(151515);
            yigin.Push(363636);
            yigin.Push(353535);
            yigin.Push(707070);
            yigin.Push(818181);

            kod = (int)yigin.Pop();

            return kod;

        }
    }
}
