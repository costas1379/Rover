using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServerLib;

namespace WIFIGUIDemo
{
    using Helpers;

    public partial class Main : Form
    {
        #region PRIVATE DATA MEMBERS
        //variable to use inputDialog box
        bool useDialog = true;

        //TCP Client variable from 
        TCPClient theClient;
        #endregion

        /// <summary>
        /// Main Form Constructor
        /// </summary>
        /// 
        float nomalise_data(float angle, float max, float min)
        {
            float normalised_angle;

            normalised_angle = (angle - ((max + min) / 2)) / ((max - min) / 2);

            return normalised_angle;
        }

        public Main()
        {
            InitializeComponent();
        }
        //Gloabl Variables
        //location and bearing 
        int x_coord;
        int y_coord;
        double bearing;
        float[] towerX = new float[4] { 300, 0, 0, 300 };
        float[] towerY = new float[4] { 0, 300, 0, 300 };
        List<double> CoordsX = new List<double>();
        List<double> CoordsY = new List<double>();
        //light vars
        int LightReading1 = 0;
        int LightReading2 = 0;
        int li = 0;
        int lx1 = 0, lx2 =0, ly1 = 5, ly2 = 5;
        int lx3 = -10, lx4 = -10, ly3 = 5, ly4 = 5;
        int[] lightar1 = { 0, 0, 0 };
        int[] lightar2 = { 0, 0, 0 };
        int lightarc = 1;
        Color myColour1;
        Color myColour2;
        //Rotary encoder
        int motor_position = 0;
        int flag_wantedmotorpos;
        int flag_travelling = 0; // traveling direction. 0 = stationary, 1 = forward, 2 = backward
        //Magnetometer
        double flag_heading = 0;
        double flag_northheading = 318.7;
        double flag_wantedheading;
        bool flag_vortexsample = false;
        bool flag_setnorth = false;
        bool flag_rotating = false;
        int flag_magzero = 0;
        int x_max = -30000;
        int y_max = -30000;
        int z_max = -30000;
        int x_min = 30000;
        int y_min = 30000;
        int z_min = 30000;
        //Accelerometer
        short xAccMax = -32000, xAccMin = 32000, yAccMax = -32000, yAccMin = 32000, zAccMax = -32000, zAccMin = 32000;
        short Xzero;
        short Yzero;
        short Zzero;
        bool Accl_Zeroed = false;
        double angleB = 0, angleD = 0, lengthF = 0, lengthA = 0, lengthC = 0, lengthH = 0;
        double lengthL = 152;
        double flag_pitch = 0;
        double pastPitch=-0;
        //
        int timerAngle = 0;
        double timermaga =0;
        int noOfSpins=0;
        double startAngle;
        double prevAngle;

        //Earthquake
        bool flag_sampleearthquake;
        List<int> edata = new List<int>();
        int etimercycles = 0;

        /// <summary>
        /// Main Form entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            theClient = new TCPClient();

            if (useDialog)
            {
                //On program entry open dialog box to enter IP Address
                inputDialog IPinput = new inputDialog();
                IPinput.ShowDialog();

                try
                {
                    //Subscribe to message received event
                    theClient.OnMessageReceived += new ClientBase.ClientMessageReceivedEvent(DataReceived_Handler);

                    //Connect the Client to the server based on passed data
                    theClient.ConnectToServer(IPinput.IP, 9760);

                    //Set the appropriate form elements
                    txtIPAddress.Text = IPinput.IP;
                    txtPort.Text = "9760";

                    //Disable appropriate button and enable others
                    cmdConnect.Enabled = false;
                    cmdDisconnect.Enabled = true;
                }
                catch
                {
                    //Show a messagebox to the user saying that the program was unable to connect to the specified rover
                    MessageBox.Show("Unable to connect to Rover Server");

                    //Disable appropriate form elements and enable others
                    cmdConnect.Enabled = true;
                    cmdDisconnect.Enabled = false;
                    txtIPAddress.Enabled = true;
                    txtPort.Enabled = true;
                }
            }
            else
            {
                //Set appropriate form elements
                cmdConnect.Enabled = true;
                cmdDisconnect.Enabled = false;
                txtIPAddress.Enabled = true;
                txtPort.Enabled = true;
            }
        }

        /// <summary>
        /// Data received handler - when data is pushed from the rover to this program the event handler here
        /// parses the incoming data
        /// </summary>
        /// <param name="e"></param>


