create database projetoCS

create table meta 
(
id_meta int not null identity primary key,
nome_meta varchar (30) not null ,
descricao_meta varchar(150) not null,
data_metas_inicio  smalldatetime not null default getdate(),
data_meta_fim smalldatetime not null,
status_meta varchar(20) not null,
obs_metas varchar(255) null,
)

create table funcionario
(
id_funcionario int not null identity primary key,
nome_funcionario varchar(30) not null,
cpf_funcionario varchar(15) not null unique,
data_nascimento smalldatetime not null,
genero_funcionario varchar (12) not null,
telefone_funcionario varchar(15) not null,
email_funcionario varchar(100) not null,
status_funcionario varchar(20) not null,
obs_funcionario varchar(255) null,
)

create table relatorio
(
id_relatorio int not null identity primary key,
id_funcionario int not null,
nome_relatorio varchar(30) not null,
descricao_relatorio varchar(255) not null,
data_relatorio smalldatetime not null default getdate(),
status_relatorio varchar(20) not null,
obs_relatorio varchar(255) null,

constraint Fk_id_funcionario_relatorio foreign key(id_funcionario) references funcionario(id_funcionario)
)

create table estoque
(
 id_estoque int not null identity primary key,
 id_funcionario int not null,
 nome_estoque varchar(30) not null,
 categoria_estoque varchar(35) not null,
 descricao_estoque varchar(255) not null,
 data_vencimento_estoque smalldatetime not null,
 data_estoque_cadastro smalldatetime not null default getdate(),
 status_estoque varchar(30) not null,
 obs_estoque varchar(255) null,

 constraint Fk_id_funcionario_estoque foreign key(id_funcionario) references funcionario(id_funcionario)
)

create table fornecedor(
id_fornecedor int not null identity primary key,
nome_fornecedor varchar(30) not null,
tipoProduto_fornecedor varchar(30) not null,
cnpj_fornecedor varchar(20) not null unique,
telefone_fornecedor char(16) not null,
telefone2_fornecedor char(16) null,
email_fornecedor varchar(100) not null unique,
status_fornecedor varchar(30) not null,
obs_fornecedor varchar(255) null

)

create table categoria(
id_categoria int not null identity primary key,
nome_categoria varchar(30) not null,
descricao_categoria varchar(255) not null,
status_categoria varchar(30) not null,
obs_categoria varchar(255) null,

)

create table produto(
id_produto int not null identity primary key,
id_fornecedor int not null,
id_categoria int not null,
id_estoque int not null,
nome_produto varchar(45) not null,
descricao_produto varchar(255) not null,
quantidade_produto int not null,
peso_produto  decimal(10,2) not null,
unidadeMedida_produto char(10) not null,
cadastro_produto smalldatetime not null default getdate(),
valorcusto_produto decimal(10,2) not null,
valorvenda_produto decimal(10,2) not null,
status_produto varchar(30) not null,
obs_produto varchar (255) not null,


constraint Fk_id_fornecedor_produto foreign key(id_fornecedor) references fornecedor(id_fornecedor),
constraint Fk_id_categoria_produto foreign key(id_categoria) references categoria(id_categoria),
constraint Fk_id_estoque_produto foreign key(id_estoque) references estoque(id_estoque)

)

create table venda (
id_venda int not null identity primary key,
id_produto int not null,
cpfCliente_Venda char(15) null,
cnpjCliente_Venda char(20) null,
cadastro_venda smalldatetime not null default getdate(),
valorTotal_venda decimal(10,2) not null,
quantidadeProdutos_venda int not null,
status_venda varchar (30) not null, 
obs_venda varchar (255) not null,

)