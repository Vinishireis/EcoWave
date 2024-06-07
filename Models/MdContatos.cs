using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;

namespace EcoWave_GS.Models;

public class MdContatos
{
    [Required(ErrorMessage = "O campo Nome é obrigatorio")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Email é obrigatorio.")]
    [EmailAddress(ErrorMessage = "Deve ser um email real")]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Numero é obrigatorio")]
    public PhoneAttribute Numero { get; set;  }
     
    [Required]
    public string Message { get; set; }
}

