using System;
using Orchard.ContentManagement.Records;

namespace Baker.AccessToJustice.Models {
    public class ThreadPartRecord : ContentPartRecord {
        public virtual int PostCount { get; set; }
        public virtual int TakenById { get; set; }
        public virtual DateTime? TakenOnUtc { get; set; }
        public virtual int ClosedById { get; set; }
        public virtual DateTime? ClosedOnUtc { get; set; }
        public virtual string ClosedDescription { get; set; }
        public virtual bool IsSticky { get; set; }
    }
}