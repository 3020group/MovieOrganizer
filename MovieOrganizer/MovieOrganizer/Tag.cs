using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieOrganizer
{
    class Tag : IComparable
    {
        private int freq;
        private string text;
        private string type;

        public Tag(XElement element)
        {
            
            freq = Int32.Parse(element.Element("frequency").Value);
            text = element.Element("text").Value;
            type = element.Element("type").Value;
            Console.WriteLine(element.Value, freq.ToString(), element.Element("text").Value, element.Element("type").Value);
        }

        int IComparable.CompareTo(object obj)
        {
            Tag t = (Tag)obj;
            return freq.CompareTo(t.Freq);
        }

        public int Freq
        {
            get { return freq; }
        }

        public string Text
        {
            get { return text; }
        }

        public string Type
        {
            get { return type; }
        }
    }
}
