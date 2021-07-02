
using System.Threading.Tasks;
using BlazorEditorsWasm.Providers;

namespace BlazorEditorsWasm {
    public class F76Manager {
        private readonly FileProvider provider;
        public F76Manager(FileProvider provider){
            this.provider = provider;
            this.isBusy = true;
        }
        private bool isBusy;
        public bool IsBusy{
            get => isBusy;
        }
        public async Task Init(){
            await provider.Init();
        }
    }
}