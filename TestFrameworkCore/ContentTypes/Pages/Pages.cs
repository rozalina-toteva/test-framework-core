namespace TestFrameworkCore.ContentTypes.Pages
{
    public class Pages : Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pages"/> class.
        /// </summary>
        public Pages()
        {
            this.EndpointUrl = "/sf/system/pages";
        }


        /// <summary>
        /// Gets or sets the Page Type
        /// </summary>
        public string PageType
        {
            get
            {
                return this.GetProperty("PageType");
            }
            set
            {
                this.SetProperty("PageType", value);
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
        /// Gets or sets the ShowInNavigation
        /// </summary>
        public string ShowInNavigation
        {
            get
            {
                return this.GetProperty("ShowInNavigation");
            }
            set
            {
                this.SetProperty("ShowInNavigation", value);
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
        /// Gets or sets the HtmlTitle
        /// </summary>
        public string HtmlTitle
        {
            get
            {
                return this.GetProperty("HtmlTitle");
            }
            set
            {
                this.SetProperty("HtmlTitle", value);
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
        /// Gets or sets the HeadTagContent
        /// </summary>
        public string HeadTagContent
        {
            get
            {
                return this.GetProperty("HeadTagContent");
            }
            set
            {
                this.SetProperty("HeadTagContent", value);
            }
        }

        /// <summary>
        /// Gets or sets the CodeBehindType
        /// </summary>
        public string CodeBehindType
        {
            get
            {
                return this.GetProperty("CodeBehindType");
            }
            set
            {
                this.SetProperty("CodeBehindType", value);
            }
        }

        /// <summary>
        /// Gets or sets the IncludeScriptManager
        /// </summary>
        public string IncludeScriptManager
        {
            get
            {
                return this.GetProperty("IncludeScriptManager");
            }
            set
            {
                this.SetProperty("IncludeScriptManager", value);
            }
        }

        /// <summary>
        /// Gets or sets the EnableViewState
        /// </summary>
        public string EnableViewState
        {
            get
            {
                return this.GetProperty("EnableViewState");
            }
            set
            {
                this.SetProperty("EnableViewState", value);
            }
        }

        /// <summary>
        /// Gets or sets the RedirectPage
        /// </summary>
        public string RedirectPage
        {
            get
            {
                return this.GetProperty("RedirectPage");
            }
            set
            {
                this.SetProperty("RedirectPage", value);
            }
        }

        /// <summary>
        /// Gets or sets the TemplateId
        /// </summary>
        public string TemplateId
        {
            get
            {
                return this.GetProperty("TemplateId");
            }
            set
            {
                this.SetProperty("TemplateId", value);
            }
        }

        /// <summary>
        /// Gets or sets the RequireSsl
        /// </summary>
        public string RequireSsl
        {
            get
            {
                return this.GetProperty("RequireSsl");
            }
            set
            {
                this.SetProperty("RequireSsl", value);
            }
        }

        /// <summary>
        /// Gets or sets the AllowParametersValidation
        /// </summary>
        public string AllowParametersValidation
        {
            get
            {
                return this.GetProperty("AllowParametersValidation");
            }
            set
            {
                this.SetProperty("AllowParametersValidation", value);
            }
        }

        /// <summary>
        /// Gets or sets the Crawlable
        /// </summary>
        public string Crawlable
        {
            get
            {
                return this.GetProperty("Crawlable");
            }
            set
            {
                this.SetProperty("Crawlable", value);
            }
        }

        /// <summary>
        /// Gets or sets the IncludeInSearchIndex
        /// </summary>
        public string IncludeInSearchIndex
        {
            get
            {
                return this.GetProperty("IncludeInSearchIndex");
            }
            set
            {
                this.SetProperty("IncludeInSearchIndex", value);
            }
        }

        /// <summary>
        /// Gets or sets the Priority
        /// </summary>
        public string Priority
        {
            get
            {
                return this.GetProperty("Priority");
            }
            set
            {
                this.SetProperty("Priority", value);
            }
        }

        /// <summary>
        /// Gets or sets the LocalizationStrategy
        /// </summary>
        public string LocalizationStrategy
        {
            get
            {
                return this.GetProperty("LocalizationStrategy");
            }
            set
            {
                this.SetProperty("LocalizationStrategy", value);
            }
        }

        /// <summary>
        /// Gets or sets the CanonicalUrlBehaviour
        /// </summary>
        public string CanonicalUrlBehaviour
        {
            get
            {
                return this.GetProperty("CanonicalUrlBehaviour");
            }
            set
            {
                this.SetProperty("CanonicalUrlBehaviour", value);
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
        /// Gets or sets the HasChildren
        /// </summary>
        public string HasChildren
        {
            get
            {
                return this.GetProperty("HasChildren");
            }
            set
            {
                this.SetProperty("HasChildren", value);
            }
        }

        /// <summary>
        /// Gets or sets the Breadcrumb
        /// </summary>
        public string Breadcrumb
        {
            get
            {
                return this.GetProperty("Breadcrumb");
            }
            set
            {
                this.SetProperty("Breadcrumb", value);
            }
        }

        /// <summary>
        /// Gets or sets the AvailableLanguages
        /// </summary>
        public string AvailableLanguages
        {
            get
            {
                return this.GetProperty("AvailableLanguages");
            }
            set
            {
                this.SetProperty("AvailableLanguages", value);
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
        /// Gets or sets the ViewUrl
        /// </summary>
        public string ViewUrl
        {
            get
            {
                return this.GetProperty("ViewUrl");
            }
            set
            {
                this.SetProperty("ViewUrl", value);
            }
        }

        /// <summary>
        /// Gets or sets the IsHomePage
        /// </summary>
        public string IsHomePage
        {
            get
            {
                return this.GetProperty("IsHomePage");
            }
            set
            {
                this.SetProperty("IsHomePage", value);
            }
        }

        /// <summary>
        /// Gets or sets the RelativeUrlPath
        /// </summary>
        public string RelativeUrlPath
        {
            get
            {
                return this.GetProperty("RelativeUrlPath");
            }
            set
            {
                this.SetProperty("RelativeUrlPath", value);
            }
        }
    }
}