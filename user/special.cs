using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EVCS
{
    struct configtimexml
    {
        public string time;
        public string beginhour;
        public string beginminute;
        public string endminute;
        public string endhour;
    }

   public struct volumecontrol
    {
        public int carNo;
        public string carName;
        public decimal? carVolume;
        public string carSN;
        decimal? volume;
        public decimal? Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public string count;
        public int Loadingrate;
         string Endtime;
        public string Begintime;
        public string EndTime{ get { Endtime= DateTime.Now.ToString(); return Endtime; } }
            
    }

    public struct NetIP
    {
        public bool ipflag,pointflag;
        string IP;
        public string ip
        {
            get { return IP;}
            set { if (ipflag == true) IP = value; ipflag = false; }
        }
        int point;
        public int Point
        {
            get { return point; }
            set { if (pointflag == true) point = value; pointflag = false; }
        }
    }

    public class Special
    {
        class Net
        {
            NetIP NetIp;
            Net(NetIP a)
            {
                NetIp.ipflag = true;
                NetIp.ip = a.ip;
                NetIp.pointflag = true;
                NetIp.Point = a.Point;
            }
            Dictionary<string, Socket> dic = new Dictionary<string, Socket>();

            bool serverLink()
            {
                IPAddress ip = IPAddress.Parse(NetIp.ip);
                IPEndPoint point = new IPEndPoint(ip, NetIp.Point);
                //创建监听用的Socket
                /*
                 * AddressFamily.InterNetWork：使用 IP4地址。
                   SocketType.Stream：支持可靠、双向、基于连接的字节流，而不重复数据。
                   此类型的 Socket 与单个对方主机进行通信，并且在通信开始之前需要远程主机连接。
                   Stream 使用传输控制协议 (Tcp) ProtocolType 和 InterNetworkAddressFamily。
                   ProtocolType.Tcp：使用传输控制协议。
                 */
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socket.Bind(point);
                    socket.Listen(10);
                    NewMain.Nform.logClass.write("服务器开始监听");
                    Thread thread = new Thread(AcceptInfo);
                    thread.IsBackground = true;
                    thread.Start(socket);
                }
                catch (Exception ex)
                {
                    NewMain.Nform.logClass.write(ex.Message);
                }
                return true;
            }
            void AcceptInfo(object o)
            {
                Socket socket = o as Socket;
                while (true)
                {
                    try
                    {
                        Socket tSocket = socket.Accept();
                        string point = tSocket.RemoteEndPoint.ToString();
                        //ShowMsg(point + "连接成功！");
                        //cboIpPort.Items.Add(point);
                        //cboIpPort.Text = point;
                        dic.Add(point, tSocket);
                        Thread th = new Thread(ReceiveMsg);
                        th.IsBackground = true;
                        th.Start(tSocket);
                    }
                    catch (Exception ex)
                    {
                        NewMain.Nform.logClass.write(ex.Message);
                        break;
                    }
                }
            }
            void ReceiveMsg(object o)
            {
                Socket client = o as Socket;
                while (true)
                {
                    try
                    {
                        byte[] buffer = new byte[1024 * 1024];
                        int n = client.Receive(buffer);

                        volumecontrol t = new volumecontrol();
                        int size = Marshal.SizeOf(typeof(volumecontrol));
                        IntPtr testi = Marshal.AllocHGlobal(n);
                        Marshal.Copy(buffer, 0, testi, size);


                        t = (volumecontrol)Marshal.PtrToStructure(testi, typeof(volumecontrol));

                        buffer = new byte[1024 * 1024];
                        n = client.Receive(buffer);
                        t.carName = Encoding.UTF8.GetString(buffer, 0, n);

                        buffer = new byte[1024 * 1024];
                        n = client.Receive(buffer);
                        t.carSN= Encoding.UTF8.GetString(buffer, 0, n);
                        //ShowMsg(client.RemoteEndPoint.ToString() + ":" + words);
                    }
                    catch (Exception ex)
                    {
                        NewMain.Nform.logClass.write(ex.Message);
                        break;
                    }
                }
            }
            bool sendmessage(string message)
            {
                try
                {
                    string ip = NetIp.ip;
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    dic[ip].Send(buffer);
                    NewMain.Nform.logClass.write(message);
                }
                catch (Exception ex)
                {
                    NewMain.Nform.logClass.write(ex.Message);
                }
                return true;
            }


        }


        
        Calc calc;
        public Calc Calc
        {
            get { return calc; }
        }
        public bool getcalc(Calc c)
        {
            calc = c;
            return true;
        }

        decimal flagvolume = 0;
        public decimal? Volume
        {
            get { return volumeCalc.Volume; }
        }
        public bool receivevolume(string path = "0")
        {
            if (path == "0") { volumeCalc.Volume = 0; flagvolume = 0; }
            else volumeCalc.Volume = Convert.ToDecimal(File.ReadAllText(path)) - flagvolume;
            return true;
        }
        public bool changevolume(decimal change)
        {
            flagvolume=change;
            return true;
        }

         string EVCSversion;
         string Volumeversion;
         public string EVCSv
        {
            get { return EVCSversion; }
            set { EVCSversion = value; }
        }
        public string Volumev
        {
            get { return Volumeversion; }
            set { Volumeversion = value; }
        }


        configtimexml[] configtime = new configtimexml[3];
        public volumecontrol volumeCalc;
        NetIP getip;

        public Special()
        {
            loadxml();
        }


       
        public void showxml()
        {
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(configtime[i].time + configtime[i].beginhour + configtime[i].beginminute);
                MessageBox.Show(configtime[i].endhour + configtime[i].endminute);
            }
        }

        public int gethour(int a,bool flag)
        {
            if (flag) return Convert.ToInt32( configtime[a].beginhour);
            else return Convert.ToInt32(configtime[a].endhour);
        }
        public string gethour(int a,bool flag,bool isstring)
        {
            if (flag) return configtime[a].beginhour;
            else return configtime[a].endhour;
        }
        public int getminute(int a, bool flag)
        {
            if (flag) return Convert.ToInt32(configtime[a].beginminute);
            else return Convert.ToInt32(configtime[a].endminute);
        }
        public string getminute(int a, bool flag,bool isstring)
        {
            if (flag) return configtime[a].beginminute;
            else return configtime[a].endminute;
        }
        public bool sethour(int a,bool flag,string t)
        {
            if (flag) configtime[a].beginhour = t;
            else configtime[a].endhour = t;
            return true;
        }
        public bool setminute(int a,bool flag,string t)
        {
            if (flag) configtime[a].beginminute = t;
            else configtime[a].endminute = t;
            return true;
        }


        
        public void loadxml()
        {
            //将XML文件加载进来
            XDocument document = XDocument.Load("config.xml");
            //获取到XML的根元素进行操作
            XElement root = document.Root;

            XElement version = root.Element("EVCSversion");
            EVCSversion = version.Value;
            version = root.Element("Volumeversion");
            Volumeversion = version.Value;

            XElement NetLink = root.Element("NetLink");
            XElement IP = NetLink.Element("IP");
            XElement server = IP.Element("server");
            getip.ipflag = true;
            getip.ip = server.Value;
            XElement Point = IP.Element("serverpoint");
            getip.pointflag = true;
            getip.Point = int.Parse(Point.Value);



            //获取根元素下的所有子元素
            IEnumerable<XElement> ele = root.Elements("time");
            IEnumerable<XElement> enumerable = ele.Elements();
            int i = 0;
            foreach (XElement item in enumerable)
            {
                configtime[i].time = item.Name.ToString();
                XElement timefind = item.Element("beginhour");
                configtime[i].beginhour = timefind.Value;
                timefind = item.Element("beginminute");
                configtime[i].beginminute = timefind.Value;
                timefind = item.Element("endhour");
                configtime[i].endhour = timefind.Value;
                timefind = item.Element("endminute");
                configtime[i].endminute = timefind.Value;
                i++;
            }
        }
        public void writexml()
        {
            //获取根节点对象
            XDocument document = new XDocument();
            XElement root = new XElement("EVCS");
            XElement EVCSv = new XElement("EVCSversion");
            EVCSv.Value = EVCSversion;
            root.Add(EVCSv);
            XElement version = new XElement("Volumeversion");
            version.Value = Volumeversion;
            root.Add(version);

            XElement NetLink = new XElement("NetLink");
            XElement IP = new XElement("IP");
            IP.SetElementValue("server", getip.ip);
            IP.SetElementValue("serverpoint",  getip.Point);
            NetLink.Add(IP);
            root.Add(NetLink);

            XElement time = new XElement("time");

            foreach (configtimexml x in configtime)
            {
                XElement addtime = new XElement(x.time);
                addtime.SetElementValue("beginhour", x.beginhour);
                addtime.SetElementValue("beginminute", x.beginminute);
                addtime.SetElementValue("endhour", x.endhour);
                addtime.SetElementValue("endminute", x.endminute);
                time.Add(addtime);      
            }

            root.Add(time);
            root.Save("config.xml");
        }
    }

    //////////////////////////////////////////////////////
    //添加日志类
    public class LogClass
    {
        //日志路径
        public string logPath;
        //新建文件
        System.IO.StreamWriter streamWriter;
        public void write(string nsg)
        {
            //获得当前工程路径
            logPath = Path.GetDirectoryName(Application.ExecutablePath);
            //创建日志文件夹
            string path = logPath + "/日志文件";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //新建文件
            streamWriter = System.IO.File.AppendText(path + "/" + DateTime.Now.ToLongDateString().ToString() + "日志.txt");
            //写入文件
            streamWriter.WriteLine(DateTime.Now.ToString("HH:mm:ss     ") + nsg);


            streamWriter.Close();
        }

    }
}
