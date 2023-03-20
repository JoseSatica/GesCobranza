using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ENConcepto
    {
        private string varID_CONCEPTO;
        private string varDETALLE;
        private string varESTADO;
        private string varUSUARIO_REG;
        private DateTime varFECHA_REG;
        private string varESTACION_REG;

        public ENConcepto()
        {
        }

        public string _ID_CONCEPTO
        {
            get
            {
                return varID_CONCEPTO;
            }
            set
            {
                varID_CONCEPTO = value;
            }
        }

        public string _DETALLE
        {
            get
            {
                return varDETALLE;
            }
            set
            {
                varDETALLE = value;
            }
        }

        public string _ESTADO
        {
            get
            {
                return varESTADO;
            }
            set
            {
                varESTADO = value;
            }
        }

        public string _USUARIO_REG
        {
            get
            {
                return varUSUARIO_REG;
            }
            set
            {
                varUSUARIO_REG = value;
            }
        }

        public DateTime _FECHA_REG
        {
            get
            {
                return varFECHA_REG;
            }
            set
            {
                varFECHA_REG = value;
            }
        }

        public string _ESTACION_REG
        {
            get
            {
                return varESTACION_REG;
            }
            set
            {
                varESTACION_REG = value;
            }
        }
    }
}
