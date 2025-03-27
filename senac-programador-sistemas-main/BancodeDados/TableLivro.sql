use senac;
CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    genero VARCHAR(30) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    editora VARCHAR(50) NOT NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    autor VARCHAR(100) NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10 , 2 ) NULL
);

drop table livro;

insert into livro
( titulo, genero, data_publicacao,editora,isbn,autor,numero_paginas,preco) 
values ('A lenda do macaco de quinze centímetros e meio','Terror','1957-11-09 00:00::00','Abril','978-0-06-112008-4','Monteiro Lobatto',969,120.99),
('16 toneladas: Adaptação novel','Drama','1989-11-09 00:00::00','Globo','978-1-4028-9462-6','Kanye West',1000,190.99),
('50 tons de XJ','Romance','2023-11-09 00:00::00','Abril','978-0-14-303841-2','Gordão da XJ',597,15.99);

SELECT 
    *
FROM
    livro;