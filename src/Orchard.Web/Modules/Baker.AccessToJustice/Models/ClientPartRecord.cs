﻿using Orchard.ContentManagement.Records;

namespace Baker.AccessToJustice.Models {
    public class ClientPartRecord : ContentPartRecord {
        public virtual string FirstName { get; set; }
        public virtual string MiddleInitial { get; set; }
        public virtual string LastName { get; set; }
    }
}