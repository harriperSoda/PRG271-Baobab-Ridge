using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PRG271_Baobab_Ridge
{
    // holds the figures shown on the form and written to summary.txt
    internal class SummaryResult
    {
        public int Total { get; set; }
        public double? AverageAge { get; set; }            // null when there are no animals
        public double? AverageRecoveryScore { get; set; }  // null when there are no animals
        public Dictionary<string, int> StatusCounts { get; } = new Dictionary<string, int>
        {
          { "Critical", 0 }, { "Serious", 0 }, { "Stable", 0 },
          { "Recovering", 0 }, { "Release-Ready", 0 }
         };
    }
    internal class SummaryReportService
    {
        // calculates the total, averages and per-status counts from the loaded animals
        public static SummaryResult Calculate(List<Animal> animals)
        {
            SummaryResult result = new SummaryResult();
            result.Total = animals.Count;

            foreach (Animal animal in animals)
            {
                result.StatusCounts[animal.Status]++;
            }

            if (result.Total > 0)   // guard against dividing by zero
            {
                result.AverageAge = animals.Average(a => a.Age);
                result.AverageRecoveryScore = animals.Average(a => a.RecoveryScore);
            }
            return result;
        }

        // formats an average to 2 decimals with a full stop, or N/A when there is no data
        public static string FormatAverage(double? value)
        {
            return value.HasValue
                ? value.Value.ToString("F2", CultureInfo.InvariantCulture)
                : "N/A";
        }

        // builds the text layout required for summary.txt (Section 5.2)
        public static string BuildReportText(SummaryResult result, DateTime generatedAt)
        {
            string divider = new string('-', 40);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
            sb.AppendLine("ANIMAL SUMMARY REPORT");
            sb.AppendLine("Generated: " + generatedAt.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
            sb.AppendLine(divider);
            sb.AppendLine("Total animals:".PadRight(26) + result.Total);
            sb.AppendLine("Average age (years):".PadRight(26) + FormatAverage(result.AverageAge));
            sb.AppendLine("Average recovery score:".PadRight(26) + FormatAverage(result.AverageRecoveryScore));
            sb.AppendLine(divider);
            sb.AppendLine("Animals per status:");
            foreach (var pair in result.StatusCounts)
            {
                sb.AppendLine((pair.Key + ":").PadRight(24) + pair.Value);
            }
            return sb.ToString();
        }

        // overwrites summary.txt with the report text
        public static void SaveReport(string summaryPath, string text)
        {
            File.WriteAllText(summaryPath, text, Encoding.UTF8);
        }
    }
}