
namespace TestMqttPublishForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.Publish = new System.Windows.Forms.Button();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.Topic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxPayLoad = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(13, 13);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(401, 425);
            this.propertyGrid1.TabIndex = 0;
            // 
            // Publish
            // 
            this.Publish.Location = new System.Drawing.Point(438, 383);
            this.Publish.Name = "Publish";
            this.Publish.Size = new System.Drawing.Size(350, 55);
            this.Publish.TabIndex = 1;
            this.Publish.Text = "button1";
            this.Publish.UseVisualStyleBackColor = true;
            this.Publish.Click += new System.EventHandler(this.Publish_Click);
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(438, 41);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(350, 23);
            this.textBoxTopic.TabIndex = 2;
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Location = new System.Drawing.Point(438, 13);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(36, 15);
            this.Topic.TabIndex = 3;
            this.Topic.Text = "Topic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payload";
            // 
            // richTextBoxPayLoad
            // 
            this.richTextBoxPayLoad.Location = new System.Drawing.Point(438, 103);
            this.richTextBoxPayLoad.Name = "richTextBoxPayLoad";
            this.richTextBoxPayLoad.Size = new System.Drawing.Size(350, 263);
            this.richTextBoxPayLoad.TabIndex = 5;
            this.richTextBoxPayLoad.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBoxPayLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.Publish);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button Publish;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxPayLoad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

