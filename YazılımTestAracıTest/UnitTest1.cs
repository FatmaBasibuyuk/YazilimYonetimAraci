using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yazılım_Test_Aracı;

namespace YazılımTestAracıTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanInstantiateLogin()
        {
            frmLogin yta = new frmLogin();
        }
        [TestMethod]
        public void CanInstantiateInsertProject()
        {
            frmInsertProjects yta = new frmInsertProjects(1);
          
        }
        [TestMethod]
        public void CanInstantiateInsertProcess()
        {
            frmInsertProcess yta = new frmInsertProcess(1,"merhaba",1);
        }

    }
}
