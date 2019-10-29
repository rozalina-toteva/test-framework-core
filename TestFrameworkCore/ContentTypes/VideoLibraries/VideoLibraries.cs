namespace TestFrameworkCore.ContentTypes.VideoLibraries
{
    public class VideoLibraries : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoLibraries"/> class.
        /// </summary>
        public VideoLibraries()
        {
            this.EndpointUrl = "sf/system/videolibraries";
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
        /// Gets or sets the MaxSize
        /// </summary>
        public string MaxSize
        {
            get
            {
                return this.GetProperty("MaxSize");
            }
            set
            {
                this.SetProperty("MaxSize", value);
            }
        }

        /// <summary>
        /// Gets or sets the MaxItemSize
        /// </summary>
        public string MaxItemSize
        {
            get
            {
                return this.GetProperty("MaxItemSize");
            }
            set
            {
                this.SetProperty("MaxItemSize", value);
            }
        }

        /// <summary>
        /// Gets or sets the BlobStorageProvider
        /// </summary>
        public string BlobStorageProvider
        {
            get
            {
                return this.GetProperty("BlobStorageProvider");
            }
            set
            {
                this.SetProperty("BlobStorageProvider", value);
            }
        }

        /// <summary>
        /// Gets or sets the OutputCacheProfile
        /// </summary>
        public string OutputCacheProfile
        {
            get
            {
                return this.GetProperty("OutputCacheProfile");
            }
            set
            {
                this.SetProperty("OutputCacheProfile", value);
            }
        }

        /// <summary>
        /// Gets or sets the ClientCacheProfile
        /// </summary>
        public string ClientCacheProfile
        {
            get
            {
                return this.GetProperty("ClientCacheProfile");
            }
            set
            {
                this.SetProperty("ClientCacheProfile", value);
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
    }
}
