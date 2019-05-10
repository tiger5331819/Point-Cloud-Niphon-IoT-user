using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EVCS
{

    public class SF : SerializableFind
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            if (typeName.Contains("List") == true && typeName.Contains(typeof(IPList).Name) == true)
            {
                return typeof(List<IPList>);
            }

            return base.BindToType(assemblyName, typeName);
        }
    }
    [Serializable]
    public struct configtimexml
    {
        public string time;
        public string beginhour;
        public string beginminute;
        public string endminute;
        public string endhour;
    }
    [Serializable]
    public struct NetIP
    {
        string ip;
        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }
        int point;
        public int Point
        {
            get { return point; }
            set { point = value; }
        }
    }
    [Serializable]
    public struct volumecontrol
    {
        public int carNo;
        public string carName;
        public decimal? carVolume;
        public string carSN;
        public decimal? volume;

        public string count;
        public int Loadingrate;
        public string Endtime;
        public string Begintime;

    }
    [Serializable]
    public class UserData:IoT_Data
    {
        public configtimexml[] configtime;
        public volumecontrol volume;        

        public UserData(string typedata, string typesystem) :base(typedata,typesystem)
        {
            configtime = new configtimexml[3];
            volume = new volumecontrol();
        }
        public UserData():base()
        {

        }
        public UserData GetData()
        {
            UserData data = new UserData(this.TypeData, this.TypeSystem);
            data.ID = ID;
            data.volume = this.volume;
            for (int i = 0; i < 3; i++)
            {
                data.configtime[i] = this.configtime[i];
            }
            return data;
        }
    }
    [Serializable]
    public class User : UserData
    {
        public NetIP ip;
        public Messagetype messagetype;
        public Codemode codemode;
        public User(string typedata, string typesystem) :base(typedata,typesystem)
        {
            ip = new NetIP();
        }
        public bool Update(UserData data)
        {
            try
            {
                for(int i=0;i<3;i++)
                {
                    configtime[i] = data.configtime[i];
                }
                volume = data.volume;
            }
            catch (Exception ex)
            {
                ErrorMessage.GetError(ex);
                return false;
            }
            return true;
        }

    }


    public class UserNet:IoT_Net
    {
        User Data;
        Special cloud;

        public UserNet(ref User data,ref Special s):base("User")
        {
            ip = IPAddress.Parse(data.ip.IP);
            point = new IPEndPoint(ip, data.ip.Point);
            this.cloud = s;
            Data = data;

            Connect();
        }
        public override void ReceiveCommand()
        {
            Send(UserDataToPackage(Data.GetData(), Messagetype.codeus));
            void ipinfo()
            {
                byte[] buf = new byte[1024 * 1024];
              
                socket.Receive(buf);           
                Package package= BytesToPackage(buf);
                if (package.message == Messagetype.codeus)
                    ReceiveIPList(package);
               
            }
            ipinfo();

            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int n = socket.Receive(buffer);
                    Package package = BytesToPackage(buffer);
                    switch (package.message)
                    {
                        case Messagetype.package:NewUserData(package); break;
                        case Messagetype.carinfomessage:
                            NewVolumeMessage(package); break;
                        case Messagetype.volumepackage:
                            NewVolumeMessage(package); break;
                        case Messagetype.codeus: ReceiveIPList(package);break;
                    }
                }
                catch (Exception ex)
                {
                    NewMain.Nform.logClass.write(ex.Message);
                    connectflag = true;
                    break;
                }
            }
        }
        public new static Package BytesToPackage(byte[] buffer)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(buffer, 0, buffer.Length);
                    ms.Flush();
                    ms.Position = 0;
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Binder = new SF();
                    Package package = (Package)bf.Deserialize(ms);
                    return package;
                }
            }
            catch (Exception e)
            {
                ErrorMessage.GetError(e);
                return new Package();
            }
        }

        public void ReceiveIPList(Package package)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(package.data, 0, package.data.Length);
                ms.Flush();
                ms.Position = 0;
                BinaryFormatter bf = new BinaryFormatter();
               cloud.iplist= (List<IPList>)bf.Deserialize(ms);
            }
        }

        public Package UpdateIPList()
        {
            Package package = new Package();
            package.message = Messagetype.codeus;
            package.data= Encoding.UTF8.GetBytes("-1");
            return package;
        }
        public Package CreatCodeToPackage(Codemode codemode)
        {
            Package package = new Package();
            package.message = Messagetype.order;
            switch(codemode)
            {
                case Codemode.stop:package.data = Encoding.UTF8.GetBytes("0");break;
                case Codemode.play:package.data= Encoding.UTF8.GetBytes("1");break;
                case Codemode.monitor: package.data = Encoding.UTF8.GetBytes("2"); break;
                case Codemode.sendvolume: package.data = Encoding.UTF8.GetBytes("3"); break;
                case Codemode.stopsendvolume: package.data = Encoding.UTF8.GetBytes("4"); break;
                case Codemode.release: package.data = Encoding.UTF8.GetBytes("-1"); break;
            }       
            return package;
        }
        /// <summary>
        /// example
        /// </summary>
        /// <param name="package"></param>
        void NewUserData(Package package)
        {
            UserData data = new UserData();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(package.data, 0, package.data.Length);
                ms.Flush();
                ms.Position = 0;
                BinaryFormatter bf = new BinaryFormatter();
                data = (UserData)bf.Deserialize(ms);
            }
            Data.Update(data);
        }
        
        void NewVolumeMessage(Package package)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(package.data, 0, package.data.Length);
                ms.Flush();
                ms.Position = 0;
                BinaryFormatter bf = new BinaryFormatter();

                Data.volume = (volumecontrol)bf.Deserialize(ms);

                Data.messagetype = package.message;          
            }
        }

        public Package UserDataToPackage(UserData data, Messagetype messagetype = Messagetype.package)
        {
            Package package = new Package();
            package.data = null;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    switch (messagetype)
                    {
                        case Messagetype.carinfomessage: bf.Serialize(ms, data.volume); break;
                        case Messagetype.volumepackage: bf.Serialize(ms, data.volume); break;
                        case Messagetype.package: bf.Serialize(ms, data); break;
                        case Messagetype.codeus: bf.Serialize(ms, data); break;
                        default: bf.Serialize(ms, data); break;
                    }
                    ms.Flush();

                    package.message = messagetype;
                    package.data = ms.ToArray();
                }
                return package;
            }
            catch (Exception ex)
            {
                ErrorMessage.GetError(ex);

            }
            return package;
        }
    }
}