        private void DataReceived_Handler(Client_Message_EventArgs e)
        {
            //Take the new data received and convert it into a more manageable format
            List<byte> NewData = e.RawMessage.ToList();

            if (NewData.Count > 3)
            {
                //Switch on the commandID set in the common.cs file
                switch (NewData[3])
                {
                    case (byte)CommandID.CMDNULL:
                        break;
                    //If internal counter byte received
                    case (byte)CommandID.CMDGETCOUNT:
                        //Invokation to allow cross thread manipulation
                        this.BeginInvoke(new EventHandler(delegate
                        {
                            txtCounter.Text = (NewData[4] + (NewData[5] << 8)).ToString();
                        }));
                        break;
                    //Command ID byte to show the switch and LED current status
                    case (byte)CommandID.CMDGETSW:
                        //Invokation to allow cross thread manipulation
                        this.BeginInvoke(new EventHandler(delegate
                        {
                            chkSwitch1Stat.Checked = ((NewData[4] & 0x01) == 0x01) ? true : false;
                            chkSwitch2Stat.Checked = ((NewData[4] & 0x02) == 0x02) ? true : false;
                            chkGreenStat.Checked = ((NewData[4] & 0x10) != 0x10) ? true : false;
                            chkRedStat.Checked = ((NewData[4] & 0x20) != 0x20) ? true : false;
                        }));
                        break;
                    case (byte)CommandID.CMDMOTORSTATUS:
                        {
                            int leftmotorpos = (short)(NewData[5] << 8 | NewData[6]);
                            int rightmotorpos = (short)(NewData[8] << 8 | NewData[9]);
                            motor_position = (rightmotorpos + leftmotorpos) / 2;
                            this.BeginInvoke(new EventHandler(delegate
                            {
                                lblloftmotorpos.Text = leftmotorpos.ToString();
                                lblrightmotorpos.Text = rightmotorpos.ToString();
                            }));
                            if (flag_travelling == 1)
                            {
                                if (motor_position > flag_wantedmotorpos - 100)
                                {
                                    setmotorspeed(30, 30);
                                }
                                if (motor_position > flag_wantedmotorpos)
                                {
                                    stopmotors();

                                }
                            }
                            if (flag_travelling == 2)
                            {
                                if (motor_position < flag_wantedmotorpos + 100)
                                {
                                    setmotorspeed(-30, -30);
                                }
                                if (motor_position < flag_wantedmotorpos)
                                {
                                    stopmotors();
                                }
                            }
                        }
                        break;
                    case (byte)CommandID.CMDRDlightsensors:
                        {

                            LightReading1 = (short)(NewData[4] << 8 | NewData[5]);
                            LightReading2 = (short)(NewData[6] << 8 | NewData[7]);
                            //flag_LightData = true;


                            this.BeginInvoke(new EventHandler(delegate
                            {

                                // label10.Text = LightReading1.ToString();
                                //label11.Text = LightReading2.ToString();


                            }));
                        }
                        break;
                    case (byte)CommandID.CMDGETUSGPS:
                        this.BeginInvoke(new EventHandler(delegate
                        {                                               // Option 1 - calculates the location (see HandleUSGPSReply)
                                                                        // Option 2 - the distances are available as 8 8 bit bytes = 4 16 bit integers
                            Option_1_HandleUSGPSReply(NewData);         // This executes Option 1
                            //Option_2_HandleUSGPSReply(NewData);         // This executes Option 2
                        }));
                        break;
                    case (byte)CommandID.CMDREADMag:
                        {

                            int xMag = (short)(NewData[4] << 8 | NewData[5]); //-32k - 32k
                            int yMag = (short)(NewData[6] << 8 | NewData[7]);
                            int zMag = (short)(NewData[8] << 8 | NewData[9]);


                            if (flag_magzero == 1)   //DOCALIBRATEMAG
                            {

                                if (xMag > x_max)
                                {
                                    x_max = xMag;
                                }

                                if (xMag < x_min)
                                {
                                    x_min = xMag;
                                }

                                if (yMag > y_max)
                                {
                                    y_max = yMag;
                                }

                                if (yMag < y_min)
                                {
                                    y_min = yMag;
                                }

                                if (zMag > z_max)
                                {
                                    z_max = zMag;
                                }

                                if (zMag < z_min)
                                {
                                    z_min = zMag;
                                }
                                this.BeginInvoke(new EventHandler(delegate
                                {
                                    lblangle.Text = yMag.ToString();
                                    lblmagxmin.Text = x_min.ToString();
                                    lblmagxmax.Text = x_max.ToString();
                                    lblmagymin.Text = y_min.ToString();
                                    lblmagymax.Text = y_max.ToString();
                                    lblmagzmin.Text = z_min.ToString();
                                    lblmagzmax.Text = z_max.ToString();
                                }));

                            }
                            else
                            {


                                //normalise the data - http://www.benetzkorn.com/2011/11/data-normalization-and-standardization/
                                float xMagNorm = nomalise_data(xMag, x_max, x_min);
                                float yMagNorm = nomalise_data(yMag, y_max, y_min);
                                float zMagNorm = nomalise_data(zMag, z_max, z_min);


                                //Get the angle- https://learn.adafruit.com/lsm303-accelerometer-slash-compass-breakout/coding
                                double MagAngle = (Math.Atan2(yMagNorm, xMagNorm) * 180) / Math.PI;

                                // Normalize to 0-360
                                if (MagAngle < 0)
                                {
                                    MagAngle = 360 + MagAngle;
                                }

                                flag_heading = MagAngle; //WE ARE HAPPY
                                if (flag_setnorth == true)
                                {
                                    flag_northheading = MagAngle;
                                    flag_setnorth = false;
                                    this.BeginInvoke(new EventHandler(delegate
                                    {
                                        lblnorthbearing.Text = flag_northheading.ToString();
                                    }));
                                }
                                else
                                {
                                    if (flag_rotating == true)
                                    {
                                        this.BeginInvoke(new EventHandler(delegate
                                        {
                                            lblangle.Text = MagAngle.ToString();
                                        }));
                                        if ((flag_heading < flag_wantedheading + 5) && (flag_heading > flag_wantedheading - 5))
                                        {
                                            stopmotors();
                                            flag_rotating = false;
                                            tmrangle.Enabled = false;
                                        }

                                    }
                                    else
                                    {
                                        if (flag_vortexsample == true)
                                        {
                                            //Code to sample the angle and update plot
                                            timermaga = MagAngle;
                                            
                                             
                                        }
                                        else
                                            this.BeginInvoke(new EventHandler(delegate
                                            {

                                                //textBox5.Text = xMag.ToString();
                                                //textBox3.Text = yMag.ToString();
                                                //textBox4.Text = zMag.ToString();
                                                //textBox7.Text = xMagNorm.ToString();
                                                //textBox8.Text = yMagNorm.ToString();
                                                //textBox9.Text = zMagNorm.ToString();
                                                lblangle.Text = MagAngle.ToString();
                                            }));
                                    }
                                }
                            }
                        }
                        break;

                    case (byte)CommandID.CMDREADMMA8452:
                        {


                            short Accelx = (short)(NewData[4] << 8 | NewData[5]);
                            short Accely = (short)(NewData[6] << 8 | NewData[7]);
                            short Accelz = (short)(NewData[8] << 8 | NewData[9]); // ASK FOR HELP READING IN

                            if (Accelx < xAccMin) xAccMin = Accelx;
                            if (Accelx > xAccMax) xAccMax = Accelx;
                            if (Accely < yAccMin) yAccMin = Accely;
                            if (Accely > yAccMax) yAccMax = Accely;
                            if (Accelz < zAccMin) zAccMin = Accelz;
                            if (Accelz > zAccMax) zAccMax = Accelz;
                            if (Accl_Zeroed == false)
                            {
                                //  Xzero = Accelx;
                                //  Yzero = Accely;
                                //  Zzero = Accelz;
                                Accl_Zeroed = true;
                            }
                            double x = (Accelx - Xzero) / 16768.0F;
                            double y = (Accely - Yzero) / 16768.0F;
                            double z = (Accelz - Zzero) / 16768.0F;

                            //Add code for angle
                            double pitch = -1.0F * Math.Atan2(x, Math.Sqrt((y * y) + (z * z)));                            pitch = pitch * (180 / Math.PI)-3;
                            flag_pitch = pitch;


                            this.BeginInvoke(new EventHandler(delegate
                            {
                                LblAccelX.Text = pitch.ToString();
                                LblAccelY.Text = y.ToString();

                            }));
                        }
                        break;
                    case (byte)CommandID.CMDQUAKE:
                        {
                            if (chkesampling.Checked == true)
                            {
                                this.BeginInvoke(new EventHandler(delegate
                                {

                                    chkesampling.Checked = false;
                                }));
                            } else
                            {
                                this.BeginInvoke(new EventHandler(delegate
                                {

                                    chkesampling.Checked = true;
                                }));
                            }
                        }
                        break;

                    case (byte)CommandID.CMDQUAKEGET:
                        {
                            if (flag_sampleearthquake == true)
                            {
                                if (NewData[4] != 0) // checks if there is a new set of info to be added
                                {
                                    if (NewData[5] != 0)// If an overflow has occured the fills buffer with 0s for the number of overflow that occured.
                                    {
                                        for (int j = 0; j <= NewData[5]; j++)
                                        {
                                            for (int i = 0; i <= 127; i++)
                                            {
                                                edata.Add(0);
                                                i++;
                                            }
                                        }
                                    }
                                    for (int i = 0; i <= 127; i++)
                                    {
                                        short value = (short)(NewData[i + 6] << 8 | NewData[i + 7]);
                                        edata.Add(value);
                                        i++;
                                    }

                                }
                                //theClient.SendData(CommandID.CMDQUAKEGET, new byte[] { });
                                this.BeginInvoke(new EventHandler(delegate
                                {
                                    lblearthsamplestaken.Text = edata.Count().ToString();
                                    lbletimercycles.Text = etimercycles.ToString();
                                }));
                            }

                        }
                        break;

                }
            }
        }

