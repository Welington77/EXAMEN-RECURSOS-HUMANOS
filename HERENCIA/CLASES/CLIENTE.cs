using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES
{
    public class CLIENTE : PERSONA
    {
        //ATRIBUTOS
        private string CATEGORIA;
        private string CODIGODEPEDIDO;
        private string NCEDULAS;
        //PROPIEDADES
        public string CATEGORIA1 
        {
            get => CATEGORIA;
            set => CATEGORIA = value; 
        }
        public string CODIGODEPEDIDO1
        { 
            get => CODIGODEPEDIDO;
            set => CODIGODEPEDIDO = value;
        }
        public string NCEDULAS1 
        {   get => NCEDULAS;
            set => NCEDULAS = value;
        }

        //PROCEDIMIENTOS, OPERACIONES O METODOS GENERAR CODIGO DE PEDIDO
        public void GENERARCODIGODEPEDIDO()
        {
            this.CODIGODEPEDIDO1 = "C" + this.APPETERNO1.Substring(0, 3);
        }
        public void GENERARLISTANCEDULAS()
        {
            this.NCEDULAS1 = "" + this.NCEDULAS1.Substring(0, 10); 
        }
    }
}
