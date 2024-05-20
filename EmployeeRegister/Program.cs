using EmployeeRegister.model;
/*
 * 
 * Jag valde att ha en klass som skulle representera de anställda, Employee.
 * Den klassen ligger i en mapp som heter "models"
 * 
 * Jag skapade även en psudo-pepository-klass där jag tänkte ha listan med anställda.
 * Men jag fick inte riktigt ihop det. Istället ligger listan här i Program-klassen.
 * 
 * Jag såg till så att det inte gick att registrera en anställd med en lön som är mindre eller lika med noll.
 * Det går inte heller att se alla anställda om det inte finns några anställda.
 * 
 * Det jag undrar lite är är detta bra kod? Är den för nästlad?
 * 
 * Jag har inte heller så mycket metoder angående Employee. Jag använder mest bara konstruktorn.
 * 
 * Aja. Det var en kul uppgift :)
 */

namespace EmployeeRegister {
    internal class Program {

        static void Main(string[] args) {

            string selectedAction;
            List<Employee> employees = new List<Employee>();
            
            do {
                PrintMenu();
                selectedAction = Console.ReadLine();

                switch (selectedAction) {
                    case "1":
                        Console.WriteLine("Ange namn.");
                        string employeeName = Console.ReadLine();

                        Console.WriteLine("Ange lön.");
                        int salary = int.Parse(Console.ReadLine());

                        while(salary <= 0) {
                            Console.WriteLine("Det går inte att ange en lön som är mindre eller lika med 0.");
                            Console.WriteLine("Ange lön igen.");
                            salary = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                        }

                        employees.Add(new Employee(employeeName, salary));
                        break;
                    case "2":
                        if (!employees.Any()) {
                            Console.WriteLine("Det finns ingen registerad personal.");
                            Console.WriteLine("Börja med att registera användare.");
                            Console.WriteLine("");
                        } else {
                            PrintEmployeeInfo(employees);
                        }
                        break;
                }

            } while (selectedAction != "0");
        }
        private static void PrintMenu() {
            Console.WriteLine("Välkommen till personalregistret.");
            Console.WriteLine("");
            Console.WriteLine("Här kommer de alternativ du kan genomföra.");
            Console.WriteLine("1. Registrera en anställd med namn och lön.");
            Console.WriteLine("2. Skriva ut en lista på alla anställda och deras löner.");
            Console.WriteLine("0. Avsluta programmet.");
            Console.WriteLine("Mata in siffran som representerar den handling du vill utföra.");
        }

        private static void PrintEmployeeInfo(List<Employee> employees) {
            foreach (Employee employee in employees) {
                Console.WriteLine("Namn: " + employee.Name);
                Console.WriteLine("Lön: " + employee.Salary);
                Console.WriteLine("");
            }
        }


    }
}
