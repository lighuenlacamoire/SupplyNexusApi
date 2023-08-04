using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Domain.Support.Helpers
{
    public static class Formatter
    {
        public static async Task<Dictionary<int, KeyValuePair<int, int>>> ReadAsPairNumbersListAsync(this IFormFile file)
        {
            Dictionary<int, KeyValuePair<int, int>> values = new Dictionary<int, KeyValuePair<int, int>>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                int count = 0;
                while (reader.Peek() >= 0)
                {
                    var lineValue = await reader.ReadLineAsync();
                    count++;
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        string[] numbers = lineValue.Split(',');
                        if(numbers != null && numbers.Length == 2)
                        {
                            int.TryParse(numbers[0], out int weight);
                            int.TryParse(numbers[1], out int height);
                            values.Add(count, new KeyValuePair<int, int>(weight, height));
                        }
                    }
                }
            }
            return values;
        }
        public static async Task<List<string>> ReadAsStringListAsync(this IFormFile file)
        {
            List<string> result = new List<string>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    var lineValue = await reader.ReadLineAsync();
                    if(!string.IsNullOrEmpty(lineValue))
                    {
                        result.Add(lineValue);
                    }
                }
            }
            return result;
        }
        public static async Task<string> ReadAsStringAsync(this IFormFile file)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    result.AppendLine(await reader.ReadLineAsync());
                    
                }
            }
            return result.ToString();
        }
    }
}
