int[] nums = { 1,2,3,4,5,6,7,8,9,10 };

var query = from n in nums where n<10 select n;

if(false) query = query.Where(n => n<6);

if(true) query = query.Where(n => n%2==0);

var rez = query.ToArray();

foreach (int num in rez)
Console.Write(num + ", ");

int big = query.Where(n => n >5).Count();
int small = query.Where(n => n <5).Count();
Console.WriteLine();
Console.WriteLine("B: " + big);
Console.WriteLine("S: " + small);