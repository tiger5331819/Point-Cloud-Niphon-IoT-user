//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVCS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Records
    {
        public int ID { get; set; }
        public Nullable<int> CarNO { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public Nullable<int> Loading_rate { get; set; }
        public Nullable<int> Count { get; set; }
        public string SN { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Remark { get; set; }
    }
}