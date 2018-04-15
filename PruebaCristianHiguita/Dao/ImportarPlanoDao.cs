using PruebaCristianHiguita.TOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace PruebaCristianHiguita.Dao
{
    public class ImportarPlanoDao
    {

        #region Importar Los planos del Cliente

        //se lee el archivo .dat proporcionado por el cliente y con base a el se llena una lista de Animales
        //agregando en la propiedad Tipo "Bovino" o "Equino" segun sea el caso
        public AnimalesPacketTO ImportarPlanos()
        {
            AnimalesPacketTO respuesta = new AnimalesPacketTO();
            try
            {
              
               AnimalesTO TempAnimal;
              
                using (StreamReader Documento = new StreamReader(@"C:\EQUINOSBOVINOS.DAT"))
                {
                    int id = 0;
                    while(Documento.EndOfStream)
                    {
                        TempAnimal = new AnimalesTO();
                        TempAnimal.Nombre = Documento.ReadLine();
                        TempAnimal.ID = id++;
                        if(TempAnimal.Nombre.ToUpper().Contains("B"))
                         TempAnimal.Tipo = "Bovino";
                        else
                            TempAnimal.Tipo = "Equino";
                        respuesta.AnimalesTO.Add(TempAnimal);
                    }
                }

                return respuesta;

            }
            catch (Exception exe)
            {
                respuesta.RespError = exe.ToString();
                return respuesta;
            }
        }

        #endregion
    }
}