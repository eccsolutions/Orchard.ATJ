using Baker.AccessToJustice.Models;
using JetBrains.Annotations;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace Baker.AccessToJustice.Handlers {
    [UsedImplicitly]
    public class LegalForumPartHandler : ContentHandler {
        public LegalForumPartHandler(IRepository<LegalForumPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}