using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES
{
    public class EMPLEADO : PERSONA
    {
        //ATRIBUTOS
        private string TIPO;
        private string TIPOCONTRATAO;
        private double SUELDO;
        private string CEDULA;
        //DECLARACION DE PROPIEDADES
        public string TIPO1 
        {
            get => TIPO;
            set => TIPO = value;
        }
        public string TIPOCONTRATAO1 
        {
            get => TIPOCONTRATAO;
            set => TIPOCONTRATAO = value;
        }
        public double SUELDO1 
        {
            get => SUELDO;
            set => SUELDO = value;
        }
        public string CEDULA1
        {
            get => CEDULA;
            set => CEDULA = value;
        }

        // PROCEDIMIENTO CALCULARS SUELDO
        public void CALCULARSUELDO(Double SUELDOBASE)
        {
            if(this.TIPO1== "GERENTE")
            {
                if (this.TIPOCONTRATAO1 == "NUEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATAO1 == "ANTIGUO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 1500;
                }
            }
            else if(this.TIPO1 == "VENDEDOR")
            {
                if (this.TIPOCONTRATAO1 == "NUEVO")
                {
                    SUELDO1 = SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATAO1 == "ANTIGUO")
                {
                    SUELDO1 = SUELDOBASE + 1500;
                }
            }
            
            else
            {
                this.SUELDO1 = 0;
            }
        }
        public void GENERARLISTACEDULA ()
        {
            this.CEDULA1 = "" + this.CEDULA1.Substring(0, 10);
        }
    }
}
