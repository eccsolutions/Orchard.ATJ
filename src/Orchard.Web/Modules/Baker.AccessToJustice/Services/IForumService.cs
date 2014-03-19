using Orchard;
using Orchard.ContentManagement;

namespace Baker.AccessToJustice.Services {
    public interface IForumService : IDependency {
        ContentItem Get(int id);
    }
}