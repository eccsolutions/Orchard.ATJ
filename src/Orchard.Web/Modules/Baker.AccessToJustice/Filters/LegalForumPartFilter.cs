using Baker.AccessToJustice.Models;
using Orchard.Localization;
using Orchard.Projections.Descriptors.Filter;
using Orchard.Projections.Services;

namespace Baker.AccessToJustice.Filters {
    public class LegalForumPartFilter : IFilterProvider {
        public LegalForumPartFilter() {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        public void Describe(DescribeFilterContext describe) {
            describe.For(
                "Content",
                T("Content"),
                T("Content"))
                    .Element(
                        "LegalForumParts",
                        T("Legal Forum Parts"),
                        T("Legal Forum Parts"),
                        ApplyFilter,
                        DisplayFilter
                );
        }

        private void ApplyFilter(FilterContext context) {
            context.Query = context.Query.Join(x => x.ContentPartRecord(typeof (LegalForumPartRecord)));
        }

        private LocalizedString DisplayFilter(FilterContext context) {
            return T("Content with LegalForumPart");
        }
    }
}