using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD8CW.Data;

namespace WAD8CW.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WAD8CWContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WAD8CWContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new List<Student>
                {
                    new Student{Name= "Matti", Address="Samkatu 10"},
                    new Student{Name= "Timo", Address="NieKatu 25"},
                };
                students.ForEach(s => context.Student.Add(s));
                context.SaveChanges();
            }
        }
    }
}
