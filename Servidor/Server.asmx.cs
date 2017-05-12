using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using Aplicacao.Servico;

namespace Servidor
{
    /// <summary>
    /// Summary description for Server
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Server : System.Web.Services.WebService
    {
        ServicoLamport servico = new ServicoLamport();
        private bool vEmUso = false;
        private bool eEmUso = false;
        private bool sEmUso = false;
       
        [WebMethod]
        public string Visualizar()
        {
            if (vEmUso)
            {
                return "EMUSO";
            }
            Thread.Sleep(10000);
           
            return "OK";
        }


        [WebMethod]
        public string Editar()
        {
            if (eEmUso)
                return "EMUSO";

            Thread.Sleep(4000);
            return "OK";
        }


        [WebMethod]
        public string Salvar()
        {
            if (sEmUso)
                return "EMUSO";
            
            Thread.Sleep(5000);
            return "OK";
        }

     
    }
}
