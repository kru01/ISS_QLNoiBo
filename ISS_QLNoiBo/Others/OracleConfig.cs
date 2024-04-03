using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS_QLNoiBo.Others
{
    public static class OracleConfig
    {
        public const string host = "localhost";
        public const string port = "1521";
        public const string service = "XEPDB1";
        public const string connString = "localhost:1521/XEPDB1";
        public const string schema = "A01_QLNOIBO";
        public enum UIDBounds { low=150, high=1000000 };
        public const string olsPolicy = "POL_A01_THONGBAO";
    }
}
