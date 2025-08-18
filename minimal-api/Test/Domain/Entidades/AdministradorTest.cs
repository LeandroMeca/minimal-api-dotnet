using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {

        //Arange
        var adm = new Administrador();

        //act
        adm.Id = 1;
        adm.Email = "test@test.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        //Assert
        Assert.AreEqual(1,adm.Id);
        Assert.AreEqual("test@test.com",adm.Email);
        Assert.AreEqual("teste",adm.Senha);
        Assert.AreEqual("Adm",adm.Perfil);

    }
}
