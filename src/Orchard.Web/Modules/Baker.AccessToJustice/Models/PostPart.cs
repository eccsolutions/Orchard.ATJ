﻿using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.Core.Common.Models;

namespace Baker.AccessToJustice.Models {
    public class PostPart : ContentPart<PostPartRecord> {
        public string Text {
            get { return this.As<BodyPart>().Text; }
            set { this.As<BodyPart>().Text = value; }
        }

        public ThreadPart ThreadPart {
            get { return this.As<ICommonPart>().Container.As<ThreadPart>(); }
            set { this.As<ICommonPart>().Container = value; }
        }

        public int? RepliedOn {
            get { return Record.RepliedOn; }
            set { Record.RepliedOn = value; }
        }
    }
}