        private void Option_2_HandleUSGPSReply(List<byte> newData)
        {
            double distanceFromA = BitConverter.ToInt16(newData.ToArray(), 0);    // reconstruct the 16 bit distance from Beacon A
            double distanceFromB = BitConverter.ToInt16(newData.ToArray(), 2);    // reconstruct the 16 bit distance from Beacon B
            double distanceFromC = BitConverter.ToInt16(newData.ToArray(), 4);    // reconstruct the 16 bit distance from Beacon C
            double distanceFromD = BitConverter.ToInt16(newData.ToArray(), 6);    // reconstruct the 16 bit distance from Beacon D

            // Do something with the distances!
            // eg. Console.WriteLine($"Distance from A: {distanceFromA}, from B: {distanceFromB}, from C: {distanceFromC}, from D {distanceFromD}.");
            /*
                if ((distanceFromA > 848) or (distanceFromB > 848) or (distanceFromC > 848) or (distanceFromD > 848))                   // based on 600 x 600 grid.
                {
                    //Out of bounds!
                }    
            */
        }


        // specify the coordinates of the Beacon, in cms
        public static Vector2 BeaconA = new Vector2(0, 0);              // left hand bottom corner
        public static Vector2 BeaconB = new Vector2(0, 600);            // left hand top corner
        public static Vector2 BeaconC = new Vector2(600, 600);          // right hand top corner
        public static Vector2 BeaconD = new Vector2(0, 600);            // rigt hand bottom corner

