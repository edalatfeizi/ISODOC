

namespace IsoDocApp.Models
{
    public class ChatMessage
    {
        public string SenderUser { get; set; }
        public string ReceiverUser { get; set; }
        public string Message { get; set; }
        public string SendDateTime { get; set; }    
    }
}
