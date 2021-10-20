using API_Convolucao;
using API_Convolucao.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ConvolucaoAPI.Tests.Controllers
{
    [TestClass]
    public class ConvolucaoControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            var l_ConvObject = new ValuesController.ConvObject()
            {
                vetor01 = new List<int>() { 0, 1, 2, 3, 4, 5, 6 }.ToArray(),
                vetor02 = new List<int>() { 0, 0, 0, 1, 1, 1, 1 }.ToArray()
            };

            // Act
            var result = controller.Conv(JsonConvert.SerializeObject(l_ConvObject));

            var resultado_esperado = string.Join(", ", new List<double>() { 0, 0, 0, 0, 1, 3, 6, 10, 14, 18, 15, 11, 6 });

            Assert.IsNotNull(result);

            Assert.AreEqual(result.Length, resultado_esperado.Length, "Valores fora do esperado");
        }
    }
}
