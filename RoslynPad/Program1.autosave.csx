// Console.WriteLine(default(DateTime));
// 
// Console.WriteLine(default(Guid));

public class OneTask
{
    public string IsDeleted = null;
}

OneTask oneTask = new OneTask();

if (String.IsNullOrWhiteSpace(oneTask.IsDeleted))
{
    Console.WriteLine("Gotcha!");
}
else
{
    Console.WriteLine("nothing");
}

Console.WriteLine("done");