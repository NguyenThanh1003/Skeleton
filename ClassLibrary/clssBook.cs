using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clssBook
    {
        public bool Active { get; set; }
        public string BookID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public int Publisher { get; set; }
        public int Quantity { get; set; }
        public string Genre { get; set; }

        public bool Find(int book_ID)
        {
            return true;
        }





        public bool Find(int Book_ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Book_ID", Book_ID);
            DB.Execute("sproc_BookTable_FilterByBookId");

            
            if (DB.Count == 1)
            {
                mBookID = Convert.ToInt32(DB.DataTable.Rows[0]["Book_ID"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mGenre = Convert.ToString(DB.DataTable.Rows[0]["Genrec "]);
                mPublisher = Convert.ToString(DB.DataTable.Rows[0]["Publisher"]);
                mYear = Convert.ToString(DB.DataTable.Rows[0]["Year"]);
                mPrice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);
                mQuantity = Convert.ToString(DB.DataTable.Rows[0]["Quantity"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