        private void Option_1_HandleUSGPSReply(List<byte> newData)
        {
            
            if (newData.Count != 12)                                     // check we have received 8 bytes
            {
                return;
                //throw new ArgumentOutOfRangeException("newData");  // throw an error if we do not have 8 bytes
            }

            //double distanceFromA = BitConverter.ToInt16(newData.ToArray(), 0);    // reconstruct the 16 bit distance from Beacon A
            //double distanceFromB = BitConverter.ToInt16(newData.ToArray(), 2);    // reconstruct the 16 bit distance from Beacon B
            //double distanceFromC = BitConverter.ToInt16(newData.ToArray(), 4);    // reconstruct the 16 bit distance from Beacon C
            //double distanceFromD = BitConverter.ToInt16(newData.ToArray(), 6);    // reconstruct the 16 bit distance from Beacon D

            
            double timeFromA = (short)(newData[4] << 8) + newData[5];                  // reconstruct the 16 bit distance from Beacon A
            double timeFromB = (short)(newData[6] << 8) + newData[7];                  // reconstruct the 16 bit distance from Beacon B
            double timeFromC = (short)(newData[8] << 8) + newData[9];                  // reconstruct the 16 bit distance from Beacon C
            double timeFromD = (short)(newData[10] << 8) + newData[11];                  // reconstruct the 16 bit distance from Beacon D

            double distanceFromA = (timeFromA - 40.5) / 4.60;
            double distanceFromB = (timeFromB - 40.5) / 4.60;
            double distanceFromC = (timeFromC - 40.5) / 4.60;
            double distanceFromD = (timeFromD - 40.5) / 4.60;
            
            double[] flatdistance = new double[4];                              //0 = A, 1 = B, 2 = C, 3 = D
            flatdistance[0] = Math.Sqrt((distanceFromA * distanceFromA) - 4)-60;   //hypotenuse - an edge
            flatdistance[1] = Math.Sqrt((distanceFromB * distanceFromB) - 4)-60;
            flatdistance[2] = Math.Sqrt((distanceFromC * distanceFromC) - 4)-60;
            flatdistance[3] = Math.Sqrt((distanceFromD * distanceFromD) - 4)-60;


            for (int L = 0; L < 4; L++)
            {
                for (int R = 0; R < 4; R++)
                {
                    if (R != L)
                    {
                        FindCircleIntersections(towerX[L], towerY[L], flatdistance[L], towerX[R], towerY[R], flatdistance[R]);  // Finds Circle crosses for all combinations. Populates two arrays
                    }
                }
            }

            /*
            FindCircleIntersections(towerX[0], towerY[0], flatdistance[0], towerX[1], towerY[1], flatdistance[1]);
            FindCircleIntersections(towerX[0], towerY[0], flatdistance[0], towerX[2], towerY[2], flatdistance[2]);
            FindCircleIntersections(towerX[0], towerY[0], flatdistance[0], towerX[3], towerY[3], flatdistance[3]);
            FindCircleIntersections(towerX[1], towerY[1], flatdistance[1], towerX[2], towerY[2], flatdistance[2]);
            FindCircleIntersections(towerX[1], towerY[1], flatdistance[1], towerX[3], towerY[3], flatdistance[3]);
            FindCircleIntersections(towerX[2], towerY[2], flatdistance[2], towerX[3], towerY[3], flatdistance[3]);
            */
            List<int> popularity = new List<int>();
            for (int i = 0; i < CoordsX.Count; i++)                                        //Goes through array of x coordinates and finds most popular +-2
            {
                popularity.Add(0);
                for (int L = 0; L < CoordsX.Count; L++)
                {
                    if (CoordsX[i] < CoordsX[L] + 2 && CoordsX[i] > CoordsX[L] - 2)
                    {
                        popularity[i]++;
                    }
                }
            }
            int maxcpopularity = 0;
            for (int i = 0; i < CoordsX.Count; i++)                                 //Sets cooridnates to most popular
            {                                                                       // y and x match up because arrays are ordered
                if (maxcpopularity < popularity[i])
                {
                    maxcpopularity = popularity[i];
                    x_coord = (int)CoordsX[i];
                }
            }
            CoordsX.Clear();
            popularity.Clear();
            for (int i = 0; i < CoordsY.Count; i++)                                        //Goes through array of x coordinates and finds most popular +-2
            {
                popularity.Add(0);
                for (int L = 0; L < CoordsY.Count; L++)
                {
                    if (CoordsY[i] < CoordsY[L] + 2 && CoordsY[i] > CoordsY[L] - 2)
                    {
                        popularity[i]++;
                    }
                }
            }
            maxcpopularity = 0;
            for (int i = 0; i < CoordsY.Count; i++)                                 //Sets cooridnates to most popular
            {                                                                       // y and x match up because arrays are ordered
                if (maxcpopularity < popularity[i])
                {
                    maxcpopularity = popularity[i];
                    y_coord = (int)CoordsY[i];
                }
            }
            CoordsY.Clear();
            popularity.Clear();


            // var beaconA = new Vector2Distance(BeaconA.X, BeaconA.Y, distanceFromA); // convert the distances into vectors
            // var beaconB = new Vector2Distance(BeaconB.X, BeaconB.Y, distanceFromB);
            // var beaconC = new Vector2Distance(BeaconC.X, BeaconC.Y, distanceFromC);
            // var beaconD = new Vector2Distance(BeaconD.X, BeaconD.Y, distanceFromD);

            // Vector2 location = Interpolator.Trilaterate(new List<Vector2Distance> { beaconA, beaconB, beaconC, beaconD });    // do the calculation
            this.BeginInvoke(new EventHandler(delegate
            {
                lblselsa.Text = flatdistance[0].ToString();
                lblselsb.Text = flatdistance[1].ToString();
                lblselsc.Text = flatdistance[2].ToString();
                lblselsd.Text = flatdistance[3].ToString();
                lblcoordX.Text = x_coord.ToString();
                lblcoordY.Text = y_coord.ToString();
                picRover.Location = new Point((x_coord - 5), (295 - y_coord));
            }));
            //if (location != null)
            //{
            // Do something with the location!
            // eg. Console.WriteLine($"X: {location.X} Y: {location.Y}");
            /*
                if (location.X > 848)                   // based on 600 x 600 grid.
                {
                    //Out of bounds!
                }    
            */
            //}
        }
        void FindCircleIntersections(
                float cx0, float cy0, double radius0,
                float cx1, float cy1, double radius1
                )
        {
            // Find the distance between the centers.
            float dx = cx0 - cx1;
            float dy = cy0 - cy1;
            double dist = Math.Sqrt(dx * dx + dy * dy);

            // See how many solutions there are.
            if (dist > radius0 + radius1)
            {
                return;
            }
            else if (dist < Math.Abs(radius0 - radius1))
            { 
                return;
            }
            else if ((dist == 0) && (radius0 == radius1))
            {
                return;
            }
            else
            {
                // Find a and h.
                double a = (radius0 * radius0 -
                    radius1 * radius1 + dist * dist) / (2 * dist);
                double h = Math.Sqrt(radius0 * radius0 - a * a);

                // Find P2.
                double cx2 = cx0 + a * (cx1 - cx0) / dist;
                double cy2 = cy0 + a * (cy1 - cy0) / dist;

                // Get the points P3.
                float x1 = (float)(cx2 + h * (cy1 - cy0) / dist);
                float y1 = (float)(cy2 - h * (cx1 - cx0) / dist);
                float x2 = (float)(cx2 - h * (cy1 - cy0) / dist);
                float y2 = (float)(cy2 + h * (cx1 - cx0) / dist);
                if (x1 < 300 && x1 > 0)
                {
                    CoordsX.Add((float)(cx2 + h * (cy1 - cy0) / dist));
                }
                if(y1 < 300 && y1 > 0)
                {
                    CoordsY.Add((float)(cy2 - h * (cx1 - cx0) / dist));
                }
                if(x2 < 300 && x2 > 0)
                {
                    CoordsX.Add((float)(cx2 - h * (cy1 - cy0) / dist));
                }
                if(y2 < 300 && y2 > 0)
                {
                    CoordsY.Add((float)(cy2 + h * (cx1 - cx0) / dist));
                }
                
                return;
            }
        }
        void setmotorspeed(int speed1, int speed2)
        {

            theClient.SendData(CommandID.CMDSETBOTHMOTORS, new byte[] { (byte)speed1, (byte)speed2 });
            return;
        }
        void stopmotors()
        {
            theClient.SendData(CommandID.CMDSETBOTHMOTORS, new byte[] { (byte)0, (byte)0 });
            if (flag_travelling != 0)
            {
                tmrmotorpos.Enabled = false;
                flag_travelling = 0;
            }

        }
        void godistance(int distance)
        {
            if (distance == 0) return;
            int noofticks = (int)(distance / 0.113);
            theClient.SendData(CommandID.CMDMOTORSTATUS, new byte[] { });
            flag_wantedmotorpos = motor_position + noofticks;
            if (distance > 0)
            {
                flag_travelling = 1;
                setmotorspeed(scrlspeed.Value, scrlspeed.Value);
                tmrmotorpos.Enabled = true;
            }
            else
            {
                flag_travelling = 2;
                setmotorspeed(-1 * scrlspeed.Value, -1 * scrlspeed.Value);
                tmrmotorpos.Enabled = true;
            }
        }
        void turn(int turnangle)
        {
            theClient.SendData(CommandID.CMDREADMag, new byte[] { });
            System.Threading.Thread.Sleep(50);
            int absturnangle = Math.Abs(turnangle);
            if (turnangle > 0)
            {
                if ((flag_heading + absturnangle) < 360)
                {
                    flag_wantedheading = flag_heading + absturnangle;
                } else flag_wantedheading = (absturnangle - (360 - flag_heading));
                flag_rotating = true;
                setmotorspeed(70, -70);
                this.BeginInvoke(new EventHandler(delegate
                {
                    lblwantedangle.Text = flag_wantedheading.ToString();
                }));
                tmrangle.Enabled = true;
            }
            if (turnangle < 0)
            {
                if ((flag_heading - absturnangle) > 0)
                {
                    flag_wantedheading = flag_heading - absturnangle;
                }
                else flag_wantedheading = (360 - (absturnangle - flag_heading));
                flag_rotating = true;
                setmotorspeed(-70, +70);
                this.BeginInvoke(new EventHandler(delegate
                {
                    lblwantedangle.Text = flag_wantedheading.ToString();
                }));
                tmrangle.Enabled = true;
            }
        }
        void turntoangle(double wantangle)
        {
            theClient.SendData(CommandID.CMDREADMag, new byte[] { });
            System.Threading.Thread.Sleep(50);
            double angle1 = flag_heading - wantangle;
            double angle2 = wantangle - flag_heading;
            if (Math.Abs(angle1) < Math.Abs(angle2))
            {
                turn((int)angle1);
            }
            else
            {
                turn((int)angle2);
            }
        }
        #region FORM CONTROL EVENT FUNCTIONS
        /// <summary>
        /// Connection function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdConnect_Click(object sender, EventArgs e)
        {
            //assuming the client isn't already connected
            //if the client isn't connected an error will be thrown as no socket will be available
            if (!theClient.isConnected)
            {
                //then connect it using the parameters in the textbox
                theClient.ConnectToServer(txtIPAddress.Text, Convert.ToInt32(txtPort.Text));

                cmdConnect.Enabled = false;
                cmdDisconnect.Enabled = true;
            }
        }


