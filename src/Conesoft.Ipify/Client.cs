using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Conesoft.Ipify
{
    class Client
    {
        readonly HttpClient client;

        public Client(HttpClient client)
        {
            this.client = client;
            client.BaseAddress = new Uri(@"https://api.ipify.org/");
        }

        public async Task<IPAddress> GetPublicIPAddress() => IPAddress.Parse(await (await client.GetAsync("")).Content.ReadAsStringAsync());
    }
}
