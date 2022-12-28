using SiaWhatsApp.Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SiaWhatsApp.Message
{
    public class Template
    {
        public string name { get; set; }
        public Language language { get; set; }
        public List<SiaWhatsApp.Template.Component> components { get; set; }
    }
}
