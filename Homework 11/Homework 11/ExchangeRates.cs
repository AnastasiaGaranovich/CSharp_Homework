using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1
{
    internal class ExchangeRates
    {
        private string _url;
        private XDocument _document;
        private XElement _root;

        public ExchangeRates()
        {
            _url = @"http://www.nbrb.by/Services/XmlExRates.aspx";
            _document = XDocument.Load(_url);
            _root = _document.Root;
        }

        public void FindExchangeRate(string charCode)
        {
            Console.WriteLine($"Date: {_root.Attribute("Date").Value}");

            foreach (var element in _root.Elements("Currency"))
            {

                if(charCode == element.Element("CharCode").Value)
                {
                    Console.WriteLine($"{element.Element("Scale").Value} " + 
                                      $" {element.Element("CharCode").Value} = " + 
                                      $"{element.Element("Rate").Value} BYN");
                    return;
                }
            }
            Console.WriteLine("There is no such currency");

        }
    }
}
