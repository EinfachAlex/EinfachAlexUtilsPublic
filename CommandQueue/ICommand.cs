using System.Threading.Tasks;

namespace EinfachAlex.Utils.CommandQueue
{
    public interface ICommand
    {
        public Task executeSingle();
    }
}