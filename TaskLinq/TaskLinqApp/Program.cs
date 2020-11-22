using System;
using System.Collections.Generic;
using TaskLinqLib;
using System.Linq; 

namespace TaskLinqApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Repository repository = new Repository();
			var employees = repository.GetEmployees();
			var departments = repository.GetDepartments();

			// 1. Вывести зарплату только менеджеров
			// Вывод - Name, Position, Salary
			var managers = from employee in employees where employee.Position == "Manager" select employee;
            Console.WriteLine("Print salaries of managers only");
			foreach(EmployeeInfo manager in managers)
            {
				Console.WriteLine($"Name: {manager.Name}, Position: {manager.Position}, Salary: {manager.Salary}");
			}
            Console.WriteLine();

			// 2. Вывести среднюю зарплату по должностям. Сортировка по зарплате
			// Вывод - Position, Salary
			var positionGroup = from employee in employees group employee.Salary by employee.Position;
            Console.WriteLine("Print average salary on positions. Sort by salary");
			foreach (IGrouping<string, decimal> group in positionGroup)
			{
				Console.WriteLine($"Position: {group.Key}");
                Console.WriteLine($"Average salary: {group.Average()}");
			}
            Console.WriteLine();

			// 3. Вывести информацию о сотруднике с выводом Name его начальника
			// Вывод - Name, Position, ChieName
			var workers = from employee in employees where employee.ParentId != 0 select employee;
            Console.WriteLine("Display information about an employee with the output of the Name of his boss");
			foreach(EmployeeInfo worker in workers)
            {
				var boss = from employee in employees where employee.Id == worker.ParentId select employee;
				Console.WriteLine($"Name: {worker.Name}, Position: {worker.Position}, Boss: {boss.First().Name}");
			}
            Console.WriteLine();

            // 4. Вывести информацию об отделах  с выводом информации  - кол-во сотрудников в данном отделе, суммарной ЗП отдела
            // Вывод - DepartmentName, CountEmployees, TotalSalary
            Console.WriteLine("Department information - workers count in department, summ of salaries");
			foreach(DepartmentInfo department in departments)
            {
				var departmentWorkers = from employee in employees where employee.DepartmentId == department.Id select employee;
				decimal sumSalary = departmentWorkers.Sum(employee => employee.Salary);
				Console.WriteLine($"Department: {department.Name}, Employee count: {departmentWorkers.Count()}, Summ salary: {sumSalary}");
			}
            Console.WriteLine();

			// 5. Вывести информацию о сотрудниках отдела, который был создан самым  последним
			// Вывод - DepartmentName, DateCreated, Список сотрудников (Name, Position)
			DateTime date = departments.Max(department => department.DateCreated);
			var newestDepartment = (from department in departments where department.DateCreated == date select department).First();
            Console.WriteLine("Information about workers of latest created department");
            Console.WriteLine($"Department: {newestDepartment.Name}, Created date: {newestDepartment.DateCreated}");
			var departmentEmployees = from employee in employees where employee.DepartmentId == newestDepartment.Id select employee;
			foreach(EmployeeInfo employee in departmentEmployees)
            {
                Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}");
            }
            Console.WriteLine();

			// 6. Вевести информацию о должностях отделов, которые были созданы в марте и феврале 2010 года
			// Сортировка по наименованию отдела, дате создания, должности
			// Вывод - DepartmentName,DateCreated, Список должностей
			var DepartmentFebMar = from department in departments where department.DateCreated.Year == 2010 
								   && (department.DateCreated.Month == 02 || department.DateCreated.Month == 03)
								   select department;
            Console.WriteLine("Display information about department positions that were created in March and February 2010");
			foreach(DepartmentInfo department in DepartmentFebMar)
            {
                Console.WriteLine($"Department name: {department.Name}, Created date: {department.DateCreated}");
				var positions = from employee in employees where employee.DepartmentId == department.Id select employee.Position;
				foreach(string position in positions)
                {
					Console.WriteLine(position);
				}
			}
            Console.WriteLine();
			Console.ReadKey();
		}
	}
}
