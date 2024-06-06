using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;

namespace EcoWave_GS.Models;

public class MdContatos
{
    [Required]
    public string Nome { get; set; }
    
    [Key]
    public string Email { get; set; }
    
    [Required]
    public PhoneAttribute Numero { get; set;  }
     
    [Required]
    public string Message { get; set; }
}

