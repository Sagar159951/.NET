using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace LitwareLib
{
    public interface IPrintable
    {
        void Print();
    }

    public class Employee : IPrintable
    {
        protected int _EmpNo;
        protected string _EmpName;
        protected double _Salary;
        protected double _HRA;
        protected double _TA;
        protected double _DA;
        protected double _PF;
        protected double _TDS;
        protected double _NetSalary;
        protected double _GrossSalary;
        public int EmpNo
        {
            get { return _EmpNo; }
            set { _EmpNo = value; }
        }
        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }
        public void SetSalary(double salary)
        {
            _Salary = salary;
            if (_Salary < 5000)
            {
                _HRA = _Salary * 0.1;
                _TA = _Salary * 0.05;
                _DA = _Salary * 0.15;
            }
            else if (_Salary < 10000)
            {
                _HRA = _Salary * 0.15;
                _TA = _Salary * 0.10;
                _DA = _Salary * 0.20;
            }
            else if (_Salary < 15000)
            {
                _HRA = _Salary * 0.2;
                _TA = _Salary * 0.15;
                _DA = _Salary * 0.25;
            }
            else if (_Salary < 20000)
            {
                _HRA = _Salary * 0.25;
                _TA = _Salary * 0.20;
                _DA = _Salary * 0.30;
            }
            else
            {
                _HRA = _Salary * 0.30;
                _TA = _Salary * 0.25;
                _DA = _Salary * 0.35;
            }
            _GrossSalary = _Salary + _HRA + _TA + _DA;
        }
        public double GetSalary()
        {
            return _Salary;
        }
        public void CalculateSalary()
        {
            _PF = _GrossSalary * 0.10;
            _TDS = _GrossSalary * 0.18;
            _NetSalary = _GrossSalary - (_PF + _TDS);
        }

        public void DisplayGrossSalary()
        {
            Console.WriteLine("Employee's Gross Salary is : {0}", _GrossSalary);
        }

        public void Print()
        {
            Console.WriteLine("Employee name : {0}", EmpName);
            Console.WriteLine("Employee net Salary : {0}", _NetSalary);
        }
    }

    [Serializable()]
    public class Manager : Employee
    {
        private double _PetrolAllowance, _FoodAllowance, _OtherAllowance;
        public Manager()
        {
            _PetrolAllowance = _Salary * 0.08;
            _FoodAllowance = _Salary * 0.13;
            _OtherAllowance = _Salary * 0.03;
            _GrossSalary = _PetrolAllowance + _FoodAllowance + _OtherAllowance;
        }

        public virtual void CalculateSalary()
        {
            _PF = _GrossSalary * 0.10;
            _TDS = _GrossSalary * 0.18;
            _NetSalary = _GrossSalary - (_PF + _TDS);
        }

        public void Print()
        {
            Console.WriteLine("Manager name : {0}", EmpName);
            Console.WriteLine("Manager net Salary : {0}", _NetSalary);
        }
    }


    public class Program
    {
        public static void Main()
        {
            Manager mg = new Manager();
            Console.WriteLine("Enetr the Employee id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Salary: ");
            double salary = double.Parse(Console.ReadLine());
            mg.EmpNo = id;
            mg.EmpName = name;
            mg.SetSalary(salary);
            mg.Print();

            //making class manager serializable
            FileStream fs = new FileStream(@"C:\User\Sagar\Desktop\Sample\sample.odl", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, mg);
            fs.Close();

            //making class manager deserializable
            Manager mg2;
            FileStream fs2 = new FileStream(@"C:\User\Sagar\Desktop\Sample\sample.odl", FileMode.OpenOrCreate);
            BinaryFormatter bf2 = new BinaryFormatter();
            mg2 = (Manager)bf2.Deserialize(fs2);
            fs2.Close();
        }
    }
}
