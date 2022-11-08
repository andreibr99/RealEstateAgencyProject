
CREATE DATABASE AgentieDB;

CREATE TABLE Agentie(
id_agentie INT IDENTITY,
nume VARCHAR(25)
);

CREATE TABLE Spatiu(
id_spatiu INT IDENTITY,
adresa VARCHAR(100),
zona INT,
suprafata INT ,
id_tip INT
);

CREATE TABLE Tip(
id_tip INT IDENTITY,	
denumire VARCHAR(20),
caracteristici VARCHAR(300)
);

CREATE TABLE Oferta(
id_agentie INT,
id_spatiu INT,
vanzare VARCHAR(1) CHECK(vanzare='D' OR vanzare='N'),
pret INT,
moneda VARCHAR(3) CHECK(moneda IN ('EUR','RON','USD'))
);

ALTER TABLE Agentie
ADD email VARCHAR(25);

INSERT INTO AGENTIE(nume,email)  values('Spatii Comerciale SRL','spatiicomerciale@gmail.ro');
INSERT INTO AGENTIE(nume,email)  values('IMOBILIARE BOLERO SRL','ImobBolero@hotmail.ro');
INSERT INTO AGENTIE(nume,email)  values('TWETY SRL','TWETYsrl@gmail.ro');
INSERT INTO AGENTIE(nume,email)  values('PLEXESTATE SRL','plexestateSRL@yahoo.ro');
INSERT INTO AGENTIE(nume,email)  values('CASSA LOCO SRL','cassaloco@yahoo.ro');


INSERT INTO TIP(denumire,caracteristici) values('garsoniera','Garsoniera este compartimentat intr-o camera mare cu canapea extensibila, bucatarie, baie si hol.');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Este compus din: hol, baie, bucatarie, 2 camere decomandate si balcon.');
INSERT INTO TIP(denumire,caracteristici) values('garaj','Garaj cu pardoseala din beton,pereti zidarie, usa metalica');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Este recent renovat, fiind compartimentat intr-o bucatarie mobilata si utilata complet, cu totul nou, 2 dormitoare decomandate si baie cu cabina de dus.');
INSERT INTO TIP(denumire,caracteristici) values('garsoniera','Garsoniera mobilata, cu toate utilitatiile,');
INSERT INTO TIP(denumire,caracteristici) values('garsoniera','Garsoniera amenajata modern, complet mobilata si utilata,');
INSERT INTO TIP(denumire,caracteristici) values('birou','Birou dotat cu internet, telefon fix și telefon mobil (la cerere), cu secretariat / recepție.');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Este recent renovat si este compus din 2 bai,hol,bucatarie,4 camere decomandate si 2 balcoane');
INSERT INTO TIP(denumire,caracteristici) values('garsoniera','Garsoniera este compusa din: baie proprie si camera. Dotari: masina de spalat, frigider, dulap, canapea extensibilă, finisaje noi.');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Este compus din: hol, baie, bucatarie, 2 camere decomandate,un living semidecomanta si balcon.');
INSERT INTO TIP(denumire,caracteristici) values('birou','Spatiul este nou renovat si dispune de receptie, grupuri sanitare private placate cu piatra naturala, Grohe, compartimentari din sticla, sistem access card si internet');
INSERT INTO TIP(denumire,caracteristici) values('garsoniera','Garsoniera este compartimentata in camera,bucataria ,baie si hol. Camera este compusa dintr-o canapea extensibila si un mobilier format din rafturi si sifonier .');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Apartamentul este confort lux decomandat si este dotat cu centrala proprie, aer conditionat, 1 baie, 1 balcon, faianta moderna, gresie moderna, parchet masiv.');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Acesta este decomandat avand 3 dormitoare,1 living,1 bucataria,o baie si balcon.Locuinta beneficiaza de: termopan prospat renovat, usa metalica la intrare.');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Apartamentul este finisat modern, detine centrala termica, geamuri termopan, usa metalica, parchet , gresie si faianta.');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Compartimentarea este următoarea: 1 living, 1 dormitor, 1 bucătărie, 1 baie, 1 hol şi 1 balcon mare.De asemenea, proprietatea dispune şi de un loc de parcare subteran.');
INSERT INTO TIP(denumire,caracteristici) values('garsoniera','Compartimentarea apartamentului este decomandata si dispusa astfel: o camera, bucatarie, hol, dressing si un balcon de 3 mp');
INSERT INTO TIP(denumire,caracteristici) values('birou','Spatiul este partial mobilat: contine blaturi de lucru si birouri individuale pentru un numar de 15 posturi.');
INSERT INTO TIP(denumire,caracteristici) values('garaj','Se inchiriaza pentru masina!');
INSERT INTO TIP(denumire,caracteristici) values('apartament','Apartamentul este finisat cu bun gust , bucataria este complet utilata si mobilata. Apartamentul are un dormitor cu pat matrimonial. Camera de zi este mobilata cu o canapea si are amenajat un loc de luat masa.');


INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Cluj,Strada Zaharia Stancu','1','30','19');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Cluj,Strada Horea','2','55','2');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Cluj,Strada Mihai-Viteazu','3','35','3');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Botosani,Strada Ion Pillat','4','44','4');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Bucuresti,Strada Lapusului','5','23','15');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Cluj,Strada Observatorului','6','25','7');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Bucuresti,Strada Octavian Goga','7','23','13');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Cluj,Strada Buna Ziua','1','100','8');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Iasi,Strada Cuza Voda','8','20','9');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Constanta,Strada Horea','2','55','1');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Cluj,Strada Unirii','4','115','18');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Arad,Strada Meteor','6','25','16');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Timisoara,Strada Dornei','5','65','20');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Craiova,Strada Triajului','9','70','14');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Brasov,Strada Bucegi','11','48','6');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Bucuresti,Strada Alverna','1','44','10');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Suceava,Strada Cetatii','8','37','17');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Cluj,Strada Portelanului','10','20','12');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Iasi,Aleea Reteza','11','42','5');
INSERT INTO SPATIU(adresa,zona,suprafata,id_tip) values('Cluj,Strada Teodor-Mihali','10','54','11');

INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('1','5','D','50000','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('2','11','N','6200','RON');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('3','7','D','43500','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('3','2','N','1900','RON');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('1','13','D','55000','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('2','8','D','90000','USD');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('3','6','N','1500','RON');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('3','9','N','300','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('4','13','D','54500','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('5','6','N','250','USD');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('5','18','D','25000','USD');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('4','1','N','140','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('3','19','D','15000','USD');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('4','34','N','2200','RON');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('2','19','D','65000','USD');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('1','15','N','500','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('2','12','D','35000','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('5','1','N','100','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('1','1','N','90','EUR');
INSERT INTO OFERTA(id_agentie,id_spatiu,vanzare,pret,moneda) values('2','6','N','300','EUR');


commit;

ALTER TABLE Agentie ADD PRIMARY KEY(id_agentie);

ALTER TABLE Spatiu ADD PRIMARY KEY(id_spatiu);

ALTER TABLE Tip ADD PRIMARY KEY(id_tip);




ALTER TABLE Spatiu  ADD FOREIGN KEY(id_tip) REFERENCES Tip(id_tip);
ALTER TABLE Oferta ADD FOREIGN KEY(id_agentie) REFERENCES Agentie(id_agentie) ON DELETE SET NULL;
ALTER TABLE Oferta ADD FOREIGN KEY(id_spatiu) REFERENCES Spatiu(id_spatiu);

commit;

INSERT INTO TIP(denumire,caracteristici) values('garaj','Se inchiriaza pentru masin si depozitare!');


SELECT * FROM Agentie;
SELECT * FROM Spatiu;
SELECT * FROM Tip;
SELECT * FROM Oferta;

DELETE FROM Agentie WHERE id_agentie=10;

INSERT INTO AGENTIE(nume,email)  values('BLITZ','blitz@gmail.com');

DECLARE @max int 
SELECT @max = max([id_agentie]) FROM [Agentie]
IF @max IS NULL 
SET @max=0
DBCC CHECKIDENT ('Agentie',RESEED, @max)


DECLARE @max int 
SELECT @max = max([id_spatiu]) FROM [Spatiu]
IF @max IS NULL 
SET @max=0
DBCC CHECKIDENT ('Spatiu',RESEED, @max)


DECLARE @max int 
SELECT @max = max([id_tip]) FROM [Tip]
IF @max IS NULL 
SET @max=0
DBCC CHECKIDENT ('Tip',RESEED, @max)