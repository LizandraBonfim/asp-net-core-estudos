using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lizandra.WebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "{0} obrigátorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} Tamanho caracter entre {2} e {1}")]
        public string Name { get; set; }
        
        [Display(Name =  "Base Salary")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} min  {1}, max  {2}")]
        [DataType("decimal(10,2)")] 
        [Required(ErrorMessage = "{0} obrigátorio")]

        public decimal BaseSalary { get; set; }
        
        [DataType(DataType.EmailAddress )]
        [Required(ErrorMessage = "{0} obrigátorio")]
        [EmailAddress(ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }
        
        [Display(Name =  "Birth Date")]
        [DisplayFormat(DataFormatString =  "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} obrigátorio")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public int DepartmentId {get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Seller()
        {
            
        }

        public Seller(int id, string name,  string email, DateTime birthDate,decimal baseSalary, Department department)
        {
            Id = id;
            Name = name;
            BaseSalary = baseSalary;
            Email = email;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public decimal TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final)
                .Sum(sr => sr.Amount);
        }
        

    }
}