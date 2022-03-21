using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TodoApi.Models;

namespace StudentsApp.Models
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }

        public DbSet<Student> students { get; set; } = null!;
    }
}