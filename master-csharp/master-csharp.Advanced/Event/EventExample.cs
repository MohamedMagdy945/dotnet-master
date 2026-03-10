using EventExample;
using System;

namespace EventExample
{
    delegate void ReportAction(string report);

    class ReportGenerator
    {
        public string Report { get; private set; } 

        public event ReportAction OnReportGenerated;

        public void GenerateReport()
        {
            Report = "Monthly Sales Report: $1000";
            Console.WriteLine("[ReportGenerator] Report generated.");

            OnReportGenerated?.Invoke(Report);
        }
    }
}
class EventUsage
{
    static void PrintToConsole(string report)
    {
        Console.WriteLine("[Console] " + report);
    }

    static void SaveToFile(string report)
    {
        Console.WriteLine("[File] Saving report: " + report);
    }

    public static void Test()
    {
        ReportGenerator generator = new ReportGenerator();

        generator.OnReportGenerated += PrintToConsole;
        generator.OnReportGenerated += SaveToFile;
        generator.OnReportGenerated += r => Console.WriteLine("[Lambda] Log: " + r);

        generator.GenerateReport();
    }
}