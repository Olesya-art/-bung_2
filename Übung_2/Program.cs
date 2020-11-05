using System;

namespace Übung_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto meinAuto = new Auto();
            Ferrari meinFerrari = new Ferrari();
            Delorean meinDelorean = new Delorean();

            meinAuto.Tueren = 2;
            meinFerrari.Tueren = 3;
            meinDelorean.Tueren = 4;

            meinAuto.TuerenBenutzen();
            meinAuto.TuerenBenutzen();

            meinFerrari.TuerenBenutzen();
            meinFerrari.TuerenBenutzen();

            meinDelorean.TuerenBenutzen();
            meinDelorean.TuerenBenutzen();

        }

        class Auto
        {
            public byte Tueren;
            bool TuerenOffen = false;
            public void TuerenBenutzen()
            {
                if (TuerenOffen)
                {
                    TuerenOffen = false;
                    Console.WriteLine("Alle" + Tueren + " Türen sind zu");
                }
                else
                {
                    TuerenOffen = true;
                    Console.WriteLine("Alle" + Tueren + " Türen sind auf");
                }
            }
        }

        class Ferrari : Auto
        {

        }

        class Delorean : Auto 
        {
        
        }
    }
}
