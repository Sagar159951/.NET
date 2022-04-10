using System;
namespace customAttribute
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class SoftwareAttribute : Attribute
    {
        private string _ProjectName;
        private string _Description;
        private string _ClientName;
        private string _StartedDate;
        private string _EndDate;

        public string ProjectName { get { return _ProjectName; } set { _ProjectName = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public string ClientName { get { return _ClientName; } set { _ClientName = value; } }
        public string StartDate { get { return _StartedDate; } set { _StartedDate = value; } }
        public string EndDate { get { return _EndDate; } set { _EndDate = value; } }

    }
    [Software()]
    public class HDFCAccount
    {
        public int accNum { get; set; }

    }
    [Software()]
    public class ICICIAccount
    {
        public int accNum { get; set; }
    }

    public class Test
    {
        public static void Testing()
        {
            printAttribute(typeof(HDFCAccount));
            printAttribute(typeof(ICICIAccount));
        }

        static void printAttribute(Type T)
        {
            Attribute[] ats = Attribute.GetCustomAttributes(T);
            foreach (Attribute a in ats)
            {
                Console.WriteLine(a.GetType().Name);
            }
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            Test.Testing();
        }
    }
        
    

}
