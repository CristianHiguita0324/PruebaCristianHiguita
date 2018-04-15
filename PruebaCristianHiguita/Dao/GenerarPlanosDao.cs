using PruebaCristianHiguita.TOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PruebaCristianHiguita.Dao
{
    public class GenerarPlanosDao
    {
        #region Metodo Crear Planos

        //recibe por parametro una lista de Animeles y creamos los dos archivos de texo
        //dependiendo del valor que venga en la propiedad Tipo, se escribe en el archivo que corresponde
        public string GenerarPlanos(AnimalesPacketTO list)
        {
            
            try
            {

                //se crea el archivo de Equinos
                StreamWriter DocEquino = File.CreateText(@"C:\Equinos.txt");
                //se crea el archivo de Bovinos
                StreamWriter DocBovino = File.CreateText(@"C:\Bovinos.txt");
                //recorro la lista que llega por parametro , y dependiendo del tipo de animal
                //escribo en el txt correspondiente
                foreach (AnimalesTO obj in list.AnimalesTO)
                {
                    if (obj.Tipo.Equals("Bovino"))
                        DocBovino.WriteLine(obj.Nombre);
                    else
                        DocEquino.WriteLine(obj.Nombre);
                }
                DocEquino.Close();
                DocBovino.Close();
                return "Se crearon los planos correctamente";
              

            }
            catch (Exception exe)
            {
                return "Ocurrio un error al crear los planos  E :" + exe.ToString();
            }
        }

        #endregion
    }
}