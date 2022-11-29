using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class Test : System.Web.UI.Page
    {
        string[] sa_Cat = new string[2] { "蔬菜", "水果" };
        string[,] sa_2D = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i_Ct = 0; i_Ct < sa_Cat.Length; i_Ct++)
                {
                    ListItem o_L = new ListItem();
                    o_L.Text = o_L.Value = sa_Cat[i_Ct];

                    ddl_Category.Items.Add(o_L);
                }
                mt_GenSecondList();
            }
        }

        protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_GenSecondList();
        }
        protected void mt_GenSecondList()
        {
            int i_ind = ddl_Category.SelectedIndex;
            ddl_Food.Items.Clear();
            for (int i_Ct = 0; i_Ct < sa_2D.GetLength(1); i_Ct++)//sa_2D.GetLength(1)是抓取sa_2D[(0),(1)]
            {
                ListItem o_L = new ListItem();
                o_L.Text = o_L.Value = sa_2D[i_ind, i_Ct];

                ddl_Food.Items.Add(o_L);
            }
            //Response.Write(ddl_Category.SelectedIndex);
        }

    }
}