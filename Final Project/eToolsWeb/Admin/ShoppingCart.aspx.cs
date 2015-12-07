using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eToolsSystem.BLL;

public partial class Admin_ShoppingCart : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    


    //protected void ProductMenuRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    //{
    //    var btn1 = e.Item.FindControl("AddButton") as Button;
    //    var btn2 = e.Item.FindControl("CartButton") as Button;
    //    var lab = e.Item.FindControl("CartLabel") as Label;
    //    if (e.CommandName == "Clicked")
    //    {
    //        btn1.Visible = false;
    //        btn2.Visible = true;
    //        lab.Visible = true;
    //    }
    //}

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
      
    }

  
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        
            
            GridViewRow row = GridView1.Rows[e.NewSelectedIndex];
            string categoryid = (row.FindControl("ID") as Label).ToString();
            int preid = Int32.Parse(categoryid);
            TempaleControll Lottery649 = new TempaleControll();
            Lottery649.getProductMenu(preid);
            ProductMenuListView.DataBind();
         
       
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void ProductMenuListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        var btnAdd = e.Item.FindControl("AddButton") as Button;
        var lbtnCart = e.Item.FindControl("CartButton") as LinkButton;
        var lbQ = e.Item.FindControl("lbQuantities") as Label;
        var txEnterQ = e.Item.FindControl("tbSubmit") as TextBox;
        if(e.CommandArgument == "Clicked")
        {
            btnAdd.Visible = false;
            lbtnCart.Visible = true;
            lbQ.Text = txEnterQ.Text;

            
            //SiteMaster S = new SiteMaster();
            //S.addItems(e.CommandArgument);

            lbConstructing.Text = (e.CommandName).ToString();

            TempaleControll LotteryMax = new TempaleControll();
            LotteryMax.AddToCart(Int32.Parse(e.CommandName), Int32.Parse(txEnterQ.Text));
         //   ProductMenuListView.DataBind();
        }

    }
   
}