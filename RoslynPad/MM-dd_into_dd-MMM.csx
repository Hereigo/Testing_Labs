
using System.Globalization;

string sss = "10/9/2018";

var style = DateTimeStyles.AdjustToUniversal;

// DateTime dt = DateTime.ParseExact(sss, "mm/dd/yyyy", CultureInfo.InvariantCulture);
DateTime dt=DateTime.ParseExact("12/19/2018", "M/d/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(dt.ToString("dd-MMM-yyyy"));
