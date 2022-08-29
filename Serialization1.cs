using System; 
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 
using System.Xml.Serialization;

namespace Assignment1
{
   public class Serialization1
    {
        public static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { EmpName = "Ramesh", EmpAddress = "Mysore", EmpSalary = 56000 });
            empList.Add(new Employee { EmpName = "Aravind", EmpAddress = "Tumkur", EmpSalary = 46000 });
            empList.Add(new Employee { EmpName = "Suresh", EmpAddress = "Dharwad", EmpSalary = 56000 });
            empList.Add(new Employee { EmpName = "Gopal", EmpAddress = "Chennai", EmpSalary = 45000 });
            saveAsXml(empList);

            empList = loadXmlData();
            foreach (var emp in empList) Console.WriteLine(emp.EmpName);
        }

        static void BinarySave(Employee emp)
        {
          
            FileStream fs = new FileStream("Emp.bin", FileMode.OpenOrCreate, FileAccess.Write);
            
            BinaryFormatter fm = new BinaryFormatter();
            fm.Serialize(fs, emp);
            fs.Close();
        }

        static void ReadData()
        {
           
            FileStream fs = new FileStream("Emp.bin", FileMode.Open, FileAccess.Read);
            
            BinaryFormatter fm = new BinaryFormatter();
            object data = fm.Deserialize(fs);
            fs.Close();
            if (data is Employee)
            {
                var emp = data as Employee;
                Console.WriteLine(emp);
            }

        }

        static Employee createEmployee()
        {
            var id = Util.GetNumber("Enter the ID of the Employee");
            var name = Util.GetString("Enter the Name of the Employee");
            var address = Util.GetString("Enter the Address of the Employee");
            var salary = Util.GetNumber("Enter the Salary");
            var emp = new Employee(id)
            {
                EmpName = name,
                EmpAddress = address,
                EmpSalary = salary
            };

            return emp;
        }

        static void saveAsXml(List<Employee> empList)
        {
            var fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.Write);
            var formatter = new XmlSerializer(typeof(List<Employee>));//Should privide the Type Info of the class that U R serializing. 
            formatter.Serialize(fs, empList);
            fs.Close();
        }

        static List<Employee> loadXmlData()
        {
            var fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            var formatter = new XmlSerializer(typeof(List<Employee>));//Should privide the Type Info of the class that U R serializing. 
            var list = formatter.Deserialize(fs) as List<Employee>;
            fs.Close();
            return list;
        }
    
    }
    public class Employee
    {
        public Employee()
        {

        }
       public  Employee(int empId)
        {
            Id = empId;

        }
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress{ get; set; }
        public int EmpSalary{ get; set; }
    }
    class Util
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetNumber(string question)
        {
            return int.Parse(GetString(question));
        }
        public static short GetShortNumber(string question) => short.Parse(GetString(question));

        public static double GetDoubleNumber(string question) => double.Parse(GetString(question));
    }
}