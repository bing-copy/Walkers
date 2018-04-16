using System.Threading.Tasks;

namespace Cosmos.Walkers {
    public abstract class Walker {
        public abstract Task Next(WalkerContext context);
    }
}