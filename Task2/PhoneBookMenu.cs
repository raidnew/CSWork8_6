using System;

namespace Task2
{
    public class PhoneBookMenu
    {
        public static Action<string, string> OnAddItem;
        public static Func<string, string> OnSearchByPhoneNumber;

        public PhoneBookMenu()
        {
            AddNewItem();
            SearchItemByPhoneNumber();
        }
        
        private void AddNewItem()
        {
            string phoneNumber, userName;

            for (;;)
            {
                phoneNumber = GetString("Input phone number. (Empty for next step) :");
                if (phoneNumber == "") break;
                phoneNumber = GetString("Input user name:");
                userName = Console.ReadLine();
                OnAddItem?.Invoke(phoneNumber, userName);
            }
        }

        private void SearchItemByPhoneNumber()
        {
            for (;;)
            {
                
                string phoneNumber = GetString("Input phone number for search (Empty for exit) :");
                if (phoneNumber == "") break;
                
                string userName = OnSearchByPhoneNumber?.Invoke(phoneNumber);
                if(userName == null)
                    Console.WriteLine("Phone number hasn`t found.");
                else
                    Console.WriteLine(userName);
            }
        }

        private string GetString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }

}