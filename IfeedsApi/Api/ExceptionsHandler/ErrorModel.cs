using System;

namespace IfeedsApi.Api.ExceptionsHandler
{
    public class ErrorModel
    {
        public int Status { get; set; }
        public DateTime Timestamp { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string UserMessage { get; set; }

    }
}