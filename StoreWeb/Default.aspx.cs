using StoreWeb.Core;
using StoreWeb.Repo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lsbProducts.DataTextField = "Name";
                lsbProducts.DataValueField = "Id";
                lsbProducts.DataSource = new ProductsRepo().GetProducts();
                lsbProducts.DataBind();
            }
        }

        Product GetSelectedProduct()
        {
            Product selectedProduct = null;
            var selectedItem = lsbProducts.SelectedItem;
            if (selectedItem != null)
            {
                int selectedProductId = Convert.ToInt32(selectedItem.Value);
                selectedProduct = new ProductsRepo().GetProduct(selectedProductId);
            }
            return selectedProduct;
        }

        protected void lsbProducts_SelectedChanged(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            if (selectedProduct != null)
            {
                imgProduct.ImageUrl = selectedProduct.Image;
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            if (selectedProduct != null)
            {
                lblCost.Text = "NZD " + selectedProduct.Cost.ToString("0.00");
            }
        }
    }
}