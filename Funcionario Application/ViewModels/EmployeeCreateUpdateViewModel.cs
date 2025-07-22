using Funcionario_Application.Models;
using System.ComponentModel.DataAnnotations;

namespace Funcionario_Application.ViewModels
{
    public class EmployeeCreateUpdateViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100)]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")]
        public string Email { get; set; } = null!;

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "O departamento é obrigatório.")]
        public int DepartmentId { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O cargo é obrigatório.")]
        public int DesignationId { get; set; }

        [Display(Name = "Data de contratação")]
        [Required(ErrorMessage = "A data de contratação é obrigatória.")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(EmployeeCreateUpdateViewModel), nameof(ValidateHireDate))]
        public DateTime HireDate { get; set; } = DateTime.Today;

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(EmployeeCreateUpdateViewModel), nameof(ValidateDateOfBirth))]
        public DateTime DateOfBirth { get; set; } = DateTime.Today.AddYears(-60);

        [Display(Name = "Tipo de funcionário")]
        [Required(ErrorMessage = "O tipo de funcionário é obrigatório.")]
        public int EmployeeTypeId { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "O gênero é obrigatório.")]
        public string Gender { get; set; } = null!;

        [Display(Name = "Salário")]
        [Required(ErrorMessage = "O salário é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser um valor positivo.")]
        public decimal Salary { get; set; }

        public List<Department>? Departments { get; set; }
        public List<Designation>? Designations { get; set; }
        public List<EmployeeType>? EmployeeTypes { get; set; }

        public static ValidationResult? ValidateHireDate(DateTime? hireDate, ValidationContext context)
        {
            if (!hireDate.HasValue)
                return new ValidationResult("A data de contratação é obrigatória.");
            if (hireDate.Value.Date > DateTime.Today)
                return new ValidationResult("A data de contratação não pode estar no futuro.");
            return ValidationResult.Success;
        }
        public static ValidationResult? ValidateDateOfBirth(DateTime? dob, ValidationContext context)
        {
            if (!dob.HasValue)
                return new ValidationResult("A data de nascimento é obrigatória.");
            var minDob = DateTime.Today.AddYears(-60);
            var maxDob = DateTime.Today.AddYears(-18); 
            if (dob.Value.Date < minDob || dob.Value.Date > maxDob)
                return new ValidationResult($"A data de nascimento deve estar entre {minDob:yyyy-MM-dd} and {maxDob:yyyy-MM-dd}.");
            return ValidationResult.Success;
        }
    }
}
