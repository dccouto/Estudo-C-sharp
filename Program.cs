using ContratroTrabalho.Entities;
using ContratroTrabalho.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratroTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com no nome do departamento: ");
            string deptoName = Console.ReadLine();
            Console.WriteLine("Entre com os dados do funcionário:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Nível (Junior/Pleno/Senior): ");
            WorkerLevel level = new WorkerLevel();
            Enum.TryParse(Console.ReadLine(), out level);

            Console.Write("Salário base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptoName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contratos para esse funcionário? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre com o contrato #{i+1}:");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuehour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Número de horas: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuehour, hours);

                worker.AddContract(contract);

            }


            Console.WriteLine("------------------------");
            Console.Write("Entre com o Mês e Ano (MM/AAAA):");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine($"Nome: {worker.Name}\nDepartamento: {worker.Department.Name}\n" +
                $"Ganhos em {mesAno}: R${worker.Income(ano,mes).ToString("F2",CultureInfo.InvariantCulture)}");



                 

        }
    }
}
