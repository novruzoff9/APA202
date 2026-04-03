using _04._02.Models;

Mytask task1 = new Mytask()
{
    Title = "Task 1",
    Explanation = "This is the first task.",
    DeadLine = DateTime.Now.AddDays(10),
    TaskStatus = TaskStatus.Created
};


TaskService taskService = new TaskService();


try
{
taskService.GetTask("Oxumursunuz");
Console.WriteLine("Task added successfully.");

}
catch (Exception)
{
    Console.WriteLine( "Task tapilmadi");
}


