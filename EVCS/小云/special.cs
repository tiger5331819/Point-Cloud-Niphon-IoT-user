﻿using EVCS.小云;
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
    [Serializable]
    public struct IPList
    {
        public string ID;
        public string IP;
    }
    public class Special
    {
        public User Data;
        public IPList[] iplist = new IPList[100];
        public bool IPListflag = false;

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
        public Special cloud;
        public UserNet cloudnet;
    
        public void showxml()
        {
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(Data.configtime[i].time + Data.configtime[i].beginhour + Data.configtime[i].beginminute);
                MessageBox.Show(Data.configtime[i].endhour + Data.configtime[i].endminute);
            }
        }
        /// <summary>
        /// 加载xml
        /// 子端结构体赋值为空
        /// 实例化Net类
        /// </summary>
        public Special()
        {
            this.Data = new User("User", "PointCloud-EVCS");
            loadxml();     
            cloud = this;
            this.cloudnet = new UserNet(ref Data,ref cloud);
        }

        public int gethour(int a, bool flag)
        {
            if (flag) return Convert.ToInt32(Data.configtime[a].beginhour);
            else return Convert.ToInt32(Data.configtime[a].endhour);
        }
        public string gethour(int a, bool flag, bool isstring)
        {
            if (flag) return Data.configtime[a].beginhour;
            else return Data.configtime[a].endhour;
        }
        public int getminute(int a, bool flag)
        {
            if (flag) return Convert.ToInt32(Data.configtime[a].beginminute);
            else return Convert.ToInt32(Data.configtime[a].endminute);
        }
        public string getminute(int a, bool flag, bool isstring)
        {
            if (flag) return Data.configtime[a].beginminute;
            else return Data.configtime[a].endminute;
        }
        public bool sethour(int a, bool flag, string t)
        {
            if (flag) Data.configtime[a].beginhour = t;
            else Data.configtime[a].endhour = t;
            return true;
        }
        public bool setminute(int a, bool flag, string t)
        {
            if (flag) Data.configtime[a].beginminute = t;
            else Data.configtime[a].endminute = t;
            return true;
        }
        public void loadxml()
        {
            XDocument document=new XDocument();
            //将XML文件加载进来
            document= XDocument.Load("config.xml");

            //获取到XML的根元素进行操作
            XElement root = document.Root;

            XElement Device = root.Element("Device");
            XElement ID = Device.Element("ID");
            Data.ID = ID.Value;

            XElement version = Device.Element("EVCSversion");
            EVCSversion = version.Value;
            version = Device.Element("Volumeversion");
            Volumeversion = version.Value;


            XElement NetLink = root.Element("NetLink");
            XElement IP = NetLink.Element("IP");
            XElement server = IP.Element("server");

            Data.ip.IP = server.Value;
            XElement Point = IP.Element("serverpoint");
            Data.ip.Point = int.Parse(Point.Value);



            //获取根元素下的所有子元素
            IEnumerable<XElement> ele = root.Elements("time");
            IEnumerable<XElement> enumerable = ele.Elements();
            int i = 0;
            foreach (XElement item in enumerable)
            {
                Data.configtime[i].time = item.Name.ToString();
                XElement timefind = item.Element("beginhour");
                Data.configtime[i].beginhour = timefind.Value;
                timefind = item.Element("beginminute");
                Data.configtime[i].beginminute = timefind.Value;
                timefind = item.Element("endhour");
                Data.configtime[i].endhour = timefind.Value;
                timefind = item.Element("endminute");
                Data.configtime[i].endminute = timefind.Value;
                i++;
            }
        }
        public void writexml()
        {
            //获取根节点对象
            XDocument document = new XDocument();
            XElement root = new XElement("EVCS");

            XElement Device = new XElement("Device");
            XElement ID = new XElement("ID");
            ID.Value = Data.ID;

            XElement EVCSv = new XElement("EVCSversion");
            EVCSv.Value = EVCSversion;
            Device.Add(EVCSv);
            XElement version = new XElement("Volumeversion");
            version.Value = Volumeversion;
            Device.Add(version);

            root.Add(Device);

            XElement NetLink = new XElement("NetLink");
            XElement IP = new XElement("IP");
            IP.SetElementValue("server", Data.ip.IP);
            IP.SetElementValue("serverpoint", Data.ip.Point);
            NetLink.Add(IP);
            root.Add(NetLink);

            XElement time = new XElement("time");

            foreach (configtimexml x in Data.configtime)
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
            string path = logPath + "/行动日志文件";
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
