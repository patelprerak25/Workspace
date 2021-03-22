using System;
using System.Collections.Generic;
using System.Text;
using EmployeeDAL;

namespace EmpolyeeBAL
{
    public class EmployeeADO
    {
        private IDAL objDAL;
        public EmployeeADO(IDAL odal)
        {
            objDAL = odal;
        }
        public void Add(Employee objEmpolyee)
        {
            //if(true)
            //{
            //    objDAL = new SQLServerDAL();
            //}
            //else
            //{
            //    objDAL = new MysqlDAL();
            //}
            objDAL.Add();
        }
    }
}
