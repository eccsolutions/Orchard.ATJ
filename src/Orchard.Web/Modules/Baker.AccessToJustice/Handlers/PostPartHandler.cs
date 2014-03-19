using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Baker.AccessToJustice.Models;
using Baker.AccessToJustice.Services;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Core.Common.Models;
using Orchard.Data;

namespace Baker.AccessToJustice.Handlers
{
    public class PostPartHandler : ContentHandler
    {
        private readonly IThreadService _threadService;
        private readonly IPostService _postService;

        public PostPartHandler(IRepository<PostPartRecord> repository, IThreadService threadService, IPostService postService) {
            _threadService = threadService;
            _postService = postService;
            Filters.Add(StorageFilter.For(repository));

            // Update Counters
            OnCreated<PostPart>((context, part) => UpdatePostCount(part));
        }

        private void UpdatePostCount(PostPart part) {
            var commonPart = part.As<CommonPart>();

            if (commonPart != null && commonPart.Record.Container != null) {
                ThreadPart threadPart = part.ThreadPart ??
                    _threadService.Get(commonPart.Record.Container.Id).As<ThreadPart>();

                threadPart.PostCount = _postService.PostCount(threadPart);
            }
        }
    }
}