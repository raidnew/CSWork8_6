using System;
using System.Xml.Linq;

namespace Task4
{
    public struct Contact
    {
        private string _name;
        private string _streetName;
        private int _homeNumber;
        private int _flatNumber;
        private string _mobilePhone;
        private string _flatPhone;

        public void CompleteData()
        {
            _name = GetData<string>("Input name");
            _streetName = GetData<string>("Input street name");
            _homeNumber = GetData<int>("Input home number");
            _flatNumber = GetData<int>("Input flat number");
            _mobilePhone = GetData<string>("Input mobile phone");
            _flatPhone = GetData<string>("Input flat phone");
        }

        public void CreateXML(string filename)
        {
            XElement streetNameNode = new XElement("Street", _streetName);
            XElement houseNumberNode = new XElement("HouseNumber", _homeNumber);
            XElement flatNumberNode = new XElement("FlatNumber", _flatNumber);
            XElement mobilePhoneNumber = new XElement("MobliePhone", _mobilePhone);
            XElement flatPhoneNumber = new XElement("FlatPhone", _flatPhone);
            XElement addressNode = new XElement("Address", streetNameNode, houseNumberNode, flatNumberNode);
            XElement phonesNode = new XElement("Phones", mobilePhoneNumber, flatPhoneNumber);
            XElement personNode = new XElement("Person", new XAttribute("name", _name), addressNode, phonesNode);
            personNode.Save(filename);
        }
        
        private T GetData<T>(string message)
        {
            Console.WriteLine(message);
            for (;;) {
                try
                {
                    return (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Invalid input. Try again. Waiting {typeof(T)}");
                }
            }
        }
    }
}