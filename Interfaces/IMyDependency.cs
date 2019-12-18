using System.Threading.Tasks;

namespace DependencyInjSample.Interfaces
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}