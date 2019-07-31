using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ResourcesDownload.Core
{
    public class EpisodeInfo : XElement
    {
        #region XNames
        public const string ElementName = "EI";

        public const string AttrName_ID = "ID";
        public const string AttrName_Title = "Title";
        public const string AttrName_Url = "Url";
        public const string AttrName_DateTime = "DateTime";
        public const string AttrName_RefreshTime = "Refreshtime";
        #endregion

        public EpisodeInfo() : base(EpisodeInfo.ElementName)
        {

        }

        public EpisodeInfo(XElement element) : base(element)
        {

        }


        #region prop ID, Url, Title, RefreshTime
        public string ID
        {
            get
            {

                return (string)this.Attribute(EpisodeInfo.AttrName_ID);
            }
            set
            {
                this.SetAttributeValue(EpisodeInfo.AttrName_ID, value);
            }
        }

        public string Url
        {
            get
            {

                return (string)this.Attribute(EpisodeInfo.AttrName_Url);
            }
            set
            {
                this.SetAttributeValue(EpisodeInfo.AttrName_Url, value);
            }
        }

        public string Title
        {
            get
            {

                return (string)this.Attribute(EpisodeInfo.AttrName_Title);
            }
            set
            {
                this.SetAttributeValue(EpisodeInfo.AttrName_Title, value);
            }
        }

        public DateTime DateTime
        {
            get
            {

                return (DateTime)this.Attribute(EpisodeInfo.AttrName_DateTime);
            }
            set
            {
                this.SetAttributeValue(EpisodeInfo.AttrName_DateTime, value);
            }
        }

        public DateTime RefreshTime
        {
            get
            {

                return (DateTime)this.Attribute(EpisodeInfo.AttrName_RefreshTime);
            }
            set
            {
                this.SetAttributeValue(EpisodeInfo.AttrName_RefreshTime, value);
            }
        }
        #endregion
    }
}
