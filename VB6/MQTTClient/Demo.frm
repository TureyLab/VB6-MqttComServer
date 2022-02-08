VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5115
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   6900
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   11.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   5115
   ScaleWidth      =   6900
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text1 
      Height          =   3495
      Left            =   480
      MultiLine       =   -1  'True
      TabIndex        =   1
      Text            =   "Demo.frx":0000
      Top             =   1200
      Width           =   5895
   End
   Begin VB.CommandButton cmdConnect 
      Caption         =   "Connect"
      Height          =   475
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   1815
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Allocated As Boolean

 Dim counter As Integer
 Dim payload As String
 
 
Private Sub cmdConnect_Click()
 
 Dim mqttConnection As New MqttPublish.MqttPublish
    Dim client As String
   
    Dim username As String
    Dim password As String
    Dim hostname As String
    Dim topic As String
    Dim port As Integer
    Dim qos As Integer
    Dim retainMessage As String
    
    
    
    
    client = "TestClient " & counter
    hostname = "localhost"
    port = 1883
    username = "foo"
    password = "bar"
    topic = "test/me"
    payload = "Hello World"
    qos = 2
    retainMessage = 1
    payload = Text1.Text
    
     mqttConnection.Publish client, hostname, port, username, password, topic, payload, qos, retainMessage
  
    
    counter = counter + 1
       
 End Sub
 
 Private Sub form_load()
 payload = "{" & vbCrLf _
& "Message: ""Hello World""," & vbCrLf _
& "Importance: ""high""," & vbCrLf _
& "Something: ""more""" & vbCrLf _
& "sdfsdf: ""teste""" & vbCrLf _
& "}"
    Text1.Text = payload
 End Sub
 





