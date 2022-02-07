using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMqttPublishForm
{
    public class MqttSettings
    {
        public string ClientId { get; set; } = "TestPublishForm";
        public string ServerName { get; set; } = "localhost";
        public int Port { get; set; } = 1883;
        public int QoS { get; set; } = 0;
        public bool RetainMessage { get; set; } = false;
        public string Username { get; set; } = "Foo";
        public string Password { get; set; } = "Bar";
    }
}
