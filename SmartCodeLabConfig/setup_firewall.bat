@echo off
netsh advfirewall firewall add rule name="Temp_Port" dir=in action=allow protocol=TCP localport=1901
netsh advfirewall firewall add rule name="Temporary_Port_Allow" dir=in action=allow protocol=UDP localport=1902