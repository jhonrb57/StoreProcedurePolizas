using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using WebApiPolizas.Controllers;
using WebApiPolizas.Models;

namespace PolizaTest
{
    [TestClass]
    public class FechaPolizaTest
    {
        [TestMethod]
        public async Task ObtenerPolizaPorIdNoExistente()
        {
            var controller = new PolizaController();
        }
    }
}
