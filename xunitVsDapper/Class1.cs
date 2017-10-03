using System;
using Xunit;

namespace xunitVsDapper
{
    public class Class1
    {
        [Fact]
        public void Test1()
        {
            var gv = new getDbVersion.Class1();
            string ver = gv.GetDbVersion("Data Source=HQ-IS-DB-D01\\SQLSERVER;Initial Catalog=ris;User ID=sa;Password=MSSQLadmin@1;Connect Timeout=600;");
        }
    }
}
