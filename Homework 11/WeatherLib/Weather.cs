using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    public class Weather
    {
        private string _city;
        private string _url;
        private XDocument _document;
        private XElement _root;
        public Weather(string city)
        {
            _city = city;
            if(!CitiesStorage.CitiesCode.ContainsKey(city))
            {
                throw new Exception("City not found");
            }
            _url = @"http://informer.gismeteo.by/rss/" + CitiesStorage.CitiesCode[city] + ".xml";
            _document = XDocument.Load(_url);
            _root = _document.Root;
        }
        public void OutputWeather()
        {
            XElement element = _root.Element("channel").Elements("item").First();

            Console.WriteLine(element.Element("title").Value);
            Console.WriteLine(element.Element("description").Value);


            
        }
    }
}
