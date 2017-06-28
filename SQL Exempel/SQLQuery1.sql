select * from Contact

insert into Contact (Firstname,Lastname) values ('Nisse', 'Hellberg')

select * from Adress

insert into Adress (CID, Street, Town, Zip, Typ) values ('1', 'Storgatan 4', 'Malmö','42521','Hem')

select * from Contact, Adress where Contact.ID = Adress.CID

insert int Phone (CID, Typ, Phone) values ('1', 'Hem', '0723739538')

select * from Contact, Phone where Contact.ID = Phone.CID

update Contact set Firstname='Håkan', Lastname='Johansson' where ID=4

delete from Contact where ID=3