using System.Collections.Generic;
using System.Linq;
using Baker.AccessToJustice.Models;
using Baker.AccessToJustice.Services;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Core.Common.Models;
using Orchard.Data;

namespace Baker.AccessToJustice.Handlers {
    public class ThreadPartHandler : ContentHandler {
        private readonly IForumService _forumService;
        private readonly IThreadService _threadService;

        public ThreadPartHandler(IRepository<ThreadPartRecord> repository, IForumService forumService,
                                 IThreadService threadService) {
            _forumService = forumService;
            _threadService = threadService;
            Filters.Add(StorageFilter.For(repository));

            // Update Counters
            OnCreated<ThreadPart>((context, part) => UpdateThreadCount(part));
            OnRemoved<ThreadPart>((context, part) => UpdateThreadCount(part));
            OnRemoved<LegalForumPart>((context, part) => RemoveThreads(context));
        }

        private void RemoveThreads(RemoveContentContext context) {
            List<ThreadPart> threadParts = _threadService.Get(context.ContentItem.As<LegalForumPart>()).ToList();
            threadParts.ForEach(thread => context.ContentManager.Remove(thread.ContentItem));
        }

        private void UpdateThreadCount(ThreadPart part) {
            var commonPart = part.As<CommonPart>();

            if (commonPart != null && commonPart.Record.Container != null) {
                LegalForumPart forumPart = part.LegalForumPart ??
                    _forumService.Get(commonPart.Record.Container.Id).As<LegalForumPart>();

                forumPart.ThreadCount = _threadService.ThreadCount(forumPart);
            }
        }
    }
}