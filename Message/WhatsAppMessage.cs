using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace SiaWhatsApp.Message
{
    public class WhatsAppMessage
    {
        public string messaging_product { get; set; }
        public string to { get; set; }
        public TypeMessage type { get; set; }
        public TextMessage text { get; set; }
        public Template template { get; set; }
        public ImageMessage image { get; set; }
    }
}
