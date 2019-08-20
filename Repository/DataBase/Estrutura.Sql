DROP TABLE IF EXISTS  empresas ,fornecedores

CREATE TABLE empresas(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome_fantasia VARCHAR(100),
	registro_ativo BIT,
	cnpj VARCHAR (40),
	uf VARCHAR (40),
	data_criacao DATETIME2 
);

CREATE TABLE pecas(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	telefone TEXT,
	registro_ativo BIT,
	data_criacao DATETIME2,
	datanascimento DATETIME2,
	cnpj VARCHAR (40),
	cpf VARCHAR (40),
	rg VARCHAR (10),
	id_empresa INT,
	FOREIGN KEY(id_empresa) REFERENCES empresas(id),

);