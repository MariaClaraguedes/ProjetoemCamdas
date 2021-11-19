CREATE DATABASE db3camadasM; 
USE db3camadasM; 

CREATE TABLE tbl_Entrar
(
	id        INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	email	  VARCHAR(200) NOT NULL,
    senha	  varchar(100) NOT NULL
);

CREATE TABLE tbl_Post
(
	codigo		   INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    titulo		   VARCHAR(30),
    conteudo	   varchar(1000),
	idUser	 	  INT NOT NULL,
	FOREIGN KEY(idUser) REFERENCES tbl_Entrar(id)
);

create table tbl_Comentario
(
	id 				int not null auto_increment primary key,
	comentario 		varchar(1000),
    idPost	 	 	INT NOT NULL,
	FOREIGN KEY(idPost) REFERENCES tbl_Post(codigo)
);
