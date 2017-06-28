using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Phone
{
    private int id;
    public int ID { get { return id; } }

    public string CID { get; set; }
    public string Type { get; set; }
    public string PhoneNr { get; set; }

    public Phone(int id,int cid, string phone, string type)
	{
        this.id = id;
        PhoneNr = phone;
        Type = type;
        CID = CID;
	}
}