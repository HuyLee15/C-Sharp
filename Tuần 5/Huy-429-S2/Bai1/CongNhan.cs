using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class CongNhan:Nguoi
    {
        protected double SoGio { get; set; }
        protected double Luong1H { get; set; }
        public double tienLuong()
        {
            return this.Luong1H * this.SoGio;
        }
        public CongNhan():base()
        {

        }
        public CongNhan(string ht, string gt, int ns, double sg, double luong) : base(ht, gt, ns)
        {
            this.SoGio = sg;
            this.Luong1H = luong;
        }
        public override void Output()
        {
            base.Output();
            Console.Write($" \t{this.SoGio} \t{this.Luong1H} \t{this.tienLuong()}");
        }
    }
}
