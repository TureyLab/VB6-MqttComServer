using System;
using System.Runtime.InteropServices;

[ComVisible(true)]
[Guid(ContractGuids.ServerInterface)]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
public interface IMqttPublish
{
    bool Publish(string clientID, string hostname, int port, string username, string password, string topic, string payload, int qos, bool retainMessage);
}

