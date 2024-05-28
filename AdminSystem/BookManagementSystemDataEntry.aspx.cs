using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
 
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnOk_Click(object sender, EventArgs e)
    {
        ClassLibrary.clsBook AnBook = new ClassLibrary.clsBook();

        AnBook.Title = Convert.ToInt32(TBTitle.Text);
        
        Session["AnBook"] = AnBook;
        Response.Redirect("BookManagementViewer.aspx");
        
                                     

    }
    public class clsBook
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public bool Active { get; set; }

        internal bool Find(int bookId)
        {
            throw new NotImplementedException();
        }
    }


    protected void BtnFind_Click(object sender, EventArgs e)
    {
     clsBook AnBook = new clsBook();
        Int32 BookId;
        Boolean Found = false;
        BookId = Convert.ToInt32(TBBookid.Text);
        Found = AnBook.Find(BookId);

        if (Found == true)
        { 
            TBTitle.Text = AnBook.Title;
            TBGenre.Text = AnBook.Genre;
            TBPublisher.Text = AnBook.Publisher;    
            TBYear.Text = AnBook.Year;
            TBPrice.Text = AnBook.Price;    
            TBQuantity.Text = AnBook.Quantity;  
            chkActive.Checked = AnBook.Active;  
        }
        
    }
}