using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Enumerari
    {
        public enum TipProdus
        {
            Nedefinit = 0,
            Alimentar = 1,
            Electronic = 2,
            Vestimentar = 3,
            Casnic = 4,
            Sport = 5,
            Carte = 6,
            Jucarie = 7,
            Sanatate = 8,
            Mobila = 9,
            Gradinarit = 10,
            Cosmetic = 11
        };
        [Flags]
        public enum OptiuniProdus
        {
            Nedefinit = 0,
            Reciclabil = 1 << 0, // 1
            Premium = 1 << 1,     // 2
            EditieLimitata = 1 << 2, // 4
            GarantieExtinsa = 1 << 3, // 8
            Personalizabil = 1 << 4, // 16
            DisponibilOnline = 1 << 5, // 32
            DisponibilFizic = 1 << 6, // 64
            TravelSize = 1 << 7, // 128
            ReturUsor = 1 << 8,    // 256
            Vegan = 1 << 9, // 512
            Brand = 1 << 10, // 1024
            NoName = 1 << 11, // 2048
            Handmade = 1 << 12, // 4096
        }
    }
}
