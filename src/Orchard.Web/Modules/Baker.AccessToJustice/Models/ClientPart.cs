using Orchard.ContentManagement;

namespace Baker.AccessToJustice.Models {
    public class ClientPart : ContentPart<ClientPartRecord> {
        public string FirstName {
            get { return Record.FirstName; }
            set { Record.FirstName = value; }
        }

        public string MiddleInitial {
            get { return Record.MiddleInitial; }
            set { Record.MiddleInitial = value; }
        }

        public string LastName {
            get { return Record.LastName; }
            set { Record.LastName = value; }
        }
    }
}