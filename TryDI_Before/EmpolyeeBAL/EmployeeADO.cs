using System;
using System.Collections.Generic;
using System.Text;
using EmployeeDAL;

namespace EmpolyeeBAL
{
    public class EmployeeADO
    {
        public void Add(Employee objEmpolyee)
        {
            if(true)
            {
                SQLServerDAL objDAL = new SQLServerDAL();
                objDAL.Add();
            }
            else
            {
                MysqlDAL objDAL = new MysqlDAL();
                objDAL.Add();
            }
        }
    }
}
