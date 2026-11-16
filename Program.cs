using System;

class Program
{
        static void Main(string[] args )
        {
            IReportFormatter formatter = new PdfFormatter();

            ReportManager manager = new ReportManager(formatter);
            manager.GenerateReport();

            ReportSaver saver = new ReportSaver();
            saver.SaveToFile("Q1_Report.pdf");
        }
    }