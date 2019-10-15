namespace TestFrameworkCore.ContentTypes.Content_Blocks
{
    public class ContentBlocks : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlock"/> class.
        /// </summary>
        public ContentBlocks()
        {
            this.EndpointUrl = "sf/system/contentitems";
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
        /// Gets the Provider
        /// </summary>
        public string Provider
        {
            get
            {
                return this.GetProperty("Provider");
            }
        }
    }
}
