using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace MqttPublishTest
{
    [TestClass]
    public class MqttPublishTest
    {
        [TestMethod]
        public void PublishMessage()
        {
            var publisher = new MqttPublisher.MqttPublish();

            publisher.Publish("TestClient", "localhost", 1883, "foo", "bar", "test/PublishMessage", "Hello World", 2, true);
        }

        [TestMethod]
        public void ComTestQos0NoRetain()
        {
            Type t = Type.GetTypeFromCLSID(new Guid("7dc70c4b-11da-455c-a277-9dfc45211174"));
            dynamic server = Activator.CreateInstance(t);            
            server.Publish("TestClient", "localhost", 1883, "foo", "bar", "test/ComTestQos0NoRetain", "Hello World", 0, false);
        }

        [TestMethod]
        public void ComTestQos1NoRetain()
        {
            Type t = Type.GetTypeFromCLSID(new Guid("7dc70c4b-11da-455c-a277-9dfc45211174"));
            dynamic server = Activator.CreateInstance(t);
            server.Publish("TestClient", "localhost", 1883, "foo", "bar", "test/ComTestQos1NoRetain", "Hello World", 1, false);
        }

        [TestMethod]
        public void ComTestQos2NoRetain()
        {
            Type t = Type.GetTypeFromCLSID(new Guid("7dc70c4b-11da-455c-a277-9dfc45211174"));
            dynamic server = Activator.CreateInstance(t);
            server.Publish("TestClient", "localhost", 1883, "foo", "bar", "test/ComTestQos2NoRetain", "Hello World", 2,  false);
        }
        [TestMethod]
        public void ComTestQos0Retain()
        {
            Type t = Type.GetTypeFromCLSID(new Guid("7dc70c4b-11da-455c-a277-9dfc45211174"));
            dynamic server = Activator.CreateInstance(t);
            server.Publish("TestClient", "localhost", 1883, "foo", "bar", "test/ComTestQos0Retain", "Hello World", 0, true);
        }

        [TestMethod]
        public void ComTestQos1Retain()
        {
            Type t = Type.GetTypeFromCLSID(new Guid("7dc70c4b-11da-455c-a277-9dfc45211174"));
            dynamic server = Activator.CreateInstance(t);
            server.Publish("TestClient", "localhost", 1883, "foo", "bar", "test/ComTestQos1Retain", "Hello World", 1, true);
        }

        [TestMethod]
        public void ComTestQos2Retain()
        {
            Type t = Type.GetTypeFromCLSID(new Guid("7dc70c4b-11da-455c-a277-9dfc45211174"));
            dynamic server = Activator.CreateInstance(t);
            server.Publish("TestClient", "localhost", 1883, "foo", "bar", "test/ComTestQos2Retain", "Hello World", 2, true);
        }
    }
}
