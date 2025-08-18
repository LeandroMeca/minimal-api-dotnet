using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades;


    public class Veiculo
    {
         [Key] 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int Id {set;get;} = default!;

         [Required]
         [StringLength(255)]
         public string Nome {set;get;} = default!;

         [StringLength(60)]
         public string Marca {set;get;} = default!; 

         public int Ano {set;get;} = default!; 
    }
