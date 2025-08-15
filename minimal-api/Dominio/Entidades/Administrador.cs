using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades;


    public class Administrador
    {
         [Key] 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int Id {set;get;} = default!;

         [Required]
         [StringLength(255)]
         public string Email {set;get;} = default!;

         [StringLength(60)]
         public string Senha {set;get;} = default!; 

         [StringLength(12)]
         public string Perfil {set;get;} = default!; 
    }
