using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneWinForm
{
    public class User
    {
        string name, fami, och, time, punct;
        int ves, nomer, pol;
        DateTime dt;
        public string Name { get { return name; } set { name = value; } }
        public string Fami { get { return fami; } set { fami = value; } }
        public string Och { get { return och; } set { och = value; } }
        public string Time { get { return time; } set { time = value; } }
        public string Punct { get { return punct; } set { punct = value; } }
        public int Ves { get { return ves; } set { ves = value; } }
        public int Nomer { get { return nomer; } set { nomer = value; } }
        public int Pol { get { return pol; } set { pol = value; } }
        public DateTime Dt { get { return dt; } set { dt = value; } }
        public User() { }
        public User(string _name, string _fami, string _och, string _time, string _punct, int _ves, int _nomer, int _pol, DateTime _dt) { name = _name; fami = _fami; och = _och; time = _time; punct = _punct; ves = _ves; nomer = _nomer; pol = _pol; dt = _dt; }
        public string print_name()
        {
            return $"{fami}  {name}  {och}";
        }
        public override string ToString()
        {
            return $"{fami.ToUpper()[0]}.{name.ToUpper()[0]}.{och.ToUpper()[0]}. | {punct} | {ves} | {dt.ToShortDateString()} | {nomer}";
        }
    }
}
