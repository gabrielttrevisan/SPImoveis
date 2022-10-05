using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPImoveis.Repositories;

namespace SPImoveis.Controllers
{
    public class ClientController : Controller
    {
        private ClientRepository repository;

        public ClientController()
        {
            repository = new ClientRepository();
        }

        public ActionResult Index()
        {
            return Json(new { 
                data = this.repository.RunProcudure("GetClients")
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int id)
        {
            this.repository.SilentlyRunProcudure("DeleteClient", new Utils.ProcedureParams().Add("ID", id.ToString()));

            return Json(new { success = true }, JsonRequestBehavior.DenyGet);
        }
    }
}