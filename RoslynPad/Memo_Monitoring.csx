private string LogChanges(string oldProperty, string newProperty, string typeName)
{
    StringBuilder sb = new StringBuilder("; ");
    sb.Append(typeName);
    sb.Append(" changed: ");
    sb.Append(oldProperty ?? string.Empty);
    sb.Append(" => ");
    sb.Append(newProperty ?? string.Empty);
    sb.Append(Environment.NewLine);
    return sb.ToString();
}
private string LogChanges2(string oldProperty, string newProperty, string typeName)
{
    return $"; {typeName} changed: {oldProperty ?? string.Empty} => {newProperty ?? string.Empty}{Environment.NewLine}";
}
// Monitoring cpu & memory usage enable :
AppDomain.MonitoringIsEnabled = true;


// Run Monitored Job here:
for (int i = 0; i < 2; i++)
    Console.WriteLine(LogChanges2("AJVFikutvfdlivblsdifb", null, "Kuvuv vfu ybaovibsdyisdb"));


// SUMMARY :
Console.WriteLine("333:");
Console.WriteLine($"Took: {AppDomain.CurrentDomain.MonitoringTotalProcessorTime.TotalMilliseconds:#,###} ms");
Console.WriteLine($"Allocated: {AppDomain.CurrentDomain.MonitoringTotalAllocatedMemorySize / 1024:#,#} kb");
Console.WriteLine($"Peak Working Set: {System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64 / 1024:#,#} kb");

for (int index = 0; index <= GC.MaxGeneration; index++)
{
    Console.WriteLine($"Gen {index} collections: {GC.CollectionCount(index)}");
}
