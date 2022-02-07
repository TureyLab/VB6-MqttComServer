using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMqttPublishForm
{
    public partial class Form1 : Form
    {
        private MqttSettings mqttSettings = new MqttSettings();
        
        public Form1()
        {
            InitializeComponent();

            this.propertyGrid1.SelectedObject = this.mqttSettings;
            var newLine = Environment.NewLine;
            this.textBoxTopic.Text = "Test/Message";
            this.richTextBoxPayLoad.Text = $"{{{newLine}   Message: \"Hello World\",{newLine}   Importance: \"high\"{newLine} }}";
        }

        private void Publish_Click(object sender, EventArgs e)
        {   
            var publisher = CreateMqttClient();
            
            var result = publisher.Publish(
                this.mqttSettings.ClientId,
                this.mqttSettings.ServerName, this.mqttSettings.Port,
                this.mqttSettings.Username, this.mqttSettings.Password,
                this.textBoxTopic.Text, this.richTextBoxPayLoad.Text,
                this.mqttSettings.QoS, this.mqttSettings.RetainMessage);

            if( result)
            {
                this.toolStripStatusLabel1.BackColor = Color.Green;
                this.toolStripStatusLabel1.Text = "Success";
            }
            else
            {
                this.toolStripStatusLabel1.BackColor = Color.Red;
                this.toolStripStatusLabel1.Text = "Failure";
            }
        }

        private static dynamic CreateMqttClient()
        {
            Type publishType = Type.GetTypeFromProgID("MqttPublisher.MqttPublish");

            dynamic publisher = Activator.CreateInstance(publishType);
            return publisher;
        }
    }
}
