using Microsoft.Graph.Models.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Site : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place in this site.</summary>
        public ItemAnalytics Analytics { get; set; }
        /// <summary>The collection of column definitions reusable across lists under this site.</summary>
        public List<ColumnDefinition> Columns { get; set; }
        /// <summary>The collection of content types defined for this site.</summary>
        public List<ContentType> ContentTypes { get; set; }
        /// <summary>The full title for the site. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The default drive (document library) for this site.</summary>
        public Microsoft.Graph.Models.Drive Drive { get; set; }
        /// <summary>The collection of drives (document libraries) under this site.</summary>
        public List<Microsoft.Graph.Models.Drive> Drives { get; set; }
        /// <summary>The error property</summary>
        public PublicError Error { get; set; }
        /// <summary>The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.</summary>
        public List<ColumnDefinition> ExternalColumns { get; set; }
        /// <summary>Used to address any item contained in this site. This collection can&apos;t be enumerated.</summary>
        public List<BaseItem> Items { get; set; }
        /// <summary>The collection of lists under this site.</summary>
        public List<List> Lists { get; set; }
        /// <summary>Calls the OneNote service for notebook related operations.</summary>
        public Microsoft.Graph.Models.Onenote Onenote { get; set; }
        /// <summary>The permissions associated with the site. Nullable.</summary>
        public List<Permission> Permissions { get; set; }
        /// <summary>If present, indicates that this is the root site in the site collection. Read-only.</summary>
        public Microsoft.Graph.Models.Root Root { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public Microsoft.Graph.Models.SharepointIds SharepointIds { get; set; }
        /// <summary>Provides details about the site&apos;s site collection. Available only on the root site. Read-only.</summary>
        public Microsoft.Graph.Models.SiteCollection SiteCollection { get; set; }
        /// <summary>The collection of the sub-sites under this site.</summary>
        public List<Site> Sites { get; set; }
        /// <summary>The default termStore under this site.</summary>
        public Store TermStore { get; set; }
        /// <summary>The collection of termStores under this site.</summary>
        public List<Store> TermStores { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Site CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Site();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"analytics", (o,n) => { (o as Site).Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"columns", (o,n) => { (o as Site).Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"contentTypes", (o,n) => { (o as Site).ContentTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as Site).DisplayName = n.GetStringValue(); } },
                {"drive", (o,n) => { (o as Site).Drive = n.GetObjectValue<Microsoft.Graph.Models.Drive>(Microsoft.Graph.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", (o,n) => { (o as Site).Drives = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Drive>(Microsoft.Graph.Models.Drive.CreateFromDiscriminatorValue).ToList(); } },
                {"error", (o,n) => { (o as Site).Error = n.GetObjectValue<PublicError>(PublicError.CreateFromDiscriminatorValue); } },
                {"externalColumns", (o,n) => { (o as Site).ExternalColumns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"items", (o,n) => { (o as Site).Items = n.GetCollectionOfObjectValues<BaseItem>(BaseItem.CreateFromDiscriminatorValue).ToList(); } },
                {"lists", (o,n) => { (o as Site).Lists = n.GetCollectionOfObjectValues<List>(List.CreateFromDiscriminatorValue).ToList(); } },
                {"onenote", (o,n) => { (o as Site).Onenote = n.GetObjectValue<Microsoft.Graph.Models.Onenote>(Microsoft.Graph.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"permissions", (o,n) => { (o as Site).Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue).ToList(); } },
                {"root", (o,n) => { (o as Site).Root = n.GetObjectValue<Microsoft.Graph.Models.Root>(Microsoft.Graph.Models.Root.CreateFromDiscriminatorValue); } },
                {"sharepointIds", (o,n) => { (o as Site).SharepointIds = n.GetObjectValue<Microsoft.Graph.Models.SharepointIds>(Microsoft.Graph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"siteCollection", (o,n) => { (o as Site).SiteCollection = n.GetObjectValue<Microsoft.Graph.Models.SiteCollection>(Microsoft.Graph.Models.SiteCollection.CreateFromDiscriminatorValue); } },
                {"sites", (o,n) => { (o as Site).Sites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue).ToList(); } },
                {"termStore", (o,n) => { (o as Site).TermStore = n.GetObjectValue<Store>(Store.CreateFromDiscriminatorValue); } },
                {"termStores", (o,n) => { (o as Site).TermStores = n.GetCollectionOfObjectValues<Store>(Store.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<ContentType>("contentTypes", ContentTypes);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Drive>("drives", Drives);
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("externalColumns", ExternalColumns);
            writer.WriteCollectionOfObjectValues<BaseItem>("items", Items);
            writer.WriteCollectionOfObjectValues<List>("lists", Lists);
            writer.WriteObjectValue<Microsoft.Graph.Models.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<Microsoft.Graph.Models.Root>("root", Root);
            writer.WriteObjectValue<Microsoft.Graph.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteObjectValue<Microsoft.Graph.Models.SiteCollection>("siteCollection", SiteCollection);
            writer.WriteCollectionOfObjectValues<Site>("sites", Sites);
            writer.WriteObjectValue<Store>("termStore", TermStore);
            writer.WriteCollectionOfObjectValues<Store>("termStores", TermStores);
        }
    }
}