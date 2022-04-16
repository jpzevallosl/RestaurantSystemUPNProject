using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    internal class mesa  //CLASE DONDE SE ASIGNARAN LOS DATOS PARA LA CREACION DE UNA MESA
                         //EN EL SISTEMA
    {
        private int id;
        private int numeroMesa;
        private int idStatus;



        //CONSTRUCTOR PARA INGRESAR Y OBTENER LOS DATOS SOLICITADOS DE LA CLASE MESA
        public int Id   //INGRESAR Y OBTENER EL ID DE LA CLASE MESA
        {
            get { return id; }
            set { id = value; }
        }

        public int NumeroMesa   //INGRESAR Y OBTENER DEL NUMERO DE MESA DE LA CLASE MESA
        {
            get { return numeroMesa; }
            set { numeroMesa = value; }
        }
        public int Idstatus    //INGRESAR Y OBTENER DEL STATUS  DE LA CLASE MESA
        {
            get { return idStatus; }
            set { idStatus = value; }
        }
    }
}


