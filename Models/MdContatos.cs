using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;

namespace EcoWave_GS.Models;

public class MdContatos
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O campo Nome é obrigatorio")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    
    [Required(ErrorMessage = "Email é obrigatorio.")]
    [EmailAddress(ErrorMessage = "Deve ser um email real")]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Numero é obrigatorio")]
    [Display(Name = "Numero")]
    public PhoneAttribute Numero { get; set;  }
     
    
    [Required(ErrorMessage = "Mensagem é obrigatoria!")]
    [Display(Name = "Mensagem")]
    public string Message { get; set; }
}

