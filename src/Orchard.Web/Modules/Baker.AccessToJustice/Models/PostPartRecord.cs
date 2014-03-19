using Orchard.ContentManagement.Records;

namespace Baker.AccessToJustice.Models {
    public class PostPartRecord : ContentPartRecord {
        public virtual int? RepliedOn { get; set; }
    }
}