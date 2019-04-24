using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaSugestao.BO;
using SistemaSugestao.VO;
using SistemaSugestao.DAO;


namespace SistemaSugestao.WEB.Controllers
{
    public class CredencialController : Controller
    {

        CredencialDAO credencialDAO = new CredencialDAO();

        // GET: Credencial
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(CredencialVO dadosTela)
        {
            credencialDAO.Login(dadosTela);
            return View();
        }
    }
}