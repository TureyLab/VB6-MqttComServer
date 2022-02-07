using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Protocol;

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MqttPublisher
{
    [ComVisible(true)]
    [Guid(ContractGuids.ServerClass)]    
    [ProgId("MqttPublisher.MqttPublish")]
    public class MqttPublish : IMqttPublish
    {
        // Create MQTT client
        static MqttFactory factory = new MqttFactory();
        private static MqttNetLogger logger = new MqttNetLogger();
        private IMqttClient mqttClient = factory.CreateMqttClient(logger);

        public bool Publish(string clientID, string hostname, int port, string username, string password, string topic, string payload, int qos, bool retainMessage)
        {        
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            if (!InitializeMQTTclientAsync(clientID, hostname, port, username, password).GetAwaiter().GetResult())
            {
                MqttPublish.logger.Publish(MQTTnet.Diagnostics.Logger.MqttNetLogLevel.Error, "Publish", "Could not initalize mqtt client", null, null);
                //throw new Exception("Init not successfull");
                return false;
            }

            if (!PublishMessage(topic, payload, qos, retainMessage).GetAwaiter().GetResult() )
            {
                MqttPublish.logger.Publish(MQTTnet.Diagnostics.Logger.MqttNetLogLevel.Error, "Publish", "Could not publish message", null, null);
                //throw new Exception("Could not publish");
                return false;
            }

            mqttClient.DisconnectAsync().GetAwaiter().GetResult();

            return true;
        }

        private async Task<bool> InitializeMQTTclientAsync(string clientId, string server, int port, string username, string password)
        {
            bool result = false;
            try
            {                
                // Create TCP based options using the builder.
                var options = new MqttClientOptionsBuilder()                    
                    .WithClientId(clientId)
                    .WithTcpServer(server, port)
                    .WithCredentials(username, password)
                    .WithProtocolVersion(MQTTnet.Formatter.MqttProtocolVersion.V500)
                    .WithCleanSession(true)         
                    .Build();

                // Since 3.0.5 with CancellationToken
                await mqttClient.ConnectAsync(options, CancellationToken.None).ConfigureAwait(false);
                
                result = CheckConnectionStatus();

                return result;
            }
            catch (Exception ex)
            {
                MqttPublish.logger.Publish(MQTTnet.Diagnostics.Logger.MqttNetLogLevel.Error, "InitializeMQTTclientAsync", "Exception caught", null, ex);                
            }
            return false;
        }

        private bool CheckConnectionStatus()
        {
            bool status = true;

            if (mqttClient == null || !mqttClient.IsConnected)
            {
                status = false;
            }

            return status;
        }

        private async Task<bool> PublishMessage(string topic, string payload, int qos, bool retainMessage)
        {
            try
            {
                if (CheckConnectionStatus())
                {
                    var message = new MqttApplicationMessageBuilder()
                        .WithTopic(topic)
                        .WithPayload(payload)
                        .WithQualityOfServiceLevel(GetQoS(qos))
                        .WithRetainFlag(retainMessage)
                        .Build();

                    await mqttClient.PublishAsync(message, CancellationToken.None).ConfigureAwait(false);
                    return true;
                }
                else
                {
                    MqttPublish.logger.Publish(MQTTnet.Diagnostics.Logger.MqttNetLogLevel.Error, "PublishMessage", "Could not publish message: connection closed", null, null);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MqttPublish.logger.Publish(MQTTnet.Diagnostics.Logger.MqttNetLogLevel.Error, "PublishMessage", "Exception caught", null, ex);
                return false;
            }
        }

        private MqttQualityOfServiceLevel GetQoS(int qos)
        {
            switch (qos)
            {
                case 0:
                    return MqttQualityOfServiceLevel.AtMostOnce;
                case 1:
                    return MqttQualityOfServiceLevel.AtLeastOnce;
                case 2:
                    return MqttQualityOfServiceLevel.ExactlyOnce;
                default:
                    var msg = $"Unknown qos: {qos}, supported values are 0,1,2";
                    MqttPublish.logger.Publish(MQTTnet.Diagnostics.Logger.MqttNetLogLevel.Error, "GetQoS", msg, null, null);
                    throw new Exception(msg);
            }
        }
    }
}
