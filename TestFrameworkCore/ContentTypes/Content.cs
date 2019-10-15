using System;
using System.Collections.Generic;

namespace TestFrameworkCore.ContentTypes
{
    public class Content
    {   
        public void SetProperty(string key, string value)
        {
            if (this.properties.ContainsKey(key))
            {
                this.properties[key] = value;
            }
            else
            {
                this.properties.Add(key, value);
            }
        }

        public string GetProperty(string key)
        {
            string result = null;
            this.properties.TryGetValue(key, out result);

            return result;
        }
        
        /// <summary>
        /// Gets or sets the Title.
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
        /// Gets the LastModified.
        /// </summary>
        public string LastModified
        {
            get
            {
                return this.GetProperty("Content");
            }
        }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the Endpoint Url.
        /// </summary>
        public string EndpointUrl { get; set; }

        public Dictionary<string, string> properties = new Dictionary<string, string>();
    }
}
