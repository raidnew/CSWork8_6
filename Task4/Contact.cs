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

        public void CreateXML()
        {
            XElement personNode = new XElement("Person");
            XElement addressNode = new XElement("Address");
            XElement phonesNode = new XElement("Phones");
            XElement streetNameNode = new XElement("Street");
            XElement houseNumberNode = new XElement("HouseNumber");
            XElement flatNumberNode = new XElement("FlatNumber");
            XElement mobilePhoneNumber = new XElement("MobliePhone");
            XElement flatPhoneNumber = new XElement("FlatPhone");

            personNode.SetAttributeValue("name", _name);
            
            streetNameNode.SetValue(_streetName);
            houseNumberNode.SetValue(_homeNumber);
            flatNumberNode.SetValue(_flatNumber);
            
            addressNode.Add(streetNameNode);
            addressNode.Add(houseNumberNode);
            addressNode.Add(flatNumberNode);
            
            mobilePhoneNumber.SetValue(_mobilePhone);
            flatPhoneNumber.SetValue(_flatPhone);
            
            phonesNode.Add(mobilePhoneNumber);
            phonesNode.Add(flatPhoneNumber);

            personNode.Add(addressNode);
            personNode.Add(phonesNode);
            
            personNode.Save("test.xml");
        }
        
        private T GetData<T>(string message)
        {
            T data;
            Console.WriteLine(message);
            for (;;) {
                try
                {
                    data = (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
                    return data;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Invalid input. Try again. Waiting {typeof(T)}");
                }
            }
        }
    }
}