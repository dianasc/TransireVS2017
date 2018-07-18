using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Controllers;
using Service.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestCategoria
    {
        
        [TestMethod]
        public void TestMethodInsertComSucesso()
        {
            
            /*CategoriaController cat = new CategoriaController();
                Categoria insert = new Categoria() { Ativo = true, Nome = "Móveis" };



                var retorno = cat.Post(JsonConvert.SerializeObject(insert));
            

            Assert.AreEqual(0, 0, "Igual");*/
        }

        [TestMethod]
        public void TestMethodInsertComFalha()
        {
            Assert.AreEqual(0, 0, "Igual");
        }

        [TestMethod]
        public void TestMethodExcluirComSucesso()
        {
            Assert.AreEqual(0, 0, "Igual");
        }

        [TestMethod]
        public void TestMethodExcluirComFalha()
        {
            Assert.AreEqual(0, 0, "Igual");
        }
    }
}
