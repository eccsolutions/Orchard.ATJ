using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Baker.AccessToJustice {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("LegalForumPartRecord", table => table
                // ContentPartRecord() creates an "Id" column and sets it as the primary key for the table.
                .ContentPartRecord()
                .Column<int>("ThreadCount")
                .Column<int>("PostCount"));

            ContentDefinitionManager.AlterPartDefinition("LegalForumPart", part => part
                .WithDescription("Turns a content type into a Legal Forum."));

            ContentDefinitionManager.AlterTypeDefinition("LegalForum", cfg => cfg
                .WithPart("LegalForumPart")
                .WithPart("TitlePart")
                .WithPart("BodyPart")
                .WithPart("CommonPart")
                .WithPart("MenuPart")
                .Creatable());

            return 1;
        }
    }
}