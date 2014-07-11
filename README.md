Xbox360 RF module controller:

Using this program you can send commands to an Xbox360 RF module without any microcontroller (for ex.: Ardunio).
So you can SYNC your Xbox360 controller with your DIY receiver using one serial port (virtual is OK too).

Setup:
-Connect the CTS of the serial port to pin 7 on the RF board (it's the Clock).
-Connect the RTS of the serial port to pin 6 on the RF board (it's the Data).

IMPORTANT:
-If you're using a virtual port (for example with an FTDI TTL chip) then simply connect the RTS and CTS.
 !BUT! if you're using a real/hardware serial port then you need to match the voltage levels. 
 The RF module uses 0-3.3V but the serial port is (-12)-12V!!!

-Make sure that the RF module and your serial port has common ground [connect them :)].
 
Program:
If the setup is done, then start the program, select the port, open it, and that's it, you can send commands! :D
Just download the Release1.0.zip, unzip it and start the Xbox360RFModuleSerial.exe.
 
By Robot9706 ~ 2014