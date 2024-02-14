using System;
using System.Collections.Generic;

namespace Task2
{
    public class PhoneBook
    {

        private Dictionary<string, string> _data;
        
        public PhoneBook()
        {
            _data = new Dictionary<string, string>();
            PhoneBookMenu.OnAddItem += AddItem;
            PhoneBookMenu.OnSearchByPhoneNumber += GetNameByPhoneNumber;
        }

        ~PhoneBook()
        {
            
        }

        public void Test()
        {
            AddItem("+79998881", "Name1");
            AddItem("+79998882", "Name1");
            AddItem("+79998883", "Name1");
            AddItem("+79998884", "Name1");
            AddItem("+7999882", "Name2");
            AddItem("+7999883", "Name3");
            AddItem("+7999884", "Name4");

            Console.WriteLine(GetNameByPhoneNumber("+7999884"));
            Console.WriteLine(GetNameByPhoneNumber("+79998881"));
            Console.WriteLine(GetNameByPhoneNumber("+79998882"));
            Console.WriteLine(GetNameByPhoneNumber("+99999999"));
        }

        private string GetNameByPhoneNumber(string phoneNumber)
        {
            if(_data.ContainsKey(phoneNumber))
                return _data[phoneNumber];
            return null;
        }
        
        private void AddItem(string phoneNumber, string fullName)
        {
            _data.Add(phoneNumber, fullName);
        }
            
        
    }
}