
using C_Project.Controllers;
using Service.Enums;
using Service.Helpers.Extension;

GroupController groupController = new();
StudentController studentController = new();
UserController userController = new();


while (true)
{
    Menues();

    Console.WriteLine("Select :");
    Operation: string optionStr = Console.ReadLine();
    int option;
    bool isTrueOption = int.TryParse(optionStr, out option);

    if (isTrueOption)
    {
        switch (option)
        {
            case (int)AccesOperation.Login:
                userController.Login();

                while (true)
                {
                    Menues();

                 string operationStr = Console.ReadLine();
                    int operation;
                    bool isTrueOperation = int.TryParse(operationStr, out operation);

                    switch (operation)
                    {


                        case (int)GroupOperationTypes.GroupCreate:
                            groupController.Create();
                            break;
                        case (int)GroupOperationTypes.GroupDelete:
                            groupController.Delete();
                            break;
                        case (int)GroupOperationTypes.GroupEdit:
                            groupController.Edit();
                            break;
                        case (int)GroupOperationTypes.GroupGetAll:
                            groupController.GetAll();
                            break;
                        case (int)GroupOperationTypes.GroupGetById:
                            groupController.GetById();
                            break;
                        case (int)GroupOperationTypes.GroupSearch:
                            groupController.Search();
                            break;
                        case (int)GroupOperationTypes.GruopSorting:
                            groupController.Sorting();
                            break;
                        case (int)StudentsOperationTypes.StudentsCreate:
                            studentController.Create();
                            break;
                        case (int)StudentsOperationTypes.StudentsDelete:
                            studentController.Delete();
                            break;
                        case (int)StudentsOperationTypes.StudentsEdit:
                            studentController.Edit();
                            break;
                        case (int)StudentsOperationTypes.StudentsGetAll:
                            studentController.GetAll();
                            break;
                        case (int)StudentsOperationTypes.StudentsGetById:
                            studentController.GetById();
                            break;
                        case (int)StudentsOperationTypes.StudentsSearch:
                            studentController.Search();
                            break;
                        case (int)StudentsOperationTypes.StudentsFilter:
                            studentController.Filter();
                            break;
                        
                    }
                }


            case (int)AccesOperation.Register:
                userController.Register();
                break;
        }
    }
    else
    {
        Console.WriteLine("operation format is wrong, please try again");
        goto Operation;
    }
}

   
static void Menues()
{
    Console.WriteLine("(1) Login - (2) Register");
}

static void GetOperation()
{
    ConsoleColor.Green.WriteConsole("\n Group operation: 1-Create, 2-Delete, 3-Edite, 4-GetAll, 5-GetById, 6-Search, 7-Sorting ");
    ConsoleColor.Green.WriteConsole("Students operation: 1-Create, 2-Delete, 3-Edite, 4-GetAll, 5-GetById, 6-Search, 7-Filter ");
}



