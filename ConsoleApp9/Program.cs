using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class employee
    {
        int empid;
        string name;
        string address;
        string city;
        string emptype;
        double salary = 25000;
        public int EmpId
        {
            get { return empid; }
            set { empid = value; }
        }
        public string Name
        {
            get { return Name; }
            set { name = value; }

        }
        public string department
        {
            get { return department; }
            set { department = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public double Salary
        {
            get { return salary; }
        }
        public virtual double GetSalary()
        {
            return salary;
        }
        public string EmpType
        {
            get { return emptype; }
            set { emptype = value; }
        }
        public virtual void Accept()
        {
            Console.WriteLine("Base accept");
        }

        public virtual void Display()
        {
            Console.WriteLine("base display");

        }
    }
    class PermanentEmployee: employee
    {
        int leaves;
        double pf;
        public int Leaves
        {
            get { return leaves; }
            set { leaves = value; }

        }
        public double PF
        {
            get { return pf; }
            set { pf = value; }
        }
        public override double GetSalary()
        {
            return base.GetSalary() + pf;
        }
        public override void Accept()
        {
            Console.WriteLine("enter employee id:");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name:");
            Name = Console.ReadLine();
            Console.WriteLine("enter employee department");
            department = Console.ReadLine();
            Console.WriteLine("enter employee address");
            Address = Console.ReadLine();
            Console.WriteLine("enter employee city");
            City = Console.ReadLine();
            Console.WriteLine("enter employee pf");
            pf=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter employee leaves");
            leaves = int.Parse(Console.ReadLine());







        }
        public override void Display()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("employee details");
            Console.WriteLine("----------------------------");
            Console.WriteLine("emp Id:{0}", EmpId);
            Console.WriteLine("name:{0}", Name);
            Console.WriteLine("department:{0}", department);
            Console.WriteLine("employee type:{0}", EmpType);
            Console.WriteLine("address:{0}", Address);
            Console.WriteLine("city:{0}", City);
            Console.WriteLine("pf:{0}", pf);
            Console.WriteLine("leaves:{0}",leaves);
            Console.WriteLine("total salary:{0}",GetSalary());

        }
    }
    class ContractEmployee:employee
    {
        double perk;
        public double Perk
        {
            get { return perk; }
            set { perk = value; }
        }
        public override double GetSalary()
        {
            return base.GetSalary()+perk;
        }
        public override void Accept()
        {
            Console.WriteLine("Contract accept called");
            Console.WriteLine("enter employee ID");
            EmpId=int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name");
            Name=Console.ReadLine();
            Console.WriteLine("enter employee department");
            department = Console.ReadLine();
            Console.WriteLine("enter employee address");
            Address = Console.ReadLine();
            Console.WriteLine("enter employee city");
            City = Console.ReadLine();
            Console.WriteLine("enter employee perk");
            perk = Convert.ToDouble(Console.ReadLine());



        }
        public override void Display()
        {
            Console.WriteLine("_---------------------");
            Console.WriteLine("employee Details");
            Console.WriteLine("----------------");
            Console.WriteLine("emp id:{0}", EmpId);
            Console.WriteLine("name:{0}", Name);
            Console.WriteLine("department :{0}", department);
            Console.WriteLine("employee type:{0}", EmpType);
            Console.WriteLine("address:{0}", Address);
            Console.WriteLine("city:{0}", City);
            Console.WriteLine("perk:{0}", perk);
            Console.WriteLine("total salary:{0}",GetSalary()); 
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            int ch;
            do
            {
            EmployeeType:
                employee emp;
                Console.WriteLine("select type of employee:\n1.permanent employyee\n2.comtract employee");
                ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    emp = new PermanentEmployee();
                    emp.EmpType = "permanent employee";
                }
                else if (ch == 2)
                {
                    emp = new ContractEmployee();
                    emp.EmpType = "contract employee";

                }
                else
                {
                    Console.WriteLine("wrong choice");
                    goto EmployeeType;
                }
            OperationType:
                Console.WriteLine("--------------");
                Console.WriteLine("select your choice:\n1.insert employee details.\n2.display employee details\n3.switch emp type\n4.exit");
                ch = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------");
                switch (ch)
                {
                    case 1:
                        emp.Accept();
                        goto OperationType;
                    case 2:
                        emp.Display();
                        goto OperationType;
                    case 3:
                        goto EmployeeType;
                    default:
                        Console.WriteLine("wrong choice");
                        goto OperationType;
                }
            }
            while (ch != 4);
    }
        
    }
}
