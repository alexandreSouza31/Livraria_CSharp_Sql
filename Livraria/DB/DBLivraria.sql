-- BUSCAR BANCOS EXISTENTES
SELECT NAME
FROM MASTER.sys.databases
ORDER BY NAME DESC;

-- EXCLUIR BANCO
DROP DATABASE IF EXISTS db_livraria;

-- EXCLUIR BANCO EM USO
USE MASTER
GO
ALTER DATABASE db_livraria
SET SINGLE_USER WITH ROLLBACK IMMEDIATE
DROP DATABASE IF EXISTS db_livraria;

-- CRIAR BANCO
CREATE DATABASE db_livraria;
GO

-- USAR BANCO CRIADO
USE db_livraria;
GO

-- CRIAÇÃO DE TABELAS
CREATE TABLE tbl_funcionario
(
    cd_funcionario INT PRIMARY KEY IDENTITY,
    ds_login VARCHAR(20) NOT NULL,
    ds_senha CHAR(8) NOT NULL,
    nm_funcionario VARCHAR(60) NOT NULL
);
GO

INSERT INTO tbl_funcionario (ds_login, ds_senha, nm_funcionario)
VALUES ('alexandresouza', 'Ac123', 'Alexandre Mariano');
GO

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
GO

CREATE TABLE tbl_telefone 
(
    cd_cliente INT,
    no_telefone CHAR(11),
    PRIMARY KEY(cd_cliente, no_telefone),
    FOREIGN KEY(cd_cliente) REFERENCES tbl_cliente(cd_cliente)
);
GO

ALTER TABLE tbl_funcionario 
ADD ds_status BIT not null DEFAULT(1);
GO