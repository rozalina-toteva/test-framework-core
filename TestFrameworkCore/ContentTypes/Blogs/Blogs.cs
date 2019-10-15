namespace TestFrameworkCore.ContentTypes.Blogs
{
    public class Blogs : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Blogs"/> class.
        /// </summary>
        public Blogs()
        {
            this.EndpointUrl = "/sf/system/blogs";
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
    }
}
