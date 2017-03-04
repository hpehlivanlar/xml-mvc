using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace xml
{
  public class Program
    {
        static void Main(string[] args)
        {

            List<Resim> resimler = new List<Resim>();

            string path = @"D:\projeler2016\sınıf\fotogaleri\fotogaleri\Content\img\";
            DirectoryInfo yol = new DirectoryInfo(path); //FileInfo tipinden bir değişken oluşturuyoruz.
            FileInfo[] rgFiles = yol.GetFiles(); //foreach döngümüzle fgFiles içinde dönüyoruz.
            foreach (FileInfo rsm in rgFiles)
            {
                resimler.Add(new Resim(rsm.Name, rsm.CreationTime.ToString(), "/Content/img/" + rsm.Name));
            }

            //resimler.Add(new Resim("Rize", "Kış Manzarası", "/Content/img/1.jpg"));
            //resimler.Add(new Resim("Ankara", "Kış Manzarası", "/Content/img/2.jpg"));
            //resimler.Add(new Resim("Tokat", "Kış Manzarası", "/Content/img/3.jpg"));
            //resimler.Add(new Resim("Sivas", "Kış Manzarası", "/Content/img/4.jpg"));
            //resimler.Add(new Resim("Maraş", "Kış Manzarası", "/Content/img/5.jpg"));
            //resimler.Add(new Resim("Kahramanmaraş", "Kış Manzarası", "/Content/img/6.jpg"));
            //resimler.Add(new Resim("Şanalıurfa", "Kış Manzarası", "/Content/img/7.jpg"));
            //resimler.Add(new Resim("Gaziantep", "Kış Manzarası", "/Content/img/8.jpg"));
            //resimler.Add(new Resim("Van", "Kış Manzarası", "/Content/img/9.jpg"));


            XmlSerializer ser = new XmlSerializer(typeof(List<Resim>));
            using (XmlWriter wr = XmlWriter.Create(@"D:\projeler2016\sınıf\fotogaleri\fotogaleri\App_Data\resim.xml"))
            {
                ser.Serialize(wr, resimler, null);
                wr.Flush();
            }

        }

    }

        [Serializable]
        public class Resim
        {
        private string baslik;

        public string Baslik
        {
            get { return baslik; }
            set { baslik = value; }
        }
        private string aciklama;

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }

        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }

        }

        public Resim()
        {

        }


        public Resim(string baslik, string aciklama, string url)
        {
            this.baslik = baslik;
            this.aciklama = aciklama;
            this.url = url;
        }

    }
    
}
