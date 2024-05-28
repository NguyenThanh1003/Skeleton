using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Drawing;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class clsBook
    {
       
        
        public int BookID { get; private set; }
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public string Publisher { get; private set; }
        public string Year { get; private set; }
        public string Price { get; private set; }
        public string Quantity { get; private set; }
        public bool Active { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsBook clsBook = new clsBook();

            Assert.IsNotNull(AnBook);

        }
        [TestMethod]

        public void ActivePropertyOk()
        {
            clsBook AnBook = new clsBook();
            Boolean TestData = true;

            AnBook.Active = TestData;

            Assert.AreEqual(AnBook.Active, TestData);
        }

        [TestMethod]
        public void BookIDIdPropertyOK()
        {

            clsBook AnBook = new clsBook();

            Int32 TestData = 1;

            AnBook.BookID = TestData;

            Assert.AreEqual(AnBook.BookID, TestData);
        }
        [TestMethod]
        public void TitlePropertyOK()
        {

            clsBook AnBook = new clsBook();

            string TestData = "Science Book";

            AnBook.Title = TestData;

            Assert.AreEqual(AnBook.Title, TestData);
        }
        [TestMethod]
        public void GenrePropertyOK()
        {

            clsBook AnBook = new clsBook();

            string TestData = "Science";

            AnBook.Genre = TestData;

            Assert.AreEqual(AnBook.Genre, TestData);
        }
        [TestMethod]
        public void PublisherPropertyOK()
        {

            clsBook AnBook = new clsBook();

            string TestData = "Van Thanh";

            AnBook.Publisher = TestData;

            Assert.AreEqual(AnBook.Publisher, TestData);
        }
        [TestMethod]
        public void YearPropertyOK()
        {

            clsBook AnBook = new clsBook();

            string TestData = "2001";

            AnBook.Year = TestData;

            Assert.AreEqual(AnBook.Year, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {

            clsBook AnBook = new clsBook();

            string TestData = "100£";

            AnBook.Price = TestData;

            Assert.AreEqual(AnBook.Price, TestData);

        }
        [TestMethod]
        public void QuantityPropertyOK()
        {

            clsBook AnBook = new clsBook();

            string TestData = "10";

            AnBook.Quantity = TestData;

            Assert.AreEqual(AnBook.Quantity, TestData);


        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsBook AnBook = new clsBook();
            Boolean Found = false;
            Int32 Book_ID = 1;
            Found = AnBook.Find(Book_ID);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestBookIDFound()
        {
            clsBook AnBook = new clsBook();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Book_ID = 1;
            Found = AnBook.Find(Book_ID);
            if (AnBook.BookID != 1)
            {
                OK = false;

            }
            Assert.IsTrue(!OK);
        }



        [TestMethod]
        public void TestTitleFound()
        {
            clsBook AnBook = new clsBook();

            Boolean Found = false;
            Boolean OK = true;
            Int32 Book_ID = 1;
            Found = AnBook.Find(Book_ID);

            if (AnBook.Title != "Science Book")
            {
                OK = false;
            }
            Assert.IsTrue(!OK);
        }
        [TestMethod]
        public void TestGenreFound()
        {
            clsBook AnBook = new clsBook();

            Boolean Found = false;
            Boolean OK = true;
            Int32 Book_ID = 1;
            Found = AnBook.Find(Book_ID);

            if (AnBook.Genre != "Science")
            {
                OK = false;
            }
            Assert.IsTrue(!OK);
        }
        [TestMethod]
        public void TestPublisherFound()
        {
            clsBook AnBook = new clsBook();

            Boolean Found = false;
            Boolean OK = true;
            Int32 Book_ID = 1;
            Found = AnBook.Find(Book_ID);

            if (AnBook.Publisher != "Van Thanh")
            {
                OK = false;
            }
            Assert.IsTrue(!OK);
        }
        public void TestYearFound()
        {
            clsBook AnBook = new clsBook();

            Boolean Found = false;
            Boolean OK = true;
            Int32 Book_ID = 1;
            Found = AnBook.Find(Book_ID);

            if (AnBook.Year != "2001")
            {
                OK = false;
            }
            Assert.IsTrue(!OK);
        }
        public void TestPriceFound()
        {
            clsBook AnBook = new clsBook();

            Boolean Found = false;
            Boolean OK = true;
            Int32 Book_ID = 1;
            Found = AnBook.Find(Book_ID);

            if (AnBook.Price != "100£")
            {
                OK = false;
            }
            Assert.IsTrue(!OK);
        }
        public void TestQuantityFound()
        {
            clsBook AnBook = new clsBook();

            Boolean Found = false;
            Boolean OK = true;
            Int32 Book_ID = 1;
            Found = AnBook.Find(Book_ID);

            if (AnBook.Quantity != "10")
            {
                OK = false;
            }
            Assert.IsTrue(!OK);
        }
    }
}
   

        


    
        [TestClass]
        public class clsBookTests
        {
            [TestMethod]
            public void ValidMethodOK()
            {
                // Arrange
                clsBook AnBook = new clsBook();
                string BookID = "1";
                string Title = "Science Book";
                string Genre = "Science";
                string Publisher = "Van Thanh";
                string Year = "2001";
                string expected = "";

                // Act
                string Error = AnBook.Valid(BookID, Title, Genre, Publisher, Year);

                // Assert
                Assert.AreEqual(expected, Error);
            }
        }

        public class clsBook
        {
            public string Valid(string BookID, string Title, string Genre, string Publisher, string Year)
            {
              
                return "";
            }
        }
    
