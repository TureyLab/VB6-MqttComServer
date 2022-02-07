# VB6-MqttComServer
VB6-MqttComServer


Build instructions

- To create the TLB,  please run 
MIDL.exe .\MqttPublish\MqttPublish.idl

- Then build the project with
dotnet build .\MqttPublish\MqttPublish.csproj

- Register the com dll
regsrv32.exe .\MqttPublish\bin\release\net5.0\MqttPublish.comhost.dll