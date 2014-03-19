using System.Collections.Generic;
using Baker.AccessToJustice.Models;
using Orchard;
using Orchard.ContentManagement;

namespace Baker.AccessToJustice.Services {
    public interface IThreadService : IDependency {
        int ThreadCount(LegalForumPart forumPart);
        IEnumerable<ThreadPart> Get(LegalForumPart legalForumPart);
        ContentItem Get(int id);
    }
}