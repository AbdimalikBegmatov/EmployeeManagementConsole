using EmployeeManagementConsole;

EmployeeManagement employeeManagement = new();
bool stopProgram = true;

while (stopProgram)
{
    Console.WriteLine("----------------------------------------------------------------------");
    Console.WriteLine("Choose action with Employees");
	Console.WriteLine("1. Add new Employee, 2. Delete Employee, 3. Get all Employees, 4. Exit");


    int action = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("----------------------------------------------------------------------");

    switch (action)
	{
		case 1:
			employeeManagement.AddEmployee();
			break;
		case 2:
			Console.WriteLine("Write id employee to delete");
			var result = employeeManagement.RemoveEmployee(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(result);
            break;
		case 3:
			employeeManagement.GetAllEmployees();
			break;
		default:
			stopProgram=false;
			break;
	}
    Console.WriteLine("-----------------------------------------------------------------------");
}