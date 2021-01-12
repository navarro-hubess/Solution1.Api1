using Domain;
using System;
using System.Threading.Tasks;

namespace Services
{
    public class TaxaJurosService
    {

        //private readonly TaxaJuros _taxaJuros;

        //public TaxaJurosService(TaxaJuros taxaJuros)
        //{
        //    _taxaJuros = taxaJuros;
        //}

        public static async Task<decimal> RetornaTaxaJuros()
        {
            return TaxaJuros.TaxaDeJuros;
        }
    }
}
