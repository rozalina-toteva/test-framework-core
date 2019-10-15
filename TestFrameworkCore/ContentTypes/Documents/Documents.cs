namespace TestFrameworkCore.ContentTypes.Documents
{
    public class Documents : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Documents"/> class.
        /// </summary>
        public Documents()
        {
            this.EndpointUrl = "/sf/system/documents";
        }

        /// <summary>
        /// Gets or sets the Url
        /// </summary>
        public string Url
        {
            get
            {
                return this.GetProperty("Url");
            }
            set
            {
                this.SetProperty("Url", value);
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
        /// Gets or sets the DateCreated
        /// </summary>
        public string DateCreated
        {
            get
            {
                return this.GetProperty("DateCreated");
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
        /// Gets or sets the Author
        /// </summary>
        public string Author
        {
            get
            {
                return this.GetProperty("Author");
            }
            set
            {
                this.SetProperty("Author", value);
            }
        }

        /// <summary>
        /// Gets or sets the Extension
        /// </summary>
        public string Extension
        {
            get
            {
                return this.GetProperty("Extension");
            }
            set
            {
                this.SetProperty("Extension", value);
            }
        }

        /// <summary>
        /// Gets or sets the MimeType
        /// </summary>
        public string MimeType
        {
            get
            {
                return this.GetProperty("MimeType");
            }
            set
            {
                this.SetProperty("MimeType", value);
            }
        }

        /// <summary>
        /// Gets or sets the TotalSize
        /// </summary>
        public string TotalSize
        {
            get
            {
                return this.GetProperty("TotalSize");
            }
            set
            {
                this.SetProperty("TotalSize", value);
            }
        }

        /// <summary>
        /// Gets or sets the Tags
        /// </summary>
        public string Tags
        {
            get
            {
                return this.GetProperty("Tags");
            }
            set
            {
                this.SetProperty("Tags", value);
            }
        }

        /// <summary>
        /// Gets or sets the Category
        /// </summary>
        public string Category
        {
            get
            {
                return this.GetProperty("Category");
            }
            set
            {
                this.SetProperty("Category", value);
            }
        }

        /// <summary>
        /// Gets or sets the Parts
        /// </summary>
        public string Parts
        {
            get
            {
                return this.GetProperty("Parts");
            }
            set
            {
                this.SetProperty("Parts", value);
            }
        }

        /// <summary>
        /// Gets or sets the FolderId
        /// </summary>
        public string FolderId
        {
            get
            {
                return this.GetProperty("FolderId");
            }
            set
            {
                this.SetProperty("FolderId", value);
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
        /// Gets or sets the ThumbnailUrl
        /// </summary>
        public string ThumbnailUrl
        {
            get
            {
                return this.GetProperty("ThumbnailUrl");
            }
            set
            {
                this.SetProperty("ThumbnailUrl", value);
            }
        }
    }
}
