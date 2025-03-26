Create database senac;

use senac;

CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;

insert into usuario (
nome, 
email, 
senha) 
values (
'Alex',
'Alex@gmail.com',
'Senha@123'
);

insert into usuario (nome, email, senha)
 values
 ('mamamam','aaaa@gmail.com','Senha@123'),
 ('Albert Einstein','EUSABO@gmail.com',' e = mc'),
 ('a','a@gmail.com','Senha@aaa');