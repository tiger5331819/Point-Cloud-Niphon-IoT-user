using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVCS
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eVCSDataSet.Records”中。您可以根据需要移动或删除它。
            // this.recordsTableAdapter.Fill(this.eVCSDataSet.Records);

            dateTimePickerAnalysisDayly.Value = DateTime.Now;

        }
        int GYear = 0;    //保存全局的年   在dateTimePicker1 的年月发生变化的时候才更新报表
        int GMonth = 0;   //保存全局的月   在dateTimePicker1 的年月发生变化的时候才更新报表
        List<HadGenerateDate> HadDatas= new List<HadGenerateDate>();   //已经生成过的数据 不在重新生成 而是从这个列表中读取
        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    List<int> x = new List<int>() { };    //月数
        //    List<decimal?> y = new List<decimal?>() { };    //每月体积
        //    try
        //    {
        //        //DateTime selected = DateTime.Now;
        //        DateTime selected = dateTimePickerAnalysisDayly.Value;
        //        int year = selected.Year;
        //        int month = selected.Month;
        //        if (GYear == year && GMonth == month)
        //        {
        //            return;
        //        }

        //        var hadDatas = HadDatas.Where(f => f.year == year).Where(f => f.month == month);
        //        int hadDatasCount = hadDatas.Count();
        //        if (hadDatasCount>0)   //已经有了数据
        //        {
        //            x = hadDatas.First().x;
        //            y = hadDatas.First().y;
        //        }
        //        else   //没有生成过数据  重新生成
        //        {

        //            GYear = year;    //更新全局变量
        //            GMonth = month;   //更新全局变量
        //            //int month1;
        //            //if (month == 12)
        //            //{
        //            //    year++;
        //            //    month1 = 0;
        //            //}
        //            //else
        //            //{
        //            //    month1 = month;
        //            //}

        //            using (EVCSEntities1 db = new EVCSEntities1())
        //            {
        //                //循环计算每一天的体体积数
        //                for (int i = 1; i <= Month_Days[month - 1]; i++)
        //                {
        //                    x.Add(i);
        //                    string dayStart = year + "-" + month + "-" + i;
        //                    string dayEnd = "";
        //                    //最后一天需要特殊处理
        //                    if (i == Month_Days[month - 1])
        //                    {
        //                        month++;
        //                        dayEnd = year + "-" + month + "-01";
        //                    }
        //                    else
        //                    {
        //                        dayEnd = year + "-" + month + "-" + (i + 1);
        //                    }

        //                    DateTime DdayStart = Convert.ToDateTime(dayStart);
        //                    DateTime DadyEnd = Convert.ToDateTime(dayEnd);

        //                    decimal? totalVolume = db.Records.Where(f => f.CreateDate >= DdayStart).Where(f => f.CreateDate < DadyEnd).Sum(f => f.Volume);
        //                    y.Add(totalVolume == null ? 0 : totalVolume);
        //                }
        //            }

        //            //存入到已有的列表中
        //            HadDatas.Add(new HadGenerateDate() {year=GYear,month=GMonth,x=x,y=y });
        //        }
                
        //        chartDays.Series[0].Points.DataBindXY(x, y);
                
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            List<int> x = new List<int>() { };    //月数
            List<decimal?> y = new List<decimal?>() { };    //每月体积
            try
            {
                //DateTime selected = DateTime.Now;
                DateTime selected = dateTimePickerAnalysisDayly.Value;
                int year = selected.Year;
                int month = selected.Month;
                if (GYear == year && GMonth == month)
                {
                    return;
                }

                var hadDatas = HadDatas.Where(f => f.year == year).Where(f => f.month == month);
                int hadDatasCount = hadDatas.Count();
                if (hadDatasCount > 0)   //已经有了数据
                {
                    x = hadDatas.First().x;
                    y = hadDatas.First().y;
                }
                else   //没有生成过数据  重新生成
                {

                    GYear = year;    //更新全局变量
                    GMonth = month;   //更新全局变量
                    //int month1;
                    //if (month == 12)
                    //{
                    //    year++;
                    //    month1 = 0;
                    //}
                    //else
                    //{
                    //    month1 = month;
                    //}

                    using (EVCSEntities1 db = new EVCSEntities1())
                    {
                        //循环计算每一天的体体积数
                        //for (int i = 1; i <= Month_Days[month - 1]; i++)
                        //{
                        //    x.Add(i);
                        //    string dayStart = year + "-" + month + "-" + i;
                        //    string dayEnd = "";
                        //    //最后一天需要特殊处理
                        //    if (i == Month_Days[month - 1])
                        //    {
                        //        month++;
                        //        dayEnd = year + "-" + month + "-01";
                        //    }
                        //    else
                        //    {
                        //        dayEnd = year + "-" + month + "-" + (i + 1);
                        //    }

                        //    DateTime DdayStart = Convert.ToDateTime(dayStart);
                        //    DateTime DadyEnd = Convert.ToDateTime(dayEnd);

                        //    decimal? totalVolume = db.Records.Where(f => f.CreateDate >= DdayStart).Where(f => f.CreateDate < DadyEnd).Sum(f => f.Volume);
                        //    y.Add(totalVolume == null ? 0 : totalVolume);
                        //}

                        var datas = db.V_Records_Dayly_Volume.Where(f => f.CreateYear == year && f.CreateMonth == month);
                        foreach (var item in datas)
                        {
                            x.Add((int)item.CreateDay);
                            y.Add(item.totalVolume);
                        }
                        for (int i = 1; i <= Month_Days[month-1]; i++)
                        {
                            if (!x.Contains(i))
                            {
                                x.Add(i);
                                y.Add(0);
                            }
                        }
                    }

                    //存入到已有的列表中
                    HadDatas.Add(new HadGenerateDate() { year = GYear, month = GMonth, x = x, y = y });
                }

                chartDays.Series[0].Points.DataBindXY(x, y);

            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// 每月天数
        /// </summary>
        List<int> Month_Days = new List<int>() {31,28,31,30,31,30,31,31,30,31,30,31};

        private void chartDays_Click(object sender, EventArgs e)
        {

        }

    }
    class HadGenerateDate {
        public int year { get; set; }
        public int month { get; set; }
        public List<int> x { get; set; }
        public List<decimal?> y { get; set; }
    }
}
