using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Markup;
using System.Workflow.ComponentModel.Serialization;

[assembly: XmlnsDefinition("schema:ResourcesDownload.Core", "RDCore")]
namespace ResourcesDownload.Core
{
    public class LessonSource : XElement
    {
        #region XNames
        public const string ElementName = "Source";
        public const string ElementNameCategories = "Categories";

        public const string AttrName_ID = "ID";
        public const string AttrName_Title = "Title";
        public const string AttrName_Url = "Url";
        #endregion

        public LessonSource() : base(LessonSource.ElementName)
        {

        }

        public LessonSource(XElement element) : base(element)
        {

        }

        #region prop ID, Url, Title, Categories
        public string ID
        {
            get
            {

                return (string)this.Attribute(LessonSource.AttrName_ID);
            }
            set
            {
                this.SetAttributeValue(LessonSource.AttrName_ID, value);
            }
        }

        public string Url
        {
            get
            {

                return (string)this.Attribute(LessonSource.AttrName_Url);
            }
            set
            {
                this.SetAttributeValue(LessonSource.AttrName_Url, value);
            }
        }

        public string Title
        {
            get
            {

                return (string)this.Attribute(LessonSource.AttrName_Title);
            }
            set
            {
                this.SetAttributeValue(LessonSource.AttrName_Title, value);
            }
        }

        public IEnumerable<LessonCategory> Category { get; }
        #endregion

        public void AddCategory(LessonCategory category)
        {
            if (this.Element(LessonSource.ElementNameCategories) == null)
                this.Add(new XElement(LessonSource.ElementNameCategories));

            this.Element(LessonSource.ElementNameCategories).Add(category);
        }
    }
}
