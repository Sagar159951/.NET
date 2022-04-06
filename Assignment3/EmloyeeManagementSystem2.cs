using System;
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
        public void virtual CalculateSalary()
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

        public void override CalculateSalary()
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

    public class MarketingExecutive : Employee
    {
        private double _KilometerTravel, _TourAllowance;
        int _TelephoneAllowance = 1000;
        public double GetKilometerTravel()
        {
            return _KilometerTravel;
        }
        public void SetKilometerTravel(double KilometerTravel)
        {
            this._KilometerTravel = KilometerTravel;
            this._TourAllowance = 5 * _KilometerTravel;
            _GrossSalary = _Salary + _TourAllowance + _TelephoneAllowance;
        }

        public void override CalculateSalary()
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
            Employee emp = new Employee();
            try
            {
                Console.WriteLine("Enetr the Employee id: ");
                int id = int.Parse(Console.ReadLine());
                if (id < 0)
                {
                    throw new Exception();
                }
                emp.EmpNo = id;
            }
            catch (Exception e)
            {
                Console.WriteLine("id cannot be negative");
                return;
            }

            try
            {
                Console.WriteLine("Enter the Employee Name: ");
                string name = Console.ReadLine();
                if (name == null || name == "")
                {
                    throw new Exception();
                }
                emp.EmpName = name;
            }
            catch (Exception e)
            {
                Console.WriteLine("Name cannot be null");
                return;
            }

            try
            {
                Console.WriteLine("Enter the Salary: ");
                double salary = double.Parse(Console.ReadLine());
                if (salary <= 0)
                {
                    throw new Exception();
                }
                emp.SetSalary(salary);
            }
            catch (Exception e)
            {
                Console.WriteLine("salary cannot be negative or zero");
                return;
            }
            emp.CalculateSalary();
            emp.DisplayGrossSalary();

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
            emp.CalculateSalary();
            mg.Print();

            MarketingExecutive me = new MarketingExecutive();
            Console.WriteLine("Enetr the Employee id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter kilometer travelled: ");
            double kmtv = double.Parse(Console.ReadLine());
            me.EmpNo = id;
            me.EmpName = name;
            me.SetSalary(salary);
            me.SetKilometerTravel(kmtv);
            me.CalculateSalary();
            me.Print();
        }
    }
}
