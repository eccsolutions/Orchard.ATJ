using Baker.AccessToJustice.Models;
using Orchard.ContentManagement.Drivers;

namespace Baker.AccessToJustice.Drivers {
    public class LegalForumPartDriver : ContentPartDriver<LegalForumPart> {
        protected override string Prefix {
            get { return "LegalForum"; }
        }

        //protected override DriverResult Display(LegalForumPart part, string displayType, dynamic shapeHelper) {
        //    return ContentShape("Parts_LegalForum", () => shapeHelper.Parts_LegalForum(
        //        Description: part.Text,
        //        ThreadCount: part.ThreadCount,
        //        PostCount: part.PostCount
        //        ));
        //}

        //protected override DriverResult Editor(LegalForumPart part, dynamic shapeHelper) {
        //    return ContentShape("Parts_LegalForum_Edit", () => shapeHelper
        //        .EditorTemplate(TemplateName: "Parts/LegalForum", Model: part, Prefix: Prefix));
        //}

        //protected override DriverResult Editor(LegalForumPart part, Orchard.ContentManagement.IUpdateModel updater, dynamic shapeHelper) {
        //    updater.TryUpdateModel(part, Prefix, null, null);
        //    return Editor(part, shapeHelper);
        //}
    }
}