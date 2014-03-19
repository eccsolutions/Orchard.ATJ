using System;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.ContentManagement.Utilities;
using Orchard.Core.Title.Models;
using Orchard.Security;

namespace Baker.AccessToJustice.Models {
    public class ThreadPart : ContentPart<ThreadPartRecord> {
        private readonly LazyField<IUser> _closedBy = new LazyField<IUser>();
        private readonly LazyField<PostPart> _firstPost = new LazyField<PostPart>();
        private readonly LazyField<PostPart> _latestPost = new LazyField<PostPart>();
        private readonly LazyField<IUser> _takenBy = new LazyField<IUser>();

        public string Title {
            get { return this.As<TitlePart>().Title; }
            set { this.As<TitlePart>().Title = value; }
        }

        public LegalForumPart LegalForumPart {
            get { return this.As<ICommonPart>().Container.As<LegalForumPart>(); }
            set { this.As<ICommonPart>().Container = value; }
        }

        public IUser Creator {
            get { return this.As<ICommonPart>().Owner; }
            set { this.As<ICommonPart>().Owner = value; }
        }

        public bool IsSticky {
            get { return Record.IsSticky; }
            set { Record.IsSticky = value; }
        }

        public PostPart FirstPost {
            get { return _firstPost.Value; }
            set { _firstPost.Value = value; }
        }

        public PostPart LatestPost {
            get { return _latestPost.Value; }
            set { _latestPost.Value = value; }
        }

        public int PostCount {
            get { return Record.PostCount; }
            set { Record.PostCount = value; }
        }

        public DateTime? TakenOnUtc {
            get { return Record.TakenOnUtc; }
            set { Record.TakenOnUtc = value; }
        }

        public IUser TakenBy {
            get { return _takenBy.Value; }
            set { _takenBy.Value = value; }
        }

        public DateTime? ClosedOnUtc {
            get { return Record.ClosedOnUtc; }
            set { Record.ClosedOnUtc = value; }
        }

        public IUser ClosedBy {
            get { return _closedBy.Value; }
            set { _closedBy.Value = value; }
        }

        public string ClosedDescription {
            get { return Record.ClosedDescription; }
            set { Record.ClosedDescription = value; }
        }

        public bool IsClosed {
            get { return ClosedOnUtc != null; }
        }

        public bool IsTaken {
            get { return TakenOnUtc != null; }
        }

        public int ReplyCount {
            get { return PostCount >= 1 ? PostCount - 1 : 0; }
        }
    }
}