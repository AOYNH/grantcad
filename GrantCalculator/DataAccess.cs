using System;
 
using System.IO;
 
using System.Xml;
using System.Xml.Serialization;

namespace GrantCalculator
{
    
    public static class DataAccess
    {

		public static Estimator estimator;

		public static string  fPath = Environment.CurrentDirectory + "\\estimate.xml";
		public static void CreateEstimationXML()
        {
            Estimator s_timate = new Estimator
            {
                Cement = 1,
                Gravel = 2,
                Sand = 2,
                Lime = 1,
                Cement_Price = 5200,
                Gravel_Price = 4000,
                Sand_Price = 3000,
                Lime_Price = 2500
            };
            XmlSerializer searial = new XmlSerializer(typeof(Estimator));
			using(FileStream fs = new FileStream(fPath,FileMode.Create,FileAccess.Write))
            {
				searial.Serialize(fs, s_timate);
            }
        }
		public static void ParseEstimationXML()
        {
			using (var fileStream = File.Open(fPath, FileMode.Open))
			{
				XmlSerializer deserializer = new XmlSerializer(typeof(Estimator));
				var estimate = (Estimator)deserializer.Deserialize(fileStream);
                estimator = new Estimator
                {
                    Cement = estimate.Cement,
                    Gravel = estimate.Gravel,
                    Lime = estimate.Lime,
                    Sand = estimate.Sand,
                    Cement_Price = estimate.Cement_Price,
                    Gravel_Price = estimate.Gravel_Price,
                    Lime_Price = estimate.Lime_Price,
                    Sand_Price = estimate.Sand_Price
                };
            }
		}
		public static void Update_XML_Ratio(int cement,int gravel,int lime,int sand)
        {
			
			XmlDocument doc = new XmlDocument();
			doc.Load(fPath);
			XmlNode root = doc.DocumentElement;
			XmlNode cementNode = root.SelectSingleNode("Cement");
			cementNode.InnerText = cement.ToString();
			XmlNode gravelNode = root.SelectSingleNode("Gravel");
			gravelNode.InnerText = gravel.ToString();
			XmlNode limeNode = root.SelectSingleNode("Lime");
			limeNode.InnerText = lime.ToString();
			XmlNode sandNode = root.SelectSingleNode("Sand");
			sandNode.InnerText = sand.ToString();
			doc.Save(fPath);
			estimator = new Estimator
			{
				Cement = cement,
				Gravel = gravel,
				Lime = lime,
				Sand = sand,
				Cement_Price = estimator.Cement_Price,
				Lime_Price = estimator.Lime_Price,
				Sand_Price = estimator.Sand_Price,
				Gravel_Price = estimator.Gravel_Price
			};

		}
		public static void Update_XML_Price(float cementprice,float gravelprice,float limeprice,float sandprice)
        {
			XmlDocument doc = new XmlDocument();
			doc.Load(fPath);
			XmlNode root = doc.DocumentElement;
			XmlNode cement_price_Node = root.SelectSingleNode("Cement_Price");
			cement_price_Node.InnerText = cementprice.ToString();
			XmlNode gravel_price_Node = root.SelectSingleNode("Gravel_Price");
			gravel_price_Node.InnerText = gravelprice.ToString();
			XmlNode lime_price_Node = root.SelectSingleNode("Lime_Price");
			lime_price_Node.InnerText = limeprice.ToString();
			XmlNode sand_price_Node = root.SelectSingleNode("Sand_Price");
			sand_price_Node.InnerText = sandprice.ToString();
			doc.Save(fPath);
			estimator = new Estimator
			{
				Cement = estimator.Cement,
				Gravel = estimator.Gravel,
				Lime = estimator.Lime,
				Sand = estimator.Sand,
				Cement_Price = cementprice,
				Lime_Price = limeprice,
				Sand_Price = sandprice,
				Gravel_Price = gravelprice
			};

		}
		
	}
	public class Estimator
    {
		private int cement;
		public int Cement
		{
			get
			{
				return cement;
			}
			set
			{
				cement = value;
			}
		}

		private int gravel;
		public int Gravel
		{
			get
			{
				return gravel;
			}
			set
			{
				gravel = value;
			}
		}

		private int sand;
		public int Sand
		{
			get
			{
				return sand;
			}
			set
			{
				sand = value;
			}
		}

		private int lime;
		public int Lime
		{
			get
			{
				return lime;
			}
			set
			{
				lime = value;
			}
		}

		private float cemnt_price;
		public float Cement_Price
        {
            get
            {
				return cemnt_price;
            }
            set
            {
				cemnt_price = value;
            }
        }
		private float gravle_price;
		public float Gravel_Price 
		{
            get
            {
				return gravle_price;
            }
            set
            {
				gravle_price = value;
            }
		}
		private float sand_price;
		public float Sand_Price
		{
			get
			{
				return sand_price;
			}
			set
			{
				sand_price = value;
			}
		}

		private float lime_price;
		public float Lime_Price
		{
			get
			{
				return lime_price;
			}
			set
			{
				lime_price = value;
			}
		}
	}
}
