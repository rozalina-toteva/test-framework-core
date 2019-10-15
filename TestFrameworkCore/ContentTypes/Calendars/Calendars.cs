namespace TestFrameworkCore.ContentTypes.Calendars
{
    public class Calendars : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Calendars"/> class.
        /// </summary>
        public Calendars()
        {
            this.EndpointUrl = "/sf/system/calendars";
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
        /// Gets or sets the DateCreated
        /// </summary>
        public string DateCreated
        {
            get
            {
                return this.GetProperty("DateCreated");
            }
            set
            {
                this.SetProperty("DateCreated", value);
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
        /// Gets or sets the Color
        /// </summary>
        public string Color
        {
            get
            {
                return this.GetProperty("Color");
            }
            set
            {
                this.SetProperty("Color", value);
            }
        }

        /// <summary>
        /// Gets or sets the ExpirationDate
        /// </summary>
        public string ExpirationDate
        {
            get
            {
                return this.GetProperty("ExpirationDate");
            }
            set
            {
                this.SetProperty("ExpirationDate", value);
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
