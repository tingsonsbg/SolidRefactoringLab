using System;

    public class PlainTextFormatter : IReportFormatter
    {
        public void FormatReport(){
            Console.WriteLine("Generating Plain Text Report...");
        }
    }