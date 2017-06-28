﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
    private int id;
    public int ID { get { return id; } }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(int id, string firstName, string lastName)
	{
        this.id = id;
        FirstName = firstName;
        LastName = lastName;
	}
}