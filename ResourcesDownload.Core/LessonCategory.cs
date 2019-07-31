using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ResourcesDownload.Core
{
    public class LessonCategory : XElement
    {

        #region XNames
        public const string ElementName = "Category";

        public const string AttrName_ID = "ID";
        public const string AttrName_Title = "Title";
        public const string AttrName_Url = "Url";
        public const string AttrName_RefreshTime = "Refreshtime";
        #endregion

        public LessonCategory() : base(LessonCategory.ElementName)
        {
        }

        public LessonCategory(XElement element):base(element)
        {

        }

        #region prop ID, Url, Title, RefreshTime
        public string ID
        {
            get
            {

                return (string)this.Attribute(LessonCategory.AttrName_ID);
            }
            set
            {
                this.SetAttributeValue(LessonCategory.AttrName_ID, value);
            }
        }

        public string Url
        {
            get
            {

                return (string)this.Attribute(LessonCategory.AttrName_Url);
            }
            set
            {
                this.SetAttributeValue(LessonCategory.AttrName_Url, value);
            }
        }

        public string Title
        {
            get
            {

                return (string)this.Attribute(LessonCategory.AttrName_Title);
            }
            set
            {
                this.SetAttributeValue(LessonCategory.AttrName_Title, value);
            }
        }

        public DateTime RefreshTime
        {
            get
            {

                return (DateTime)this.Attribute(LessonCategory.AttrName_RefreshTime);
            }
            set
            {
                this.SetAttributeValue(LessonCategory.AttrName_RefreshTime, value);
            }
        }
        #endregion
    }
}
