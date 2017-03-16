using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DONGSHIN
{
    public class commonReturn
    {

        private DataSet _Dataset = new DataSet();
        private string _Message = "";
        private int _Code;
        private int _ExeCount;
        private object _ExeString;

        public void Dispose()
        {
            _Dataset.Dispose();
        }

        public int Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
            }
        }

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        public int ExeCount
        {
            get
            {
                return _ExeCount;
            }
            set
            {
                _ExeCount = value;
            }
        }

        public object ExeString
        {
            get
            {
                return _ExeString;
            }
            set
            {
                _ExeString = value;
            }
        }

        System.Data.SqlClient.SqlCommand _SqlCMD = new System.Data.SqlClient.SqlCommand();
        public System.Data.SqlClient.SqlCommand SqlCMD
        {
            get
            {
                return _SqlCMD;
            }
            set
            {
                _SqlCMD = value;
            }
        }
        System.Data.SqlClient.SqlParameter _SqlPARA = new System.Data.SqlClient.SqlParameter();
        public System.Data.SqlClient.SqlParameter SqlPARA
        {
            get
            {
                return _SqlPARA;
            }
            set
            {
                _SqlPARA = value;
            }
        }

        public DataSet Dataset
        {
            get
            {
                return _Dataset;
            }
            set
            {
                _Dataset = value;
            }
        }


    }//클래스
}//네임스페이스
