CREATE TABLE citoyen 
(
	cin varchar(25) NOT NULL PRIMARY KEY,
	nom varchar(50) NOT NULL,
	prenom varchar(50) NOT NULL,
	sexe varchar(50) NOT NULL,
	codecouleur varchar(50) NOT NULL,
	statusC varchar(50) NOT NULL,
	dateDeNaissance DATETIME NOT NULL
);

CREATE TABLE test
(
	idTest INT PRIMARY KEY NOT NULL IDENTITY,
	typeT varchar(50) NOT NULL,
	dateT DATETIME NOT NULL,
	hassymptoms BIT NOT NULL,
	resultat varchar(50) NOT NULL,
	cinC varchar(25) FOREIGN KEY REFERENCES citoyen(cin)
); 
 
CREATE TABLE vaccination
(
	id INT PRIMARY KEY NOT NULL IDENTITY,
	typeV varchar(50) NOT NULL,
	dateV DATETIME NOT NULL,
	cinC varchar(25) FOREIGN KEY REFERENCES citoyen(cin)
);

CREATE TABLE lieux
(
	id INT PRIMARY KEY NOT NULL IDENTITY,
	longitude float NOT NULL,
	latitude float NOT NULL,
	dateL DATETIME NOT NULL,
	cinC varchar(25) FOREIGN KEY REFERENCES citoyen(cin)
);


