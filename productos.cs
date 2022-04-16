using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    class productos                  //CREACION DE LA CLASE PRODUCTOO 
                                    // DONDE SE VA INGRESAR LOS DATOS QUE VAMOS A REQUERIR  PARA LA CREACION DE UN NUEVO PRODUCTO
                                   // ES DECIR UN PLATO DEL MENU
    {
        private int id;
        private string nombreProducto;
        private string descripcion;
        private int precio;
        private int idCatProduct;
        private bool respuesta = false;

        //CONSTRUCTOR PARA INGRESAR Y OBTENER LOS DATOS SOLICITADOS DEL NUEVO PRODUCTO

        public int Id                          //INGRESAR Y OBTENER EL ID DEL PRODUCTO 
        {
            get { return id; }
            set { id = value; }
        }


        public string NombreProducto          //INGRESAR Y OBTENER EL NOMBRE DEL PRODUCTO
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public string Descripcion            // INGRESAR Y OBTENER LA DESCRIPCION DEL PRODUCTO     
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public int Precio                     // INGRESAR Y OBTENER EL PRECIO DEL PRODUCTO 
        {
            get { return precio; }
            set { precio = value; }
        }

        public int IdCatProduct              // INGRESAR Y OBTENER ID Y LA CATEGORIA DEL PRODUCTO 
        {
            get { return idCatProduct; }
            set { idCatProduct = value; }
        }


        public bool Respuesta                  // INGRESAR Y OBTENER LA RESPUESTA DEL PRODUCTO 
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
        


    }
}
