using System;
using System.Collections.Generic;
using System.Text;

namespace _28._09._2026
{
    public class osoba
    {
        private string imie;
        private int wiek;
        //konstruktor - metoda wywoływana w momencie tworzenia obiektu
        //przypisuje wartości początkowe do pól klasy
        //imie i wiek to pola klasy

        /*
         * modyfikatory dostępu:
         * private - dostęp tylko wewnątrz klasy
         * public - dostęp z każdego miejsca w programie
         * 
         * protected - dostęp tylko w klasach dziedziczących po tej klasie
         * 
         * jeżeli stosujemy private i protected
         * to hermetyzacja inaczej enkapsulacja
         */

        public osoba(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }

        public osoba()
        {
        }//przeciążenie konstruktorów- metody o tej samen nazwie, ale różniące się parametrami
        public override string ToString()
        {
            return "imię: " + imie + ", wiek: " + wiek;
        }
    }
