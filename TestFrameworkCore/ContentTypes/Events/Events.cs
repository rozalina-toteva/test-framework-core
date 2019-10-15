namespace TestFrameworkCore.ContentTypes.Events
{
    public class Events : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Events"/> class.
        /// </summary>
        public Events()
        {
            this.EndpointUrl = "/sf/system/events";
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
        /// Gets or sets the EventStart
        /// </summary>
        public string EventStart
        {
            get
            {
                return this.GetProperty("EventStart");
            }
            set
            {
                this.SetProperty("EventStart", value);
            }
        }

        /// <summary>
        /// Gets or sets the EventEnd
        /// </summary>
        public string EventEnd
        {
            get
            {
                return this.GetProperty("EventEnd");
            }
            set
            {
                this.SetProperty("EventEnd", value);
            }
        }

        /// <summary>
        /// Gets or sets the ContactEmail
        /// </summary>
        public string ContactEmail
        {
            get
            {
                return this.GetProperty("ContactEmail");
            }
            set
            {
                this.SetProperty("ContactEmail", value);
            }
        }

        /// <summary>
        /// Gets or sets the ContactWeb
        /// </summary>
        public string ContactWeb
        {
            get
            {
                return this.GetProperty("ContactWeb");
            }
            set
            {
                this.SetProperty("ContactWeb", value);
            }
        }

        /// <summary>
        /// Gets or sets the Street
        /// </summary>
        public string Street
        {
            get
            {
                return this.GetProperty("Street");
            }
            set
            {
                this.SetProperty("Street", value);
            }
        }

        /// <summary>
        /// Gets or sets the City
        /// </summary>
        public string City
        {
            get
            {
                return this.GetProperty("City");
            }
            set
            {
                this.SetProperty("City", value);
            }
        }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public string Country
        {
            get
            {
                return this.GetProperty("Country");
            }
            set
            {
                this.SetProperty("Country", value);
            }
        }

        /// <summary>
        /// Gets or sets the State
        /// </summary>
        public string State
        {
            get
            {
                return this.GetProperty("State");
            }
            set
            {
                this.SetProperty("State", value);
            }
        }

        /// <summary>
        /// Gets or sets the ContactName
        /// </summary>
        public string ContactName
        {
            get
            {
                return this.GetProperty("ContactName");
            }
            set
            {
                this.SetProperty("ContactName", value);
            }
        }

        /// <summary>
        /// Gets or sets the ContactCell
        /// </summary>
        public string ContactCell
        {
            get
            {
                return this.GetProperty("ContactCell");
            }
            set
            {
                this.SetProperty("ContactCell", value);
            }
        }

        /// <summary>
        /// Gets or sets the ContactPhone
        /// </summary>
        public string ContactPhone
        {
            get
            {
                return this.GetProperty("ContactPhone");
            }
            set
            {
                this.SetProperty("ContactPhone", value);
            }
        }

        /// <summary>
        /// Gets or sets the Summary
        /// </summary>
        public string Summary
        {
            get
            {
                return this.GetProperty("Summary");
            }
            set
            {
                this.SetProperty("Summary", value);
            }
        }

        /// <summary>
        /// Gets or sets the IsRecurrent
        /// </summary>
        public string IsRecurrent
        {
            get
            {
                return this.GetProperty("IsRecurrent");
            }
            set
            {
                this.SetProperty("IsRecurrent", value);
            }
        }

        /// <summary>
        /// Gets or sets the RecurrenceExpression
        /// </summary>
        public string RecurrenceExpression
        {
            get
            {
                return this.GetProperty("RecurrenceExpression");
            }
            set
            {
                this.SetProperty("RecurrenceExpression", value);
            }
        }

        /// <summary>
        /// Gets or sets the TimeZoneId
        /// </summary>
        public string TimeZoneId
        {
            get
            {
                return this.GetProperty("TimeZoneId");
            }
            set
            {
                this.SetProperty("TimeZoneId", value);
            }
        }

        /// <summary>
        /// Gets or sets the AllDayEvent
        /// </summary>
        public string AllDayEvent
        {
            get
            {
                return this.GetProperty("AllDayEvent");
            }
            set
            {
                this.SetProperty("AllDayEvent", value);
            }
        }

        /// <summary>
        /// Gets or sets the Location
        /// </summary>
        public string Location
        {
            get
            {
                return this.GetProperty("Location");
            }
            set
            {
                this.SetProperty("Location", value);
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

        /// <summary>
        /// Gets or sets the EventStartUtcOffset
        /// </summary>
        public string EventStartUtcOffset
        {
            get
            {
                return this.GetProperty("EventStartUtcOffset");
            }
            set
            {
                this.SetProperty("EventStartUtcOffset", value);
            }
        }

        /// <summary>
        /// Gets or sets the EventEndUtcOffset
        /// </summary>
        public string EventEndUtcOffset
        {
            get
            {
                return this.GetProperty("EventEndUtcOffset");
            }
            set
            {
                this.SetProperty("EventEndUtcOffset", value);
            }
        }

        /// <summary>
        /// Gets or sets the EventStartWithOffset
        /// </summary>
        public string EventStartWithOffset
        {
            get
            {
                return this.GetProperty("EventStartWithOffset");
            }
            set
            {
                this.SetProperty("EventStartWithOffset", value);
            }
        }

        /// <summary>
        /// Gets or sets the EventEndWithOffset
        /// </summary>
        public string EventEndWithOffset
        {
            get
            {
                return this.GetProperty("EventEndWithOffset");
            }
            set
            {
                this.SetProperty("EventEndWithOffset", value);
            }
        }
    }
}
