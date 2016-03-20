using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerLib
{
    /// <summary>
    /// These are as defined in rovercode.c, refer to Code and Manual pdf.
    /// NOTE - SOME COMMANDS ARE NOW DEPRECATED although included for backwards compatibility, their return will be a null.
    /// </summary>
    public enum CommandID : int
    {
        /// <summary>
        /// Null packet
        /// </summary>
        CMDNULL = 0,
        /// <summary>
        /// Get LEDs and Switch Status
        /// </summary>
        CMDGETSW = 1,
        /// <summary>
        /// Set the LEDs on and off, last two bits of payload byte set status
        /// Payload 1 Byte [LEDstatusBits]
        /// </summary>
        CMDSETLED = 2,
        /// <summary>
        /// Request the internal counter from the rover, every request will see this counter increment by one
        /// 2 Bytes [{InternalCounter}]
        /// </summary>
        CMDGETCOUNT = 3,
        /// <summary>
        /// Returns current motor speeds and position 
        /// [OLspeed1 {pos1}  OLspeed2  {pos2}  0 0 0]  {}Denote word (MSB first)
        /// </summary>
        CMDMOTORSTATUS = 4,
        /// <summary>
        /// Sets open loop motor 1 speed. 
        /// Payload 1 Byte treated as signed.
        /// </summary>
        CMDSETMOTOR1 = 5,
        /// <summary>
        /// Sets open loop motor 2 speed. 
        /// Payload 1 Byte treated as signed.
        /// </summary>
        CMDSETMOTOR2 = 6,
        /// <summary>
        /// Sets open loop motor speed for both motors. 
        /// Payload 2 Bytes [OLspeed1  OLspeed2]  Payload bytes are treated as signed.
        /// </summary>
        CMDSETBOTHMOTORS = 7,
        /// <summary>
        /// Return line follower status. 
        /// 5 Bytes [LFStatusByte  {ADforLineA}  {ADforLineB}]  {}Denote word (MSB first)
        /// </summary>
        CMDGETLINEFOLLOW = 8,
        /// <summary>
        /// NOW DEPRECATED
        /// Sets the line follower LEDs on/off AND changes the thresholds for the LFStatusByte bits
        /// 5 Bytes [LEDonOff {LineATh} {LineBTh}]  {}Denote word (MSB first)
        /// </summary>
        CMDSETLINEFOLLOW = 9,
        /// <summary>
        /// NOW DEPRECATED
        /// Returns the AD values for the AUX Light and Thermistor. 
        /// 4 Bytes [{LightAD}  {ThermAD}]   {}Denote word (MSB first)
        /// </summary>
        CMDGETLIGHTTEMP = 17,
        /// <summary>
        /// NOW DEPRECATED
        /// PowerBoard - Set the status of Power Switch. 
        /// Payload 1 Byte, see messages pdf.
        /// </summary>
        CMDPOWERSWITCH = 21,
        /// <summary>
        /// PowerBoard - Set power to 1st Servo. 
        /// Payload 1 Byte, see messages pdf.
        /// </summary>
        CMDPOWERSERV01 = 22,
        /// <summary>
        /// PowerBoard - Set power to 2nd Servo. 
        /// Payload 1 Byte, see messages pdf.
        /// </summary>
        CMDPOWERSERV02 = 23,
        /// <summary>
        /// PowerBoard - Get AD0 reading. 
        /// Payload 1 Word, see messages pdf.
        /// </summary>
        CMDPOWERREADAD0 = 24,
        /// <summary>
        /// PowerBoard - Get AD1 reading.
        /// Payload 1 Word, see messages pdf.
        /// </summary>
        CMDPOWERREADAD1 = 25,
        /// <summary>
        /// PowerBoard - Get the photo didode AD reading. 
        /// Payload 1 Word, see messages pdf.
        /// </summary>
        CMDPOWERREADphotodiode = 26,
        /// <summary>
        /// PowerBoard - Get the thermistor AD reading. 
        /// Payload 1 Word, see messages pdf.
        /// </summary>
        CMDPOWERREADthermistor = 27,
        /// <summary>
        /// Read the back emf values. 
        /// 4 Bytes [{emfMotor1}  {emfMotor2}]  {}Denote word (MSB first)
        /// </summary>
        CMDREADemfs = 30,
        /// <summary>
        /// Returns the AD values for the integrated light sensors. 
        /// 4 Bytes [{Light1} {Light2}]  {}Denote word (MSB first)
        /// </summary>
        CMDRDlightsensors = 31,
        /// <summary>
        /// Returns the MAC address of the Rover's WiFi module
        /// </summary>
        CMDMyMAC = 32,
        /// <summary>
        /// Read Accelerometer. 
        /// 6 Bytes [{X} {Y} {Z}]  See MMA8452Q datasheet from register 0x01 onwards pg18.
        /// </summary>
        CMDREADMMA8452 = 40,
        /// <summary>
        /// Get Gyro Status. 
        /// 2 Bytes [{Stat}]  See L3G4200D datasheet STATUS_REG.
        /// </summary>
        CMDREADgyroSTATUS = 46,
        /// <summary>
        /// Get Gyro. 
        /// 6 Bytes [{X} {Y} {Z}]  See L3G4200D datasheet.  {}Denote word (MSB first)
        /// </summary>
        CMDREADgyro = 43,
        /// <summary>
        /// Get Magnetometer Status. 
        /// 2 Bytes [Reg0x00  Reg0x0f] See HMC5883L datasheet.
        /// </summary>
        CMDREADMagSTATUS = 44,
        /// <summary>
        /// Get Magnetometer. 
        /// 6 Bytes[{X} {Z} {Y}] OR 0 Bytes if nothing new. 
        /// </summary>
        CMDREADMag = 45,
        /// <summary>
        /// Carry out step. 
        /// Takes 1 Word.
        /// </summary>
        CMDdoSTEP = 50,
        /// <summary>
        /// Get step status. 
        /// 1 Byte [Stat]
        /// </summary>
        CMDStepStatus = 51,
        /// <summary>
        /// Read step results. 
        /// 128 Byte [..]
        /// </summary>
        CMDStepRead = 52,
        /// <summary>
        /// Read instantaneous value. 
        /// 2 Bytes [{V}]
        /// </summary>
        CMDstepInstRead = 53,
        /// <summary>
        /// Return up to 128 Samples of Sound. 
        /// Reads larger internal buffer, repeat.
        /// </summary>
        CMDreadSounds = 54,
        /// <summary>
        /// Set open loop motor speed (raw). 
        /// Returns 12 Bytes, mainly for debugging, see rovercode.c
        /// </summary>
        CMDGetMotorSpeedWord = 55,
        /// <summary>
        /// Set closed loop motor speeds. 
        /// Send payload 5 Bytes [{Speed1} {Speed2} DoCL]  {}Denote word (MSB first)
        /// </summary>
        CMDMotorSpeedClosed = 56,
        /// <summary>
        /// Return the position of the rover as reported by the star finder.
        /// 8 Bytes [{X} {Y} {res} {Count}]  Counter increments every time position is updated.
        /// </summary>
        CMDGETstarpos = 57,
        /// <summary>
        /// Return the distance the Rover is from four beacons
        /// 8 Bytes [{distance from A} {distance from B} {distance from C} {distance from D}] Some values may be zero if no distance available.
        /// </summary>
        CMDGETUSGPS = 58,
        /// <summary>
        /// Sends command to start sample buffer
        /// 1 Byte[{1 to enable, 0 to disable}]
        /// </summary>
        CMDQUAKE = 60,
        /// <summary>
        /// Requests contents of buffer, Must be sent about every second to keep buffer clear
        /// Variable bytes[{Values to add}{number of overflow}]
        /// Each overflow means we've missed 254 samples
        /// </summary>
        CMDQUAKEGET = 61
        
    };
}
