using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    class usuario                        //CREACION DE LA CLASE USUARIO 
                                         // DONDE SE VA INGRESAR LOS DATOS QUE VAMOS A REQUERIR DEL USUARIO NUEVO
    {
        private int id;
        private string nombe;
        private string apellido;
        private int rol;
        private int status;
        private string pass;
        private bool respuesta;


        //CONSTRUCTOR PARA INGRESAR Y OBTENER LOS DATOS SOLICITADOS DEL USUARIO

        public int Id                    //INGRESAR Y OBTENER EL ID DEL USUSARIO
        {
            get { return id; }
            set { id = value; }
        }


        public string Nombe              //INGRESAR Y OBTENER EL NOMBRE DEL USUARIO 
        {
            get { return nombe; }
            set { nombe = value; }
        }

        public string Apellido          //INGRESAR Y OBTENER EL APELLIDO DEL USUARIO
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Pass              //INGRESAR Y OBTENER EL PASS DEL USUARIO
        {
            get { return pass; }
            set { pass = value; }
        }
        public int Idrol                //INGRESAR Y OBTENER EL ROL DEL USUARIO
        {
            get { return rol; }
            set { rol = value; }
        }

        public int Status               //INGRESAR Y OBTENER EL STATUS O CATEGORIA DEL USUARIO
        {
            get { return status; }
            set { status = value; }
        }
        

        public bool Respuesta           //INGRESAR Y OBTENER LA RESPUESTA
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
    }
}
