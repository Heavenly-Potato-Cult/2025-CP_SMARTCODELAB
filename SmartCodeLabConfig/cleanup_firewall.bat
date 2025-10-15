@echo off
netsh advfirewall firewall delete rule name="Temp_Port"
netsh advfirewall firewall delete rule name="Temporary_Port_Allow"
echo Firewall rules removed successfully
pause