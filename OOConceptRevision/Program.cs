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

            // CalculateSalary() Method is not in present in PermanentEmployee Class, but it will inherit automatically from it Paremy
            pEmployee.CalculateSalary();
            Console.ReadLine();



            //Interface Invoking Method
            InterfaceStaticMethodDemo.InterfaceStaticMethod();

        }

        /// <summary>
        ///  Interface with Static Method
        /// </summary>

        interface InterfaceStaticMethodDemo
        {
            static void InterfaceStaticMethod()
            {
                Console.WriteLine("TEST STATIC METHOD IN INTERFACE");

            }

        }

        public class Shape : InterfaceStaticMethodDemo
        {

            public Shape()
            {
                Console.WriteLine("From Shape Constructor ");
            }



        }



        /// <summary>
        /// Base/Parent/Super Class
        /// </summary>
        public class Employee
        {

            public Employee()
            {
            }

            private int experience;

            public int Experience
            {
                get
                {
                    return experience;
                }
                set
                {
                    experience = value;
                }
            }

            public void CalculateSalary()
            {
                int salary = Experience * 10;
                Console.WriteLine("salary:{0}", salary);
            }


        }

        /// <summary>
        /// Derived/Child/Sub Class
        /// </summary>
        public class PermanentEmployee : Employee
        {

        }

        public class ContractEmployee : Employee
        {


        }




    }
}