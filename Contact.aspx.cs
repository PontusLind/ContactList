using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

public partial class Contact : System.Web.UI.Page
{
    public List<Person> contactList = new List<Person>();
    static string connectionString = "Data Source=localhost;Initial Catalog=Elsa;Integrated Security=True";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Request["deleta"] != null)
        {
            //http://localhost:51616/Contact.aspx?deleta=IAMERROR
            string input = Page.Request["deleta"];
        }
        GetContacts();

        myLiteral.Text = JsonConvert.SerializeObject(contactList);

    }

    private void GetContacts()
    {
        SqlConnection myConnection = new SqlConnection();

        myConnection.ConnectionString = connectionString;

        try
        {
            myConnection.Open();

            SqlCommand myCommand = new SqlCommand();

            myCommand.Connection = myConnection;

            myCommand.CommandText = "select * from Contact";

            SqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                int id = Convert.ToInt32(myReader["ID"].ToString());
                string firstName = myReader["Firstname"].ToString();
                string lastName = myReader["Lastname"].ToString();

                contactList.Add(new Person(id, firstName, lastName));
            }
            myCommand.CommandText = "select * from Adress";

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                int cid = Convert.ToInt32(myReader["CID"].ToString());
                int id = Convert.ToInt32(myReader["ID"].ToString());
                string typ = myReader["Typ"].ToString();
                string street = myReader["Street"].ToString();
                string town = myReader["Town"].ToString();
                string Zip = myReader["Zip"].ToString();

                contactList[cid].myAddress.Add (new Adress(id, cid, typ, street, town, Zip));
            }
            myCommand.CommandText = "select * from Phone";

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                int cid = Convert.ToInt32(myReader["CID"].ToString());
                int id = Convert.ToInt32(myReader["ID"].ToString());
                string typ = myReader["Typ"].ToString();
                string phone = myReader["Phone"].ToString();

                contactList[cid].myPhonNr.Add(new Phone(id, cid, typ, phone));
            }



        }
        catch (Exception)
        {
        }
        finally
        {
            myConnection.Close();
        }
    }
}