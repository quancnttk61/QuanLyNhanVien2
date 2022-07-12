using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien2
{
    public class QuanLyNhanVien
    {
        public  string id { get; set; }
        public string name { get; set; }
        public DateTime DateoOfBrith { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string  phonenumber { get; set; }

        

        public QuanLyNhanVien(string id, string name, string gender,DateTime dateOfBrith, string address,string phonenumber)
        {
            this.id = id;
            this.name = name;
            DateoOfBrith = dateOfBrith;
            this.gender = gender;
            this.address=address;
            this.phonenumber = phonenumber;
        }
    }
}
