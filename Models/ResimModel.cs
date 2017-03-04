using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace fotogaleri.Models
{
    public class ResimModel:List<Resim>
    {
        public ResimModel()
        {
            string ResimYol = HttpContext.Current.Server.MapPath("/App_Data/resim.xml"); // dosya adres yolunu alıuoruz
            XDocument dokuman = XDocument.Load(ResimYol); // xdocumant sınıfı ile deserilaze ediliyor

            var ResimListe = (from r in dokuman.Descendants("Resim")
                              select new Resim()
                              {
                                  Baslik = r.Element("Baslik").Value,
                                  Aciklama = r.Element("Aciklama").Value,
                                  Url = r.Element("Url").Value

                              }).ToList();

            this.AddRange(ResimListe);
        }

    }
}
