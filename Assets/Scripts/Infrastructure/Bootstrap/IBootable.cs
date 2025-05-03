using Cysharp.Threading.Tasks;

namespace Infrastructure.Bootstrap
{
    public interface IBootable
    {
        string Description { get; }
        bool IsInitialized { get; }
        UniTask InitializeOnBoot();
    }
}
