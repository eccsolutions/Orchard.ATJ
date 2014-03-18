using Orchard.ContentManagement.Records;

namespace Baker.AccessToJustice.Models {
    public class LegalForumPartRecord : ContentPartRecord {
        public virtual int ThreadCount { get; set; }
        public virtual int PostCount { get; set; }
    }
}