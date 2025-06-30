DROP DATABASE IF EXISTS db_livraria;

CREATE DATABASE db_livraria;

USE db_livraria;

CREATE TABLE tbl_funcionario (
    cd_funcionario INT AUTO_INCREMENT PRIMARY KEY,
    ds_login VARCHAR(20) NOT NULL,
    ds_senha CHAR(8) NOT NULL,
    nm_funcionario VARCHAR(60) NOT NULL,
    ds_status BOOLEAN NOT NULL DEFAULT TRUE
);

INSERT INTO tbl_funcionario (ds_login, ds_senha, nm_funcionario)
VALUES ('alexandresouza', 'Ac123', 'Alexandre Mariano');

CREATE TABLE tbl_cliente (
    cd_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nm_cliente VARCHAR(60) NOT NULL,
    ds_email VARCHAR(60) NOT NULL,
    nr_cpf CHAR(11),
    nr_cnpj CHAR(14),
    ds_logradouro VARCHAR(60) NOT NULL,
    nr_logradouro VARCHAR(5) NOT NULL,
    ds_complemento VARCHAR(20),
    nm_bairro VARCHAR(20) NOT NULL,
    nm_cidade VARCHAR(20) NOT NULL,
    sg_uf CHAR(2) NOT NULL,
    nr_cep CHAR(8) NOT NULL,
    ds_status BOOLEAN NOT NULL DEFAULT TRUE
);

select * from tbl_cliente;

CREATE TABLE tbl_telefone (
    cd_cliente INT,
    no_telefone CHAR(11),
    PRIMARY KEY (cd_cliente, no_telefone),
    FOREIGN KEY (cd_cliente) REFERENCES tbl_cliente(cd_cliente) ON DELETE CASCADE
);