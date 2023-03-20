using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ENDetalleValor
    {
        private string varTributo;
        private string varAño;
        private string varPredio;
        private string varAnexo;
        private string varPeriodo;
        private string varImpInsol;
        private string varImpReaj;
        private string varInteres;
        private string varCostoEmis;
        private string varTotPago;
        private string varTotal;
        public ENDetalleValor(string año, string tributo, string periodo, string impInsol, string impReaj, string costoEmis, string interes, string Total)
        {
            Año = año;
            Tributo = tributo;
            Periodo = periodo;
            ImpInsol = impInsol;
            ImpReaj = impReaj;
            Interes = interes;
            CostoEmis = costoEmis;
            this.Total = Total;
        }

        public string Tributo
        {
            get
            {
                return varTributo;
            }
            set
            {
                varTributo = value;
            }
        }

        public string Año
        {
            get
            {
                return varAño;
            }
            set
            {
                varAño = value;
            }
        }

        public string Predio
        {
            get
            {
                return varPredio;
            }
            set
            {
                varPredio = value;
            }
        }

        public string Anexo
        {
            get
            {
                return varAnexo;
            }
            set
            {
                varAnexo = value;
            }
        }

        public string Periodo
        {
            get
            {
                return varPeriodo;
            }
            set
            {
                varPeriodo = value;
            }
        }

        public string ImpInsol
        {
            get
            {
                return varImpInsol;
            }
            set
            {
                varImpInsol = value;
            }
        }

        public string ImpReaj
        {
            get
            {
                return varImpReaj;
            }
            set
            {
                varImpReaj = value;
            }
        }

        public string Interes
        {
            get
            {
                return varInteres;
            }
            set
            {
                varInteres = value;
            }
        }

        public string CostoEmis
        {
            get
            {
                return varCostoEmis;
            }
            set
            {
                varCostoEmis = value;
            }
        }

        public string TotPago
        {
            get
            {
                return varTotPago;
            }
            set
            {
                varTotPago = value;
            }
        }

        public string Total
        {
            get
            {
                return varTotal;
            }
            set
            {
                varTotal = value;
            }
        }


    }
}
