using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakingFileAsParameter.Models
{
    public class MyJsonModel
    {
        public ArrayOfPNRQueue ArrayOfPNRQueue { get; set; }
    }

    public class ArrayOfPNRQueue
    {
        public List<PNRQueue> PNRQueue { get; set; }
    }

    public class PNRQueue
    {
        public string QueueName { get; set; }
        public string PaymentMode { get; set; }
        public string TemplateBody { get; set; }
        public string TemplateID { get; set; }
    }
}
