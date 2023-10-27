using EmployeeOOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Declaración de variables
                int day, month, year;
                string firstName, lastName;
                decimal salary;

                Date dateObjet; // Declarar dateObjet fuera de los bloques try
                Date dateObjetHourly; // Declarar dateObjetHourly fuera de los bloques try
                Date dateObjetCommission; // Declarar dateObjetCommission fuera de los bloques try

                Console.WriteLine("OPP APPLICATION");
                Console.WriteLine("---------------");

                // DATOS EMPLEADO ASALARIADO
                Console.WriteLine("DATOS EMPLEADO ASALARIADO");
                Console.WriteLine("---------------");

                Console.Write("Ingresar el día de nacimiento: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el mes de nacimiento: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año de nacimiento: ");
                year = Convert.ToInt32(Console.ReadLine());

                dateObjet = new Date(day, month, year); // Inicializar dateObjet

                Console.WriteLine("\nFecha de Nacimiento:");
                Console.WriteLine(dateObjet.ToString());

                Console.Write("Ingresar Nombres: ");
                firstName = Console.ReadLine();
                Console.Write("Ingresar Apellidos: ");
                lastName = Console.ReadLine();
                Console.Write("Ingresar Salario: ");
                salary = Convert.ToDecimal(Console.ReadLine());

                // Crear un objeto SalaryEmployee
                SalaryEmployee salaryEmployee = new SalaryEmployee()
                {
                    Id = 123456,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObjet, // Usar la fecha de nacimiento proporcionada
                    HiringDate = dateObjet, // Usar la fecha de contratación original
                    IsAcvtive = true,
                    Salary = salary
                };

                Console.WriteLine(salaryEmployee);

                Console.WriteLine("\n-------------------------\n"); // Dejar un espacio entre empleados

                // DATOS EMPLEADO POR HORAS
                Console.WriteLine("DATOS EMPLEADO POR HORAS");
                Console.WriteLine("---------------");

                Console.Write("Ingresar el día de nacimiento: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el mes de nacimiento: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año de nacimiento: ");
                year = Convert.ToInt32(Console.ReadLine());

                dateObjetHourly = new Date(day, month, year); // Inicializar dateObjetHourly

                Console.WriteLine("\nFecha de Nacimiento:");
                Console.WriteLine(dateObjetHourly.ToString());

                Console.Write("Ingresar Nombres: ");
                firstName = Console.ReadLine();
                Console.Write("Ingresar Apellidos: ");
                lastName = Console.ReadLine();
                Console.Write("Ingresar Horas trabajadas: ");
                decimal hoursWorked = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Ingresar Valor por hora: ");
                decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());

                // Crear un objeto HourlyEmployee
                HourlyEmployee hourlyEmployee = new HourlyEmployee()
                {
                    Id = 1234462,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObjetHourly, // Usar la fecha de nacimiento proporcionada
                    HiringDate = dateObjetHourly, // Usar la fecha de contratación original
                    IsAcvtive = true,
                    Hours = hoursWorked,
                    HourValue = hourlyRate
                };

                // Calcular el salario por horas y mostrarlo
                decimal hourlySalary = hourlyEmployee.GetValueToPay();
                Console.WriteLine(hourlyEmployee);
                Console.WriteLine($"Salario calculado: {hourlySalary:C2}");

                Console.WriteLine("\n-------------------------\n"); // Dejar un espacio entre empleados

                // DATOS EMPLEADO POR COMISIÓN
                Console.WriteLine("DATOS EMPLEADO POR COMISIÓN");
                Console.WriteLine("---------------");

                Console.Write("Ingresar el día de nacimiento: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el mes de nacimiento: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año de nacimiento: ");
                year = Convert.ToInt32(Console.ReadLine());

                dateObjetCommission = new Date(day, month, year); // Inicializar dateObjetCommission

                Console.WriteLine("\nFecha de Nacimiento:");
                Console.WriteLine(dateObjetCommission.ToString());

                Console.Write("Ingresar Nombres: ");
                firstName = Console.ReadLine();
                Console.Write("Ingresar Apellidos: ");
                lastName = Console.ReadLine();
                Console.Write("Ingresar Porcentaje de Comisión: ");
                decimal commissionPercentage = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Ingresar Ventas realizadas: ");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                // Crear un objeto CommissionEmployee
                CommissionEmployee commissionEmployee = new CommissionEmployee()
                {
                    Id = 7890123,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObjetCommission, // Usar la fecha de nacimiento proporcionada
                    HiringDate = dateObjetCommission, // Usar la fecha de contratación original
                    IsAcvtive = true,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales
                };

                // Calcular el salario por comisión y mostrarlo
                decimal commissionSalary = commissionEmployee.GetValueToPay();
                Console.WriteLine(commissionEmployee);
                Console.WriteLine($"Salario calculado: {commissionSalary:C2}");
                Console.WriteLine("\n-------------------------\n"); // Dejar un espacio entre empleados
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
