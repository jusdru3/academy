using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DataSender.Models;

namespace DataSender.Services
{
    class DataSenderService
    {
        private string _url;
        public DataSenderService(string url)
        {
            _url = url;
        }

        private async Task<VirtualMachineModel> GetVirtualMachine()
        {
            VirtualMachineModel vm = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET

                HttpResponseMessage response = await client.GetAsync("api/virtualmachines/1");
                if (response.IsSuccessStatusCode)
                {
                     vm = await response.Content.ReadAsAsync<VirtualMachineModel>();
                }

            }
            return vm;
        }

        public async Task SendToApi(ComputerModel cm)
        {
            var vm = await GetVirtualMachine();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP POST
                HttpResponseMessage response = await client.PostAsJsonAsync("api/virtualmachines/" +vm.VirtualMachineId+"/usagereports", cm);
                if (response.IsSuccessStatusCode)
                {
                }
            }
        }
    }
}
