create database projetoCS
use database projetoCS

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

insert into meta (nome_meta,descricao_meta,data_meta_fim,status_meta,obs_metas) values 
('Meta Teste', 'Descrição teste de meta','04/08/2024 20:00', 'Ativo', 'Observação teste de meta' )

select * from meta

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

insert into funcionario (nome_funcionario,cpf_funcionario,data_nascimento,genero_funcionario,telefone_funcionario,email_funcionario,status_funcionario,obs_funcionario)
values ('Funcionario teste', '411.023.192-31', '10/02/2000 21:26:05', 'Feminino', '11 - 323342506','funcionarioteste@outlook.com','Teste','Observação teste')

select * from funcionario

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

insert into relatorio (id_funcionario, nome_relatorio, descricao_relatorio, status_relatorio, obs_relatorio) 
values ('1','Relatório teste', 'Foi feito aqui um teste de relatório no servidor SQL', 'Teste', 'Observação teste')

create table estoque
(
 id_estoque int not null identity primary key,
 nome_estoque varchar(30) not null,
 categoria_estoque varchar(35) not null,
 descricao_estoque varchar(255) not null,
 data_vencimento_estoque smalldatetime not null,
 data_estoque_cadastro smalldatetime not null default getdate(),
 status_estoque varchar(30) not null,
 obs_estoque varchar(255) null,
)

insert into estoque(nome_estoque,categoria_estoque,descricao_estoque,data_vencimento_estoque,status_estoque,obs_estoque)
values ('Estoque teste', 'Teste', 'Descrição teste', '09/06/2023 10:00:25', 'Teste', 'Observação teste')

create table fornecedor
(
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
insert into fornecedor (nome_fornecedor,tipoProduto_fornecedor,cnpj_fornecedor,telefone_fornecedor,telefone2_fornecedor,email_fornecedor,status_fornecedor,obs_fornecedor)
values ('Fornecedor teste', 'Tipo teste', '85.032.978/0001-98', '11 187543126', '11 121543512', 'FornecedorTeste@outlook.com', 'Teste','Observação teste')

select * from fornecedor

create table categoria(
id_categoria int not null identity primary key,
nome_categoria varchar(30) not null,
descricao_categoria varchar(255) not null,
status_categoria varchar(30) not null,
obs_categoria varchar(255) null,

)

insert into categoria (nome_categoria, descricao_categoria, status_categoria, obs_categoria) 
values ('Teste categoria', 'Descrição teste', 'Teste', 'Observação teste')

select * from categoria

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

select * from estoque

insert into produto (id_fornecedor, id_categoria, id_estoque, nome_produto, descricao_produto, quantidade_produto, peso_produto, unidadeMedida_produto,
valorcusto_produto, valorvenda_produto, status_produto, obs_produto)
values('1','1','1','Teste produto','Descrição teste para o produto', '20', '10', 'kg','20.000', '50.000', 'Teste', 'Observação teste')

select * from produto


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

insert into venda (id_produto,cpfCliente_Venda,cnpjCliente_Venda,valorTotal_venda,quantidadeProdutos_venda,status_venda,obs_venda)
values ('1','','','100','30','Teste','Observação teste')

select * from venda
