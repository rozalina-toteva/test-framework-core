namespace TestFrameworkCore.ContentTypes.Folders
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Folders"/> class.
    /// </summary>
    public class Folders : Content
    {
        public Folders()
        {
            this.EndpointUrl = "sf/system/folders";
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
        /// Gets or sets the RootId
        /// </summary>
        public string RootId
        {
            get
            {
                return this.GetProperty("RootId");
            }
            set
            {
                this.SetProperty("RootId", value);
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
        /// Gets or sets the CoverId
        /// </summary>
        public string CoverId
        {
            get
            {
                return this.GetProperty("CoverId");
            }
            set
            {
                this.SetProperty("CoverId", value);
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
        /// Gets or sets the ChildrenCount
        /// </summary>
        public string ChildrenCount
        {
            get
            {
                return this.GetProperty("ChildrenCount");
            }
            set
            {
                this.SetProperty("ChildrenCount", value);
            }
        }

        /// <summary>
        /// Gets the Breadcrumb
        /// </summary>
        public string Breadcrumb
        {
            get
            {
                return this.GetProperty("Breadcrumb");
            }
        }
    }
}
