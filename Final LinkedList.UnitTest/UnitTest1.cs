using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Final_LinkedList.UnitTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void Addbeginning_AddHeadNode_IncrementCount(string data)
        {
            //Arrange, Act, Behaviour
            var program = new LinkedList(data);


            var result = program.Addbeginning(data);

            Assert.IsTrue(result);

        }
    }
}
