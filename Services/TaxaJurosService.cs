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

        public async Task<TaxaJuros> RetornaTaxaJuros()
        {
            TaxaJuros tx = new TaxaJuros { TaxaDeJuros = 0.01M };
            return tx;
        }
    }
}
