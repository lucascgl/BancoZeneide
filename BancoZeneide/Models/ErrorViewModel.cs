using System;

namespace BancoZeneide.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Mensagem { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}