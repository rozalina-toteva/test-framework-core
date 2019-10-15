namespace TestFrameworkCore.ContentTypes.Classifications
{
    public class Classifications : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Classifications"/> class.
        /// </summary>
        public Classifications()
        {
            this.EndpointUrl = "sf/system/taxonomies";
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
        /// Gets or sets the TaxonName
        /// </summary>
        public string TaxonName
        {
            get
            {
                return this.GetProperty("TaxonName");
            }
            set
            {
                this.SetProperty("TaxonName", value);
            }
        }

        /// <summary>
        /// Gets or sets the RootTaxonomyId
        /// </summary>
        public string RootTaxonomyId
        {
            get
            {
                return this.GetProperty("RootTaxonomyId");
            }
            set
            {
                this.SetProperty("RootTaxonomyId", value);
            }
        }

        /// <summary>
        /// Gets the TaxaUrl
        /// </summary>
        public string TaxaUrl
        {
            get
            {
                return this.GetProperty("TaxaUrl");
            }
        }

        /// <summary>
        /// Gets or sets the Type
        /// </summary>
        public string Type
        {
            get
            {
                return this.GetProperty("Type");
            }
            set
            {
                this.SetProperty("Type", value);
            }
        }
    }
}
