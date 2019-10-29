namespace TestFrameworkCore.ContentTypes.News
{
    public class News : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Events"/> class.
        /// </summary>
        public News()
        {
            this.EndpointUrl = "/sf/system/newsitems";
        }

        /// <summary>
        /// Gets or sets the Content
        /// </summary>
        public string Content
        {
            get
            {
                return this.GetProperty("Content");
            }
            set
            {
                this.SetProperty("Content", value);
            }
        }

        /// <summary>
        /// Gets or sets the PublicationDate
        /// </summary>
        public string PublicationDate
        {
            get
            {
                return this.GetProperty("PublicationDate");
            }
            set
            {
                this.SetProperty("PublicationDate", value);
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
        /// Gets the DateCreated
        /// </summary>
        public string DateCreated
        {
            get
            {
                return this.GetProperty("DateCreated");
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
        /// Gets or sets the AllowComments
        /// </summary>
        public string AllowComments
        {
            get
            {
                return this.GetProperty("AllowComments");
            }
            set
            {
                this.SetProperty("AllowComments", value);
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
        /// Gets or sets the SourceName
        /// </summary>
        public string SourceName
        {
            get
            {
                return this.GetProperty("SourceName");
            }
            set
            {
                this.SetProperty("SourceName", value);
            }
        }

        /// <summary>
        /// Gets or sets the SourceSite
        /// </summary>
        public string SourceSite
        {
            get
            {
                return this.GetProperty("SourceSite");
            }
            set
            {
                this.SetProperty("SourceSite", value);
            }
        }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public string Provider
        {
            get
            {
                return this.GetProperty("Provider");
            }
            set
            {
                this.SetProperty("Provider", value);
            }
        }

        /// <summary>
        /// Gets or sets the Comments
        /// </summary>
        public string Comments
        {
            get
            {
                return this.GetProperty("Comments");
            }
            set
            {
                this.SetProperty("Comments", value);
            }
        }
    }
}