        /// <summary>
        /// Disconnection function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            if (theClient.isConnected)
                theClient.Disconnect();

            cmdConnect.Enabled = true;
            cmdDisconnect.Enabled = false;

            txtIPAddress.Enabled = true;
        }

        /// <summary>
        /// Function that is called when the Set LED button is pressed
        /// this sends the corresponding command ID to the rover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSetLEDs_Click(object sender, EventArgs e)
        {
            byte LEDs = 0;

            //If statement to check if the client is connected to a rover
            if (theClient.isConnected)
            {
                if (chkGreen.Checked) { LEDs |= 0x01; }
                if (chkRed.Checked) { LEDs |= 0x02; }

                theClient.SendData(CommandID.CMDSETLED, new byte[] { LEDs });
            }
        }

        /// <summary>
        /// Function that is called when the Internal counter button is pressed
        /// this sends the corresponding command ID to the rover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdGetCount_Click(object sender, EventArgs e)
        {
            //If statement to check if the client is connected to a rover
            if (theClient.isConnected)
            {
                theClient.SendData(CommandID.CMDGETCOUNT, new byte[] { });
            }
        }

        /// <summary>
        /// Function that is called when the LEDSwitch status packet button is pressed
        /// this sends the corresponding command ID to the rover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSwitchLedStatus_Click(object sender, EventArgs e)
        {
            //If statement to check if the client is connected to a rover
            if (theClient.isConnected)
            {
                theClient.SendData(CommandID.CMDGETSW, new byte[] { });
            }
        }
        #endregion

        private void btnsetspeed_Click(object sender, EventArgs e)
        {

            setmotorspeed(scrlspeed.Value, scrlspeed.Value);
        }

        private void btngetmotorpos_Click(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDMOTORSTATUS, new byte[] { });
        }

        private void txtspeed2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnstopmotors_Click(object sender, EventArgs e)
        {
            stopmotors();
            tmrangle.Enabled = false;
            flag_rotating = false;
        }

        private void btngodistance_Click(object sender, EventArgs e)
        {
            int distance = int.Parse(txtgodistance.Text);
            godistance(distance);

        }

        private void chkpingmotor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void scrlspeed_Scroll(object sender, ScrollEventArgs e)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                lblmotorspeed.Text = scrlspeed.Value.ToString();
            }));
        }

        private void tmrmotorpos_Tick(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDMOTORSTATUS, new byte[] { });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setmotorspeed(-scrlspeed.Value, -scrlspeed.Value);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void MagCalStart_Click(object sender, EventArgs e)
        {
            flag_magzero = 1;
            tmrangle.Enabled = true;
        }

        private void MagCalStop_Click(object sender, EventArgs e)
        {
            flag_magzero = 0;
            tmrangle.Enabled = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (theClient.isConnected) theClient.Disconnect();
        }

        private void checkMag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tmrMag_Tick(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDREADMag, new byte[] { });
        }

        private void btnsetnorth_Click(object sender, EventArgs e)
        {
            flag_setnorth = true;
            theClient.SendData(CommandID.CMDREADMag, new byte[] { });
        }

        private void btnturn_Click(object sender, EventArgs e)
        {
            int turnangle = int.Parse(txtturnangle.Text);
            turn(turnangle);
        }

        private void bntstartvortex_Click(object sender, EventArgs e)
        {
            flag_vortexsample = true;
            tmrangle.Enabled = true;
            chrtTmr.Enabled = true;
            startAngle = timermaga;
            

        }

        private void btnstopvortex_Click(object sender, EventArgs e)
        {
            flag_vortexsample = false;
            tmrangle.Enabled = false;
            chrtTmr.Enabled = false;
        }

        private void btnearthquakestart_Click(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDQUAKE, new byte[] { 1 });
            flag_sampleearthquake = true;
            tmrearthquake.Enabled = true;
        }

        private void btnearthquakestop_Click(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDQUAKE, new byte[] { 0 });
            flag_sampleearthquake = false;
            tmrearthquake.Enabled = false;
        }

        private void btndumptofile_Click(object sender, EventArgs e)
        {
            int stream = edata.Count - 1;
            //Random rnd = new Random();
            System.IO.StreamWriter file = new System.IO.StreamWriter("data.txt");
            while (stream > 0)
            {
                file.WriteLine(edata[stream].ToString());
                //file.WriteLine(rnd.Next(16000, 17000));
                stream--;
            }
            //edata.Clear();
            file.Close();
        }

        private void btngetheading_Click(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDREADMag, new byte[] { });
        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            setmotorspeed(-100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turntoangle(flag_northheading);
        }

        private void lightPathBtn_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                scrlspeed.Value = 80;
            }));

            lightTimer.Enabled = true;
            lightTimer.Interval = 100;

        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDRDlightsensors, new byte[] { });
            Color myColour1 = Color.FromArgb(LightReading1, LightReading1, LightReading1);
            Color myColour2 = Color.FromArgb(LightReading2, LightReading2, LightReading2);
            Graphics g = lightPnl.CreateGraphics();
            Pen myPen1 = new Pen(myColour1, 10);
            Pen myPen2 = new Pen(myColour2, 10);
            this.BeginInvoke(new EventHandler(delegate
            {
                lightdTxt.Text = LightReading1.ToString();
                lighttxt2.Text = LightReading2.ToString();
            }));


            if (li < 1)
            {

                godistance(110);

                ly1 = 420;
                ly3 = 420;
                ly2 = 410;
                ly4 = 410;
                lx1 += 20;
                lx2 += 20;
                lx3 += 20;
                lx4 += 20;
            }
            else if (li < 39)
            {
                //read light sensors
                // lightar1[lightarc]=LightReading1;
                //lightar2[lightarc]=LightReading2;
                g.DrawLine(myPen1, lx1, ly1, lx2, ly2);
                g.DrawLine(myPen2, lx3, ly3, lx4, ly4);
                ly1 -= 10;
                ly2 -= 10;
                ly3 -= 10;
                ly4 -= 10;

            }
            else if (li < 57)
            {
                //do nothing
            }
            else if (li < 60)
            {
                setmotorspeed(-84, 84);
            }
            else if (li < 61)
            {
                setmotorspeed(0, 0);
            }
            else if (li < 65)
            {
                setmotorspeed(-80, -80);
            }
            else if (li < 66)
            {
                setmotorspeed(0, 0);
            }
            else if (li < 69)
            {
                setmotorspeed(70, -70);
            }
            else if (li < 70)
            {
                setmotorspeed(0, 0);
                ly1 += 10;
                ly2 += 10;
                ly3 += 10;
                ly4 += 10;


            }
            else if (li < 71)
            {
                godistance(-110);
                lx1 += 20;
                lx2 += 20;
                lx3 += 20;
                lx4 += 20;
            }
            else if (li < 109)
            {
                //lightar1[lightarc]=LightReading1;
                // lightar2[lightarc]=LightReading2;
                g.DrawLine(myPen1, lx1, ly1, lx2, ly2);
                g.DrawLine(myPen2, lx3, ly3, lx4, ly4);
                ly1 += 10;
                ly2 += 10;
                ly3 += 10;
                ly4 += 10;
            }
            else if (li < 126)
            {
                //do nothing
            }
            else if (li < 127)
            {
                setmotorspeed(0, 0);
            }
            else if (li < 130)
            {
                setmotorspeed(100, -100);
            }
            else if (li < 131)
            {
                setmotorspeed(0, 0);
            }
            else if (li < 135)
            {
                setmotorspeed(80, 80);
            }
            else if (li < 136)
            {
                setmotorspeed(0, 0);
            }
            else if (li < 139)
            {
                setmotorspeed(-70, 70);
            }
            else if (li < 140)
            {
                setmotorspeed(0, 0);
            }
            else {
                li = -1;
            }
            li += 1;
            lightarc += 1;






        }
        void turnRightLeft(int turnangle, Boolean right) {

            theClient.SendData(CommandID.CMDREADMag, new byte[] { });

            int absturnangle = Math.Abs(turnangle);
            if (turnangle > 0)
            {
                if ((flag_heading + absturnangle) < 360)
                {
                    flag_wantedheading = flag_heading + absturnangle;
                }
                else flag_wantedheading = (absturnangle - (360 - flag_heading));
                flag_rotating = true;
                setmotorspeed(70, -70);
                this.BeginInvoke(new EventHandler(delegate
                {
                    lblwantedangle.Text = flag_wantedheading.ToString();
                }));
                tmrangle.Enabled = true;
            }
            if (turnangle < 0)
            {
                if ((flag_heading - absturnangle) > 0)
                {
                    flag_wantedheading = flag_heading - absturnangle;
                }
                else flag_wantedheading = (360 - (absturnangle - flag_heading));
                flag_rotating = true;
                if (right == true)
                {
                    setmotorspeed(+70, 0);
                }
                else
                {
                    setmotorspeed(0, 70);
                }
                this.BeginInvoke(new EventHandler(delegate
                {
                    lblwantedangle.Text = flag_wantedheading.ToString();
                }));
                tmrangle.Enabled = true;
            }


        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LightDrawBtn_Click(object sender, EventArgs e)
        {
            int[] light = { 0, 10, 20, 30, 40, 50, 40, 30, 20, 10, 0, 50, 30, 20, 10, 30, 25, 55, 66, 12, 31, 41, 30, 20, 10, 30, 25, 55, 66, 12, 31, 41, 24, 12, 42, 51, 23, 12, 0, 10, 20, 30, 40, 50, 40, 30, 20, 10, 0, 50, 30, 20, 10, 30, 25, 55, 66, 12, 31, 41, 24, 12, 42, 51, 23, 12, };
            lightDraw(light);
        }

        void lightDraw(int[] lightRead) {
            int pix = 0, piy = 0, x = 0;
            for (int i = 0; i < lightRead.Length; i++) {
                //draw depending on path and light sensor readings
                Graphics g = lightPnl.CreateGraphics();

                Pen p = new Pen(Color.FromArgb(255, lightRead[i], lightRead[i] * 3, lightRead[i] * 2), 45);
                if (i * 10 <= 350) {
                    g.DrawLine(p, piy, pix, i * 10, x);
                } else {


                    g.DrawLine(p, piy, pix, (i - 35) * 10, x + 10);
                }
                pix = x * 10;
                piy = i * 10;

            }
        }

        private void tmrearthquake_Tick(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDQUAKEGET, new byte[] { });
            etimercycles++;
        }

        private void btnclearsamples_Click(object sender, EventArgs e)
        {
            edata.Clear();
        }

        private void btngetsels_Click(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDGETUSGPS, new byte[] {});
        }

        private void lblselsd_Click(object sender, EventArgs e)
        {

        }

        private void btnorienteast_Click(object sender, EventArgs e)
        {
            turntoangle(flag_northheading + 90);
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void btnorientsouth_Click(object sender, EventArgs e)
        {
            turntoangle(flag_northheading + 180);
        }

        private void btnorientwest_Click(object sender, EventArgs e)
        {
            turntoangle(flag_northheading - 90);
           
        }

        private void btntestcircle_Click(object sender, EventArgs e)
        {
            double[] flatdistance = new double[4];                              //0 = A, 1 = B, 2 = C, 3 = D
            flatdistance[0] = Convert.ToDouble(txttestselsa.Text); //* Math.Sqrt((distanceFromA * distanceFromA) - 4);   //hypotenuse - an edge
            flatdistance[1] = Convert.ToDouble(txttestselsb.Text);//* Math.Sqrt((distanceFromB * distanceFromB) - 4);
            flatdistance[2] = Convert.ToDouble(txttestselsc.Text);//* Math.Sqrt((distanceFromC * distanceFromC) - 4);
            flatdistance[3] = Convert.ToDouble(txttestselsd.Text);//* Math.Sqrt((distanceFromD * distanceFromD) - 4);

            for (int L = 0; L < 4; L++)
            {
                for (int R = 0; R < 4; R++)
                {
                    if (R != L)
                    {
                        FindCircleIntersections(towerX[L], towerY[L], flatdistance[L], towerX[R], towerY[R], flatdistance[R]);  // Finds Circle crosses for all combinations. Populates two arrays
                    }
                }
            }
            
            /*
            FindCircleIntersections(towerX[0], towerY[0], flatdistance[0], towerX[1], towerY[1], flatdistance[1]);
            FindCircleIntersections(towerX[0], towerY[0], flatdistance[0], towerX[2], towerY[2], flatdistance[2]);
            FindCircleIntersections(towerX[0], towerY[0], flatdistance[0], towerX[3], towerY[3], flatdistance[3]);
            FindCircleIntersections(towerX[1], towerY[1], flatdistance[1], towerX[2], towerY[2], flatdistance[2]);
            FindCircleIntersections(towerX[1], towerY[1], flatdistance[1], towerX[3], towerY[3], flatdistance[3]);
            FindCircleIntersections(towerX[2], towerY[2], flatdistance[2], towerX[3], towerY[3], flatdistance[3]);
            */
            List<int> popularity = new List<int>();
            for (int i = 0; i < CoordsX.Count; i++)                                        //Goes through array of x coordinates and finds most popular +-2
            {
                popularity.Add(0);
                for (int L = 0; L < CoordsX.Count; L++)
                {
                    if (CoordsX[i] < CoordsX[L] + 2 && CoordsX[i] > CoordsX[L] - 2)
                    {
                        popularity[i]++;
                    }
                }
            }
            int maxcpopularity = 0;
            for (int i = 0; i < CoordsX.Count; i++)                                 //Sets cooridnates to most popular
            {                                                                       // y and x match up because arrays are ordered
                if (maxcpopularity < popularity[i])
                {
                    maxcpopularity = popularity[i];
                    x_coord = (int)CoordsX[i];
                }
            }
            CoordsX.Clear();
            popularity.Clear();
            for (int i = 0; i < CoordsY.Count; i++)                                        //Goes through array of x coordinates and finds most popular +-2
            {
                popularity.Add(0);
                for (int L = 0; L < CoordsY.Count; L++)
                {
                    if (CoordsY[i] < CoordsY[L] + 2 && CoordsY[i] > CoordsY[L] - 2)
                    {
                        popularity[i]++;
                    }
                }
            }
            maxcpopularity = 0;
            for (int i = 0; i < CoordsY.Count; i++)                                 //Sets cooridnates to most popular
            {                                                                       // y and x match up because arrays are ordered
                if (maxcpopularity < popularity[i])
                {
                    maxcpopularity = popularity[i];
                    y_coord = (int)CoordsY[i];
                }
            }
            CoordsY.Clear();
            popularity.Clear();


            // var beaconA = new Vector2Distance(BeaconA.X, BeaconA.Y, distanceFromA); // convert the distances into vectors
            // var beaconB = new Vector2Distance(BeaconB.X, BeaconB.Y, distanceFromB);
            // var beaconC = new Vector2Distance(BeaconC.X, BeaconC.Y, distanceFromC);
            // var beaconD = new Vector2Distance(BeaconD.X, BeaconD.Y, distanceFromD);

            // Vector2 location = Interpolator.Trilaterate(new List<Vector2Distance> { beaconA, beaconB, beaconC, beaconD });    // do the calculation
            this.BeginInvoke(new EventHandler(delegate
            {
                lblselsa.Text = flatdistance[0].ToString();
                lblselsb.Text = flatdistance[1].ToString();
                lblselsc.Text = flatdistance[2].ToString();
                lblselsd.Text = flatdistance[3].ToString();
                lblcoordX.Text = x_coord.ToString();
                lblcoordY.Text = y_coord.ToString();
                picRover.Location = new Point((x_coord - 5), (295 - y_coord));
            }));
        }

        private void chrtTmr_Tick(object sender, EventArgs e)
        {
            
            chart1.Series[0].Points.AddXY(timerAngle, timermaga);
            timerAngle += 1;
            double angleTbound = startAngle + 20;
            double angleLbound = startAngle - 20;
          
            if ((timermaga < 150)&&(prevAngle>200)) {
                noOfSpins += 1;
                this.BeginInvoke(new EventHandler(delegate
                {
                    spinslbl.Text = noOfSpins.ToString();
                }));
            }
            prevAngle = timermaga;
        }

        private void chrtReset_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            timerAngle = 0; ;
        }

        private void btnstoreinclneangle_Click(object sender, EventArgs e)
        {
            angleB = Math.Abs(flag_pitch);
            this.BeginInvoke(new EventHandler(delegate
            {
                txtinclineangle.Text = angleB.ToString();
            }));
        }

        private void btnstoredeclineangle_Click(object sender, EventArgs e)
        {
            angleD = Math.Abs(flag_pitch);
            this.BeginInvoke(new EventHandler(delegate
            {
                txtdeclineangle.Text = angleD.ToString();
            }));
        }

        private void btncalcteeter_Click(object sender, EventArgs e)
        {
            double f1, f2, h, h1, h2;
            double angleM,angleMrad, angleBrad, angleDrad;
            angleBrad = angleB * (Math.PI / 180);
            angleDrad = angleD * (Math.PI / 180);
            f1 = lengthL * Math.Cos(angleBrad);
            f2 = lengthL * Math.Cos(angleDrad);
            lengthF = (f1 + f2) / 2;
            angleM = (180 - (angleB + angleD));
            angleMrad = angleM * (Math.PI / 180);
            lengthA = ((lengthF / Math.Sin(angleMrad)) * Math.Sin(angleDrad));
            lengthC = ((lengthF / Math.Sin(angleMrad)) * Math.Sin(angleBrad));
            h1 = lengthA * Math.Sin(angleBrad);
            h2 = lengthC * Math.Sin(angleDrad);
            h = (h1 + h2) / 2;
            this.BeginInvoke(new EventHandler(delegate
            {
                lbllengthAval.Text = lengthA.ToString();
                lbllengthCval.Text = lengthC.ToString();
                lbllengthFval.Text = lengthF.ToString();
                lbllengthHval.Text = h.ToString();
                lblangleMval.Text = angleM.ToString();
            }));

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            turntoangle(flag_northheading);
        }

        private void btntravelgo_Click(object sender, EventArgs e)
        {
            godistance(Convert.ToInt32(txttraveldistance.Text));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                txtxwanted.Text = "60";
                txtywanted.Text = "130";
            }));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                txtxwanted.Text = "60";
                txtywanted.Text = "60";
            }));
        }

        private void picimage_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                txtxwanted.Text = "105";
                txtywanted.Text = "148";
            }));
        }

        private void picmorseaproach_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                txtxwanted.Text = "215";
                txtywanted.Text = "275";
            }));
        }

        private void teeterTmr_Tick(object sender, EventArgs e)
        {
            
            if (flag_pitch < 10)
            {

                setmotorspeed(90, 90);
            }
           else if (pastPitch-flag_pitch > 10)
            {
                setmotorspeed(0,0);

            }
            
            pastPitch = flag_pitch;
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            teeterTmr.Enabled = true;

        }

        private void picvortex_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                txtxwanted.Text = "222";
                txtywanted.Text = "200";
            }));
        }

        private void picearthquake_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                txtxwanted.Text = "188";
                txtywanted.Text = "106";
            }));
        }

        private void btnturntravel_Click(object sender, EventArgs e)
        {
            turntoangle(Convert.ToInt32(txttravelangle.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            theClient.SendData(CommandID.CMDGETUSGPS, new byte[] { });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            godistance(100); //tweak to correct value
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //turntoangle(Angle);
        }

        private void btnexitearthquake_Click(object sender, EventArgs e)
        {
            godistance(-100);
        }

        private void tmraccelerometer_Tick(object sender, EventArgs e)
        {
            if (chkaccel.Checked == true)
            {
                theClient.SendData(CommandID.CMDREADMMA8452, new byte[] { });
            }
            if(flag_travelling == 1 || flag_travelling ==2)
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    chktravelling.Checked = true;
                }));
            }else
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    chktravelling.Checked = false;
                }));
            }
            if (flag_rotating == true)
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    chkturning.Checked = true;
                }));
            }
            else
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    chkturning.Checked = false;
                }));
            }

        }

        private void btnorientexitvortex_Click(object sender, EventArgs e)
        {
            turntoangle(167);
        }

        private void btnexitvortex_Click(object sender, EventArgs e)
        {
            godistance(125);
        }

        private void btnorientvortexon_Click(object sender, EventArgs e)
        {
            turntoangle(344);
        }

        private void btnentervortex_Click(object sender, EventArgs e)
        {
            godistance(125);
        }

        private void btncalculatepath_Click(object sender, EventArgs e)
        {
            int wantedangle2;
            int xdist = (Int32.Parse(txtxwanted.Text) - x_coord);
            int ydist = (Int32.Parse(txtywanted.Text) - y_coord);
            double calcbearing;
            int wanteddistance;
            theClient.SendData(CommandID.CMDREADMag, new byte[] { });
            System.Threading.Thread.Sleep(50);
            calcbearing = (Math.Atan2(ydist,xdist) / (Math.PI / 180));
            wantedangle2 = (int)(flag_northheading+(90-calcbearing));
            if (wantedangle2 >=360)
            {
                wantedangle2 = wantedangle2 - 360;
            }
            wanteddistance = (int)Math.Sqrt((Math.Pow(xdist,2)) + Math.Pow(ydist,2));
            this.BeginInvoke(new EventHandler(delegate
            {
                txttraveldistance.Text = wanteddistance.ToString();
                txttravelangle.Text = wantedangle2.ToString();
            }));
        }

        private void stopPth_Click(object sender, EventArgs e)
        {
            lightTimer.Enabled=false;
            setmotorspeed(0, 0);
        }
    }
}

