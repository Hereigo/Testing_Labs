
      DateTime now = DateTime.Now;
      DateTime utcNow = DateTime.UtcNow;
      
      Console.WriteLine(now);
      Console.WriteLine(utcNow);
      Console.WriteLine(now-utcNow);
      
      DateTimeOffset offNow = DateTimeOffset.Now;
      DateTimeOffset offUtc = DateTimeOffset.UtcNow;
      
      Console.WriteLine();
      Console.WriteLine(offNow);
      Console.WriteLine(offUtc);
      Console.WriteLine(offNow-offUtc);
      

      // If run in the Pacific Standard time zone on 4/2/2007, the example
      // displays the following output to the console:
      //    4/2/2007 7:23:57 PM - 4/3/2007 2:23:57 AM = -07:00:00
      //    4/2/2007 7:23:57 PM -07:00 - 4/3/2007 2:23:57 AM +00:00 = 00:00:00  