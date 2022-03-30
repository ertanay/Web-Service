using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using wttprojesi.database;

namespace wttprojesi
{
    /// <summary>
    /// Summary description for GetDatamx
    /// </summary>
    [WebService(Description = "Ödev")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetDatamx : System.Web.Services.WebService
    {
        wttProjesi db = new wttProjesi();
        [WebMethod]
        public List<Personel> MeslekVeKanGrubu(string meslek, string kanGrubu)
        {
            return db.Personel.Where(x => x.Meslek.Contains(meslek) && x.kan_grubu == kanGrubu).ToList();
        }
        [WebMethod]
        public List<Personel> BölümVeDaire(string bolum, string daire)
        {
            return db.Personel.Where(x => x.Bolum.Contains(bolum) && x.Daire.Contains(daire)).ToList();
        }
    }

}
