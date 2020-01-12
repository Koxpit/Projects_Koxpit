using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Note;
using System.Collections.Generic;

namespace NoteBook_UnitTest
{
    [TestClass]
    public class UnitTestSearch
    {
        List<Record> TestListRecords = new List<Record>() {
                new Record {
                    Name = "Alex",
                    Surname = "Briton",
                    Patronymic = "R.",
                    Birthday = new DateTime(2001, 01, 01).ToLongDateString(),
                    PhoneNumber = "8 800 555 35 35"
                },
                new Record
                {
                    Name = "Oliver",
                    Surname = "Silvero",
                    Patronymic = "K.",
                    Birthday = new DateTime(1999, 02, 11).ToLongDateString(),
                    PhoneNumber = "8 900 999 99 99"
                }
            };

        List<Record> ResultListRecords;

        [TestMethod]
        public void SearchFName()
        {
            ResultListRecords = SearchRecords
                .SearchFName(TestListRecords[0].Name, TestListRecords);

            Assert.AreEqual(TestListRecords[0], ResultListRecords[0]);
        }

        [TestMethod]
        public void SearchLName()
        {
            ResultListRecords = SearchRecords
                .SearchLName(TestListRecords[0].Surname, TestListRecords);

            Assert.AreEqual(TestListRecords[0], ResultListRecords[0]);
        }

        [TestMethod]
        public void SearchPatronymic()
        {
            ResultListRecords = SearchRecords
                .SearchPatronymic(TestListRecords[0].Patronymic, TestListRecords);

            Assert.AreEqual(TestListRecords[0], ResultListRecords[0]);
        }

        [TestMethod]
        public void SearchBirthday()
        {
            ResultListRecords = SearchRecords
                .SearchBirthday(TestListRecords[0].Birthday, TestListRecords);

            Assert.AreEqual(TestListRecords[0], ResultListRecords[0]);
        }

        [TestMethod]
        public void SearchPhoneNumber()
        {
            ResultListRecords = SearchRecords
                .SearchPhoneNumber(TestListRecords[0].PhoneNumber, TestListRecords);

            Assert.AreEqual(TestListRecords[0], ResultListRecords[0]);
        }

        [TestMethod]
        public void SearchRecord()
        {
            ResultListRecords = SearchRecords.SearchRecord(TestListRecords[0], TestListRecords);

            Assert.AreEqual(TestListRecords[0], ResultListRecords[0]);
        }
    }
}
