using System;
//using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskApp
{
    [TestClass]
    public class ToDoClassTest
    {
        private ToDo sut;

        
        public ToDoClassTest()
        {
            sut = new ToDo();
        }

        [TestMethod]
        public void List_Is_Empty()
        {
            // action
            var result = sut.isEmpty();

            // assert
            Assert.IsTrue(result, "Last list not empty");
        }

        [DataRow("Do Laundry")]
        [TestMethod]
        public void ToDo_AddTask_AddedSuccessfully(string taskName)
        {
            Assert.IsTrue(sut.AddTask(taskName));   
        }

        [DataRow("Clean Kitchen")]
        [DataTestMethod]
        //[ExpectedException(typeof(Exception))]
        public void ToDo_AddDuplicateTask_ShouldThowException(string duplicateTaskName)
        {

            // arrange
            sut.AddTask(duplicateTaskName);

            Action action = () => sut.AddTask(duplicateTaskName);

            //action
            // sut.AddTask(duplicateTaskName);
            Assert.AreEqual(Assert.ThrowsException<Exception>(action).Message, "Duplicate tasks are not allowed.");



        }

         
    }
}
