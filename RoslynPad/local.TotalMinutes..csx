
DateTime d = Convert.ToDateTime(DateTime.Now);

TimeZone zone = TimeZone.CurrentTimeZone;

TimeSpan local = zone.GetUtcOffset(d);

Console.WriteLine(DateTime.Now.AddMinutes(local.TotalMinutes));