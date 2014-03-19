using Baker.AccessToJustice.Models;
using Orchard;

namespace Baker.AccessToJustice.Services {
    public interface IPostService : IDependency {
        int PostCount(ThreadPart threadPart);
    }
}