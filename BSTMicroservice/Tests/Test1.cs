using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using BSTMicroservice.Classes;

namespace BSTMicroservice.Tests
{
    public class Test1
    {

        [Test]
        public void Test11()
        {
            var testNode = new Node(1, "elo");
            Assert.AreEqual("elo", testNode.NodeValue);
        }
    }
}
