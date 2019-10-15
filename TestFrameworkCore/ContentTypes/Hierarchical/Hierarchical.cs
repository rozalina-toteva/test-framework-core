namespace TestFrameworkCore.ContentTypes.Hierarchical
{
    public class Hierarchical : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hierarchical"/> class.
        /// </summary>
        public Hierarchical()
        {
            this.EndpointUrl = "sf/system/hierarchy-taxa";
        }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description
        {
            get
            {
                return this.GetProperty("Description");
            }
            set
            {
                this.SetProperty("Description", value);
            }
        }

        /// <summary>
        /// Gets or sets the UrlName
        /// </summary>
        public string UrlName
        {
            get
            {
                return this.GetProperty("UrlName");
            }
            set
            {
                this.SetProperty("UrlName", value);
            }
        }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name
        {
            get
            {
                return this.GetProperty("Name");
            }
            set
            {
                this.SetProperty("Name", value);
            }
        }

        /// <summary>
        /// Gets or sets the Synonyms
        /// </summary>
        public string Synonyms
        {
            get
            {
                return this.GetProperty("Synonyms");
            }
            set
            {
                this.SetProperty("Synonyms", value);
            }
        }

        /// <summary>
        /// Gets or sets the Ordinal
        /// </summary>
        public string Ordinal
        {
            get
            {
                return this.GetProperty("Ordinal");
            }
            set
            {
                this.SetProperty("Ordinal", value);
            }
        }

        /// <summary>
        /// Gets or sets the FullUrl
        /// </summary>
        public string FullUrl
        {
            get
            {
                return this.GetProperty("FullUrl");
            }
            set
            {
                this.SetProperty("FullUrl", value);
            }
        }

        /// <summary>
        /// Gets or sets the TaxonomyId
        /// </summary>
        public string TaxonomyId
        {
            get
            {
                return this.GetProperty("TaxonomyId");
            }
            set
            {
                this.SetProperty("TaxonomyId", value);
            }
        }

        /// <summary>
        /// Gets or sets the ParentId
        /// </summary>
        public string ParentId
        {
            get
            {
                return this.GetProperty("ParentId");
            }
            set
            {
                this.SetProperty("ParentId", value);
            }
        }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        public string Provider
        {
            get
            {
                return this.GetProperty("Provider");
            }
        }

        /// <summary>
        /// Gets the AppliedTo
        /// </summary>
        public string AppliedTo
        {
            get
            {
                return this.GetProperty("AppliedTo");
            }
        }
    }
}
