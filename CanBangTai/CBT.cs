using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanBangTai
{
    public class CBT
    {
        string _colName;
        string _colAddrPLC;
        string _colNoSlot;
        string _colAddr;
        string _colMaxDB;
        string _colNoDB;

        public string ColName { get => _colName; set => _colName = value; }
        public string ColAddrPLC { get => _colAddrPLC; set => _colAddrPLC = value; }
        public string ColNoSlot { get => _colNoSlot; set => _colNoSlot = value; }
        public string ColAddr { get => _colAddr; set => _colAddr = value; }
        public string ColMaxDB { get => _colMaxDB; set => _colMaxDB = value; }
        public string ColNoDB { get => _colNoDB; set => _colNoDB = value; }
    }
}
