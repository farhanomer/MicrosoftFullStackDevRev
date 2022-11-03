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

            // CalculateSalary() Method is not in present in PermanentEmployee Class, but it will inherit automatically from it Parent
            pEmployee.CalculateSalary();
            Console.ReadLine();



            //Interface Invoking Method
            InterfaceStaticMethodDemo.InterfaceStaticMethod();

            //Single Inheritance
            Forest objForest = new Forest();
            objForest.Animal();

            Jungle objJungle = new Jungle();
            objJungle.Animal();
            objJungle.Dog();


            Forest objForest1 = new Jungle();
            objForest1.Animal();

            // Explicit Conversion from Parent to Child
            // Will Through Casting Error because it violates OOP rules

            // Child Variable Cannot hold Parent Variable
            Jungle objJungle1 = (Jungle)new Forest();

            objJungle1.Dog();
            objJungle1.Animal();


            //Parent Variable Can hold Child Variable
            Forest objForest2 = new Jungle();

            objForest2.Animal();





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

        public class Forest
        {
            public virtual void Animal()
            {
                Console.WriteLine("Animal From Forest");
            }

        }
        public class Jungle : Forest
        {

            public void Dog()
            {

                Console.WriteLine("Dog from Jungle");

            }

            public override void Animal()
            {

                Console.WriteLine("Animal  from Jungle");
            }


        }

        //public sealed class PreventInheritance
        //{

        //}
        //public class TryInheritSealedClass : PreventInheritance
        //{

        //}




    }
}