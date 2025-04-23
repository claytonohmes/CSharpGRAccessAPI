using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MyFirstApi
{
    [XmlRoot("raw_reason_list")]
    public class RawReasonList
    {
        [XmlElement("default_raw_reason")]
        public DefaultRawReason DefaultRawReason { get; set; }

        [XmlElement("raw_reason")]
        public List<RawReason> RawReasons { get; set; }
    }

    public class DefaultRawReason
    {
        [XmlAttribute("raw_reas_cd")]
        public string RawReasonCode { get; set; }

        [XmlAttribute("overwrite")]
        public bool Overwrite { get; set; }
    }

    public class RawReason
    {
        [XmlAttribute("raw_reas_cd")]
        public string RawReasonCode { get; set; }

        [XmlAttribute("prompt")]
        public bool Prompt { get; set; }

        [XmlAttribute("priority")]
        public int Priority { get; set; }

        [XmlAttribute("min_time_before_activation")]
        public string MinTimeBeforeActivation { get; set; }

        [XmlAttribute("last_edit_comment")]
        public string LastEditComment { get; set; }

        [XmlAttribute("description")]
        public string Description { get; set; }

        [XmlElement("expression")]
        public string Expression { get; set; }

        [XmlElement("default_reason")]
        public DefaultReason DefaultReason { get; set; }
    }

    public class DefaultReason
    {
        [XmlAttribute("reas_grp_desc_1")]
        public string ReasonGroupDescription1 { get; set; }

        [XmlAttribute("reas_grp_desc_2")]
        public string ReasonGroupDescription2 { get; set; }

        [XmlAttribute("reas_grp_desc_3")]
        public string ReasonGroupDescription3 { get; set; }

        [XmlAttribute("reas_desc")]
        public string ReasonDescription { get; set; }

        [XmlAttribute("last_edit_comment")]
        public string LastEditComment { get; set; }
    }
}
