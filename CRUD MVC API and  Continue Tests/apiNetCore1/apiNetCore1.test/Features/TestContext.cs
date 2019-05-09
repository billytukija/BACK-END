using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace apiNetCore1.test.Features
{
    class TestContext
    {
        public HttpClient client { get; set; }
        private TestServer _server;

        public TestContext() {
            SetupClient();
        }

        private void SetupClient() {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = _server.CreateClient();
        }
    }
}
