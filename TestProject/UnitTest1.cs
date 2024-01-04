using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class SmokeTest
    {
        private readonly HttpClient client;

        public SmokeTest()
        {
            this.client = new HttpClient();
        }

        [TestMethod]
        public async Task HomePage_Returns200OK()
        {
           
            var response = await client.GetAsync("https://blazorforazure.azurewebsites.net/");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}