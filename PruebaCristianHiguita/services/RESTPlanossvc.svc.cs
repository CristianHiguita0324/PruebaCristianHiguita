using PruebaCristianHiguita.Dao;
using PruebaCristianHiguita.TOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;



namespace PruebaCristianHiguita.services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    public class RESTPlanossvc 
    {

        #region Servicio importar planos
        [OperationContract]
        [WebGet(UriTemplate = "ImportarPlanos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public AnimalesPacketTO ImportarPlanos()
        {
            try
            {
                ImportarPlanoDao ClsInportarP = new ImportarPlanoDao();
                return ClsInportarP.ImportarPlanos();
            }
            catch
            {
                return null;
            }

        }

        #endregion


        #region Servicio Generar Planos
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "GenerarPlanos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public string GenerarPlanos(AnimalesPacketTO list)
        {
            try
            {
                GenerarPlanosDao ClsGenerarPlanos = new GenerarPlanosDao();
              return  ClsGenerarPlanos.GenerarPlanos(list);


            }
            catch(Exception exe)
            {
                return exe.ToString();
            }

        }
        #endregion

    }
}
