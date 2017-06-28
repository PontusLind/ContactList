using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Adress
{
    private int id;
    public int ID { get { return id; } }

    public int CID { get; set; }
    public string Typ { get; set; }
    public string Street { get; set; }
    public string Town { get; set; }
    public string Zip { get; set; }

    public Adress(int id,int cid,string typ,string street,string town, string zip)
	{
        this.id = id;
        CID = cid;
        Typ = typ;
        Street = street;
        Town = town;
        Zip = zip;
	}
}