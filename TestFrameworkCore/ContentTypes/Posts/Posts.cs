using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkCore.ContentTypes.Posts
{
    public class Posts : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Posts"/> class.
        /// </summary>
        public Posts()
        {
            this.EndpointUrl = "/sf/system/blogposts";
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
        /// Gets or sets the Title
        /// </summary>
        public string Title
        {
            get
            {
                return this.GetProperty("Title");
            }
            set
            {
                this.SetProperty("Title", value);
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
