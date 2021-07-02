using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorEditorsWasm.JsonSettings;

namespace BlazorEditorsWasm.Providers
{
    public class FileProvider
    {
        private HttpClient client;
        private bool isError;
        private F76Settings settings;
        public F76Settings Settings {
            get => this.settings;
        }
        private bool isBusy;
         public bool IsBusy{
            get => isBusy;
        }
        public string Name{
            get => "Hello I'm file provider!!!!" + client.BaseAddress.AbsolutePath;
        }
        public FileProvider(HttpClient client){
            this.client = client;
            this.isBusy = true;
           
        }

        public async Task Init()
        {
            this.settings = await client.GetFromJsonAsync<F76Settings>("sample-data/settings.json");
            this.isBusy = false;
        }
    }
}