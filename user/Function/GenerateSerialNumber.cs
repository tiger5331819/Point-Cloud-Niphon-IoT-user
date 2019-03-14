using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVCS
{
    class GenerateSerialNumber
    {
        /// <summary>
        /// 生成流水号
        /// </summary>
        /// <param name="Prefix">前缀</param>
        /// <param name="DateFormat">时间格式</param>
        /// <param name="Init">初始值</param>
        /// <param name="Increment">自增量</param>
        /// <param name="length">流水号长度</param>
        /// <returns></returns>
        public string Generate(string Prefix,string DateFormat,int Init,int Increment, int Length) {
            string date = DateTime.Now.ToString(DateFormat);
            using (EVCSEntities1 db=new EVCSEntities1())
            {
                var SerialNumber = db.SerialNumber.Where(f => f.Prefix == Prefix).Where(f => f.DateFormat == DateFormat).Where(f => f.Init == Init).Where(f => f.Increment == Increment).Where(f => f.Length == Length);
                if (SerialNumber.Count()== 0)
                {
                    db.SerialNumber.Add(new SerialNumber() { Prefix= Prefix,DateFormat = DateFormat , Init = Init, Increment = Increment, Length = Length,CurrentValue=Init});
                    db.SaveChanges();
                }
                else
                {
                    SerialNumber.First().CurrentValue+= Increment;
                    db.SaveChanges();

                }
                var CurrentValue = db.SerialNumber.Where(f => f.Prefix == Prefix).Where(f => f.DateFormat == DateFormat).Where(f => f.Init == Init).Where(f => f.Increment == Increment).Where(f => f.Length == Length).FirstOrDefault().CurrentValue;
                return Prefix+ date+ CurrentValue.ToString().PadLeft(Length, '0'); 
            }
        }
    }
}
