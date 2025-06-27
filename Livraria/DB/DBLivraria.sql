-- CRIAR BANCO
CREATE DATABASE db_livraria;

-- BUSCAR BANCOS EXISTENTES
SELECT NAME
FROM MASTER.sys.databases
ORDER BY NAME DESC;

-- USAR BANCO CRIADO
USE db_livraria;

-- EXCLUIR BANCO
DROP DATABASE IF EXISTS db_livraria;

-- EXCLUIR BANCO EM USO
USE MASTER
GO
ALTER DATABASE db_livraria
SET SINGLE_USER WITH ROLLBACK IMMEDIATE
DROP DATABASE IF EXISTS db_livraria;

-- CRIAR TABELAS
CREATE TABLE tbl_atendente
(
	cd_atendente INT PRIMARY KEY IDENTITY,
	ds_login VARCHAR(20) NOT NULL,
	ds_senha CHAR(8) NOT NULL,
	nm_atendente VARCHAR(60) NOT NULL
)

-- INSIRA NA TABELA ATENDENTE NOS CAMPOS
INSERT INTO tbl_atendente
(ds_login,ds_senha,nm_atendente)
VALUES('alexandresouza','Ac123','Alexandre Mariano')

SELECT * FROM tbl_atendente

CREATE TABLE tbl_cliente
(
    cd_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nm_cliente VARCHAR(60) NOT NULL,
    ds_email VARCHAR(60) NOT NULL,
    nr_cpf CHAR(11) NULL,
    nr_cnpj CHAR(14) NULL,
    ds_logradouro VARCHAR(60) NOT NULL,
    nr_logradouro VARCHAR(5) NOT NULL,
    ds_complemento VARCHAR(20) NULL,
    nm_bairro VARCHAR(20) NOT NULL,
    nm_cidade VARCHAR(20) NOT NULL,
    sg_uf CHAR(2) NOT NULL,
    nr_cep CHAR(8) NOT NULL
);

 -- EXEC sp_rename 'tbl_cliente.cod_cliente', 'cd_cliente', 'COLUMN';

SELECT * FROM tbl_cliente

CREATE TABLE tbl_telefone 
(
    cd_cliente INT,
    no_telefone CHAR(11)
    PRIMARY KEY(cd_cliente, no_telefone)
    FOREIGN KEY(cd_cliente) REFERENCES tbl_cliente(cd_cliente)
)

SELECT * FROM tbl_telefone