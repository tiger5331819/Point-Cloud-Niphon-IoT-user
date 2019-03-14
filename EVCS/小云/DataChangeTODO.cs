using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EVCS
{
    public class DataChangeTODO
    {
        UserData Data;
        public Special cloud;

        public DataChangeTODO(ref UserData data, ref Special c)
        {
            this.Data = data;
            this.cloud = c;
            Thread check = new Thread(CreateThreadToCheckData);
            check.IsBackground = true;
            check.Start();
        }
        void CreateThreadToCheckData()
        {
            try
            {
                while (true)
                {

                    if (Data.newdatachange())
                    {
                        switch (Data.messagetype)
                        {
                            //case Messagetype.carinfomessage: ChangeCarinfoMessage(); break;
                            case Messagetype.volumepackage: ChangevolumeMessage(); break;
                        }
                        Data.flag = false;
                    }
                    else Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //private void ChangeCarinfoMessage()
        //{
            
        //    MessageBox.Show("yes!");
        //}

        private void ChangevolumeMessage()
        {
            Data.volume.carName = Data.newvolumecontrol.carName;
            Data.volume.carNo = Data.newvolumecontrol.carNo;
            Data.volume.carSN = Data.newvolumecontrol.carSN;
            Data.volume.carVolume = Data.newvolumecontrol.carVolume;
            Data.volume.Loadingrate = Data.newvolumecontrol.Loadingrate;
            Data.volume.volume = Data.newvolumecontrol.volume;
        }
    }
}
