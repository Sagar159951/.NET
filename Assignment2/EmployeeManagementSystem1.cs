using System;
public class Employee
{
    private int _EmpNo;
    private string _EmpName;
    private double _Salary;
    private double _HRA;
    private double _TA;
    private double _DA;
    private double _PF;
    private double _TDS;
    private double _NetSalary;
    private double _GrossSalary;
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
        emp.DisplayGrossSalary();
    }
}