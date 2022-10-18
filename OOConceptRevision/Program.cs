namespace OOConceptRevision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Employee objEmployee = new Employee();
            objEmployee.Experience = 3;
            objEmployee.CalculateSalary();
            Console.ReadLine();

            PermanentEmployee pEmployee = new PermanentEmployee();
            pEmployee.Experience = 5;
            pEmployee.CalculateSalary();
            Console.ReadLine();

        }



        public class Employee
        {
            public Employee(){
            }

            private int experience;

            public int Experience 
            {
                get 
                { return experience;
                }
                set {
                    experience = value;
                }
            }

            public void CalculateSalary()
            {
                int salary = Experience * 10;
                Console.WriteLine("salary:{0}", salary);
            }


        }

        public class PermanentEmployee: Employee
        {

        }


    }
}