using System;
using System.Collections.Generic;
using System.Text;

namespace _28._09._2026
{
    public class osoba
    {
        public string imie;
        public int wiek;
        //konstruktor - metoda wywoływana w momencie tworzenia obiektu
        //przypisuje wartości początkowe do pól klasy
        //imie i wiek to pola klasy

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
