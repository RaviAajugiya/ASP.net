using System.Collections;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> objEmployee = new List<Employee>()
            {
                new Employee(){ Name="Akshay Tyagi", Department="IT", Country="India"},
                new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},
                new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},
                new Employee(){ Name="Shubham Ratogi", Department="Sales", Country="USA"},
                new Employee(){ Name="Shubham Ratogi1", Department="IT", Country="Canada"}
            };
            //objEmployee.ToLookup() method is used to print the value of the data in the pair/collection of items.  
            //var Emp = objEmployee.ToLookup(x => x.Department);
            //console.writeline("grouping employees by department");
            //console.writeline("---------------------------------");
            //foreach (var keyvalurpair in emp)
            //{
            //    console.writeline(keyvalurpair.key);
            //    //lookup employees by department
            //    foreach (var item in emp[keyvalurpair.key])
            //    {
            //        console.writeline("\t" + item.name + "\t" + item.department + "\t" + item.country);
            //    }
            //}


            ArrayList al = new ArrayList();
            al.Add("name1");
            al.Add("name2");
            al.Add(5);


            IEnumerable<string> result = al.Cast<string>();
            IEnumerable<string> result1 = al.OfType<string>();

            List<int> li = new List<int>() { 1,2,3,4,5,6,7};
            Console.WriteLine(li.GetType());
            var result2 = li.AsEnumerable();

            var result3 = objEmployee.ToDictionary(x => x.Country, x => x.Name);
            var result4 = objEmployee.Single(x => x.Name == "Shubham Ratogi");
            Console.WriteLine(result4.Country);

            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item.Name + " " + item.Country);
            //}

        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
    }
}