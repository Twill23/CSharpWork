using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section14.Final_Exam_1
{
    [TestClass]
    [TestCategory("FinalExam")]
    public class FinalExam
    {
        [TestMethod]
        public void Test_ComplicatedPage()
        {
            ComplicatedPage compPage = new ComplicatedPage();
            string pageName = compPage.PageName;
            Assert.AreEqual(pageName, "Complicated Page");
        }

        [TestMethod]
        public void Test_RandomStuff()
        {
            SectionOfRandomStuff random = new SectionOfRandomStuff();
            random.FillForm();
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void Test_Buttons()
        {
            
            SectionOfButtons buttons = new SectionOfButtons();
            buttons.Button.Click();
           
            Console.WriteLine("Null reference to the button element ");
            
           
        }
    }
}
