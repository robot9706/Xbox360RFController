# Xbox360 RF module controller:

Using this program you can send commands to an Xbox360 RF module without any microcontroller (for ex.: Ardunio).
So you can SYNC your Xbox360 controller with your DIY receiver using one serial port (virtual is OK too).

## Setup:

Connect the CTS of the serial port to pin 7 on the RF board (it's the Clock).

Connect the RTS of the serial port to pin 6 on the RF board (it's the Data).

## IMPORTANT:

If you're using a virtual port (for example an FTDI converter) then simply connect the RTS and CTS.
!BUT! if you're using a real/hardware serial port then you need to match the voltage levels. 
The RF module uses 0-3.3V but the serial port is (-12)-12V so you can easily damage the RF board.
 
It looks like, that only FTDI chips are capable of outputing ~340Hz for the clock, so other virtual (USB) serial ports may NOT work.

Make sure that the RF module and your serial port have common ground [connect them :)].
 
## Program:

Download the "Xbox360RFModuleSerial.exe" from the "bin/Debug" folder, start it, select the COM port which is connected to the RF module and that's it. You can send commands to the module.
 
## ATTiny85 method

A simple code is included in the "ATTiny85_code" folder. This code makes it easy to sync controllers to an RF board.
