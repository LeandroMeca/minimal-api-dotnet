namespace MinimalApi.DTOs;

public record VeiculoDTO{

     public string Nome {set;get;} = default!;

     public string Marca {set;get;} = default!; 

     public int Ano {set;get;} = default!; 
}  