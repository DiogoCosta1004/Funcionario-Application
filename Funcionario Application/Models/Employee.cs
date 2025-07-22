using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Funcionario_Application.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome completo é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome completo não pode ter mais de 100 caracteres")]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Endereço de e-mail inválido")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "O departamento é obrigatório")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        [Required(ErrorMessage = "O cargo é obrigatório")]
        public int DesignationId { get; set; }
        public Designation Designation { get; set; } = null!;

        [Required(ErrorMessage = "A data de contratação é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "O tipo de funcionário é obrigatório")]
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; } = null!;

        [Required(ErrorMessage = "O gênero é obrigatório")]
        [StringLength(6, ErrorMessage = "O gênero deve ser Masculino, Feminino ou Outro")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "O salário é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser um número positivo")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
}
