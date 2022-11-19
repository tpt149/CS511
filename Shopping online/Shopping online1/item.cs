using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Shopping_online1
{
    internal class item
    {
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private string fileName = @"C:\Code\C#\CS511\Shopping online\Shopping online1\feedback.xml";
        public item()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(orders order, string a, string b, string c)
        {
            XmlNode item = doc.CreateElement("item");

            XmlElement Name_ = doc.CreateElement(a);
            Name_.InnerText = order.Name;
            item.AppendChild(Name_);

            XmlElement Price_ = doc.CreateElement(b);
            Price_.InnerText = order.Star.ToString();
            item.AppendChild(Price_);

            XmlElement Sl_ = doc.CreateElement(c);
            Sl_.InnerText = order.Feedback.ToString();
            item.AppendChild(Sl_);

            root.AppendChild(item);
            doc.Save(fileName);
        }
    }
}
