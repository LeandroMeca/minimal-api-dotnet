using Test.Helpers; 
using MinimalApi.DTOs;
using System.Text;
using MinimalApi.Dominio.ModelViews;
using System.Net;
using System.Text.Json;


namespace Test.Requests;

[TestClass]
public sealed class AdministradorRequestTest
{

    [ClassInitialize]
    public static void ClassInit(TestContext testContext)
    {
        Setup.ClassInit(testContext);
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Setup.ClassCleanup();
    }

    [TestMethod]
    public async Task TestarGetSetPropriedades()
    {

        //Arange
        var loginDTO = new LoginDTO{
            Email = "test@test.com",
            Senha = "123456"
        };
        var content = new StringContent(JsonSerializer.Serialize(loginDTO), Encoding.UTF8, "Application/json");

        //act
        var response = await Setup.client.PostAsync("/administradores/login", content);

        //Assert  
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        
        var result = await response.Content.ReadAsStringAsync();
        var admLogado = JsonSerializer.Deserialize<AdministradorLogado>(result, new JsonSerializerOptions{
            PropertyNameCaseInsensitive = true
        }); 

        Assert.IsNotNull(admLogado?.Email ?? "");
        Assert.IsNotNull(admLogado?.Perfil ?? "");
        Assert.IsNotNull(admLogado?.Token ?? "");

        Console.WriteLine(admLogado?.Token);
    }
}
