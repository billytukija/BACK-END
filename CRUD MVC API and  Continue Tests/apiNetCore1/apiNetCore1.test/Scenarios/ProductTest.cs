using apiNetCore1.Models;
using apiNetCore1.test.Features;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace apiNetCore1.test.Scenarios
{
    public class ProductTest
    {
        private readonly TestContext _sut;

        public ProductTest()
        {
            _sut = new TestContext();
        }

        [Fact()]
        public async Task<List<Product>> GetAll() {

            var response = await _sut.client.GetAsync("");
            response.EnsureSuccessStatusCode();

            return new List<Product>();
        }
    }
}
