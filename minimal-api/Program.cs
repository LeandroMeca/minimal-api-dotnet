var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.DTOs.LoginDto loginDto) => {
    if(loginDto.Email=="test@test.com" && loginDto.Senha == "123456"){
        return Results.Ok("Login efetuado");
    }else
    {
        return Results.Unauthorized();
    }
});

app.Run();


