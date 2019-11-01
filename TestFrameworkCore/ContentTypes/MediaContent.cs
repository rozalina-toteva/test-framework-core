using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkCore.ContentTypes
{
    public class MediaContent : Content
    {
        /// <summary>
        /// Gets or sets the ParentId.
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
    }
}
