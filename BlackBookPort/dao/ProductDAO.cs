using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BlackBookPort.dao
{
    class ProductDAO
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataAdapter da;
    

        public void save(Product product) {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Isabel\documents\visual studio 2013\Projects\BlackBookPort\BlackBookPort\BlackBookDB.mdf"";Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Product (Product_ID,Name,Description,Category,Quantity_In_Stock,Price) VALUES (@Product_ID,@Name,@Description,@Category,@Quantity_In_Stock,@Price)");
            cmd.Parameters.Add("@Product_ID", product.ID);
            cmd.Parameters.Add("@Name", product.Name);
            cmd.Parameters.Add("@Description", product.Description);
            cmd.Parameters.Add("@Category", product.Category);
            cmd.Parameters.Add("@Quantity_In_Stock", product.Quantity);
            cmd.Parameters.Add("@Price", product.Price);
            cmd.ExecuteNonQuery();
        }
    }
}
