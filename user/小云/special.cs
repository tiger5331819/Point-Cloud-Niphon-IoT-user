using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
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
    [Serializable]
    public struct volumepackage
    {
        public double carVolume;
        public double volume;
        public int loadingrat;
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
    public struct IPList
    {
        public int No;
        public string IP;
    }
    public class Special
    {
        static  IPList[] iplist = new IPList[20];
        static Dictionary<string, Socket> dic = new Dictionary<string, Socket>();
        static int servermessageflag;
        static string servermessage;
       public class Net
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            public bool linkserver()
            {
                IPAddress ip = IPAddress.Parse(getip.ip);
                IPEndPoint point = new IPEndPoint(ip, getip.Point);
                try
                {
                    //连接到服务器
                    client.Connect(point);
                    NewMain.Nform.logClass.write("连接成功");
                    NewMain.Nform.logClass.write("服务器" + client.RemoteEndPoint.ToString());
                    NewMain.Nform.logClass.write("客户端:" + client.LocalEndPoint.ToString());
                    Thread th = new Thread(ReceiveMsg);
                    th.IsBackground = true;
                    th.Start();

                    byte[] buf = Encoding.UTF8.GetBytes("0");
                    client.Send(buf);

                    //先不要了

                    byte[] buf2 = Encoding.UTF8.GetBytes(No);
                    client.Send(buf2);
                    return true;
                }
                catch (Exception ex)
                {
                    NewMain.Nform.logClass.write(ex.Message);
                   // client.Close();
                   // MessageBox.Show(ex.Message);
                    return false;
                }
            }
            void ReceiveMsg()
            {
                while (true)
                {
                    try
                    {
                        byte[] buffer = new byte[1024 * 1024];
                        int n = client.Receive(buffer);

                        servermessage = Encoding.UTF8.GetString(buffer, 0, n);
                        switch (servermessage)
                        {
                            case "1":
                                {
                                    servermessageflag = 1;//检查状态
                                    break;
                                }
                            case "2":
                                {
                                    servermessageflag = 2;
                                    break;
                                }
                        }

                       
                    }
                    catch (Exception ex)
                    {
                        NewMain.Nform.logClass.write(ex.Message);
                        break;
                    }
                }
            }
           public void sendmessage(int flag,volumecontrol volumeCalc)
            {
                try
                {
                    byte[] buf = Encoding.UTF8.GetBytes(Convert.ToString(flag));
                    client.Send(buf);
                    
                    byte[] buf2 = Encoding.UTF8.GetBytes(volumeCalc.carName+" "+volumeCalc.carSN+" "+Convert.ToString(NewMain.Nform.checkBox1.Enabled));                  
                    servermessageflag = -1;
                    client.Send(buf2);
                }
                catch (Exception ex)
                {
                    NewMain.Nform.logClass.write(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
            public  bool sendpackage(int flag, volumecontrol rhs)
            {
                try
                {
                    byte[] buf = Encoding.UTF8.GetBytes(Convert.ToString(flag));
                    client.Send(buf);

                    Thread.Sleep(10);

                    volumepackage t = new volumepackage();
                    t.carVolume =Convert.ToDouble( rhs.carVolume);
                    t.loadingrat = rhs.Loadingrate;
                    t.volume = Convert.ToDouble(rhs.Volume);

                    BinaryFormatter bf;
                    bf = new BinaryFormatter();
                    MemoryStream stream = new MemoryStream();
                    bf.Serialize(stream, t);
                    byte[] buff = stream.ToArray();
                    client.Send(buff, buff.Length, 0);

                    //int size = Marshal.SizeOf(typeof(volumecontrol)); //得到结构体大小
                    //IntPtr buffer = Marshal.AllocHGlobal(size);  //开辟内存空间
                    //Marshal.StructureToPtr(rhs, buffer, false);   //填充内存空间
                    //byte[] bytes = new byte[size];
                    //Marshal.Copy(buffer, bytes, 0, size);   //填充数组
                    //client.Send(bytes);

                }
                catch(Exception ex)
                {
                    NewMain.Nform.logClass.write(ex.Message);
                }
                return true;
            }
            public int checksermessflag()
            {
               switch(servermessageflag)
                {
                    case 1:return 1;
                    case 2:return 2;
                    default: return -1;
                }
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
        static string No;
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
       static NetIP getip;
       public Net cloudnet;


        public Special()
        {
            loadxml();
            for (int i = 0; i < 20; i++)
            {
                iplist[i].No = -1;
                iplist[i].IP = null;
            }
            servermessageflag = -1;
            cloudnet = new Net();
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

            XElement XNo = root.Element("No");
            No = XNo.Value;

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

            XElement No = new XElement("No");
            No.Value = "1";// No; 
            root.Add(No);

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
