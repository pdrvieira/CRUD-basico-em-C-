using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace MatrixCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName="nvarchar(250)")]
        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [DisplayName("Nome")]
        public string FullName { get; set; }

        [Column(TypeName ="varchar(50)")]
        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [DisplayName("Matricula")]
        public string EmpCode { get; set; }
        
        [Column(TypeName ="varchar(100)")]
        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [DisplayName("Cargo")]
        public string Position { get; set; }

        
        [Column(TypeName ="varchar(100)")]
        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [DisplayName("Localização")]
        public string OfficeLocation { get; set; }



    }
}
