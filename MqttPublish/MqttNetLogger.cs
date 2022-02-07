using MQTTnet.Diagnostics.Logger;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttPublisher
{
    public class MqttNetLogger : IMqttNetLogger
    {
        public bool IsEnabled => true;

        public void Publish(MqttNetLogLevel logLevel, string source, string message, object[] parameters, Exception exception)
        {
            var msg = message;
            if( parameters != null)
            {
                msg = string.Format(message, parameters);
            }
            Console.WriteLine($"{source} :: {msg}");
            Debug.WriteLine($"{source} :: {msg}");
            if (exception != null)
            {
                Console.WriteLine($"Exception: |{exception}");
                Debug.WriteLine($"Exception: |{exception}");
            }
        }
    }
}
