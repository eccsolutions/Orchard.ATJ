using Baker.AccessToJustice.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace Baker.AccessToJustice.Handlers {
    public class LegalForumPartHandler : ContentHandler {
        public LegalForumPartHandler(IRepository<LegalForumPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}