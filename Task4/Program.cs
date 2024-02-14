namespace Task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Contact contact = new Contact();
            contact.CompleteData();
            contact.CreateXML("test.xml");
        }
    }
}