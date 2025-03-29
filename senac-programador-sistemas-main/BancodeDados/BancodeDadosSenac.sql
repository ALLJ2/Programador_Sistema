/*Criar banco de dados*/
create database senac;
 
 use senac; 
 
/*Cria a tabela autor*/
CREATE TABLE autor (
    id INT PRIMARY KEY AUTO_INCREMENT, 
    nome VARCHAR(100) NOT NULL, 
    documento VARCHAR(11) UNIQUE NOT NULL
);

/*Cria a tabela Genero*/
CREATE TABLE genero (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL
);

/*Cria a tabela Editora */
CREATE TABLE editora (
    id INT PRIMARY KEY AUTO_INCREMENT, 
    nome VARCHAR(100) NOT NULL, 
    documento VARCHAR(100) UNIQUE NOT NULL
);

/* Inserir dados na tabela de autor*/
INSERT INTO autor (
nome,autor,documento
) VALUES 
('rafael sousa', '04954132088'),
('mark manson', '09978898026'),
('monteiro lobatto', '35505614078'),
('kanye west', '86244487001'),
('larissa matos', '45090006008'),
('marildo', '83877450067'),
('daniela machado', '35291557052'),
('j. k. rowling', '83505744026'),
('richard russell riordan jr.', '85744402055'),
('tony stark', '52701783038'),
('felipe oliveira', '74429432090'),
('thm', '63205511000'),
('j.r.r. tolkien', '21285902050'),
('george orwell', '17170015056'),
('guilherme diniz', '91780337051'),
('andré luiz', '83861448076'),
('ray bradbury', '47257489009');

/*Verificar se os dados foram inseridos na tabela autor*/
select * from autor;

/*
Realizando insert de editora
*/
INSERT INTO editora ( nome, documento)
VALUES
('intrínseca', '21306675000133'),
('abril', '87067440000144'),
('globo', '03708536000154'),
('panini', '22455174000181'),
('rocco ltda.', '41500632000100'),
('darkside', '80731635000106'),
('marvel', '49420531000122'),
('harpercollins', '36780957000145'),
('companhia das letras', '20413077000109'),
('senac', '82535051000182'),
('biblioteca azul', '97045992000105');

/*Verificar se os dados foram inseridos na tabela editora*/
select * from editora;

/*
Realizando insert de genero de livros
*/
INSERT INTO genero (nome)
VALUES
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');

/*Verificar se os dados foram inseridos na tabela genero*/
select * from genero;

/*Cria a tabela livro e os relacionamentos */
CREATE TABLE livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10, 2) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    id_genero INT NOT NULL,
    id_editora INT NOT NULL,
    id_autor INT NOT NULL,
    FOREIGN KEY (id_genero) REFERENCES genero (id),
    FOREIGN KEY (id_editora) REFERENCES editora (id),
    FOREIGN KEY (id_autor) REFERENCES autor (id)  -- Corrigido para referenciar a tabela autor
);

/*Fazendo insert de dados em tabela livro*/
INSERT INTO livro (
    titulo, data_publicacao, preco, numero_paginas, isbn, id_genero, id_editora, id_autor
) VALUES 
    ('titulo do meu livro', '1991-08-31 22:38:48', 129.99, NULL, '978-3-16-148410-0', 1, 1, 1),
    ('titulo do meu livro 2', '1994-08-31', 87.99, NULL, '978-3-16-148410-1', 1, 1, 1),
    ('titulo do meu livro 3', '1998-08-31', 209.00, 93, '978-3-16-148410-2', 1, 1, 1),
    ('A Sutil Arte de Ligar o Foda-se', '2017-11-06', 45.00, 224, '855-1-004336-0', 2, 1, 2),
    ('A lenda do macaco de quinze centímetros e meio', '1957-11-09 00:00:00', 120.99, 969, '978-0-06-112008-4', 3, 2, 3),
    ('16 toneladas: Adaptação novel', '1989-11-09 00:00:00', 190.99, 1000, '978-1-4028-9462-6', 4, 3, 4),
    ('My book', '2024-06-07 19:30:04', 140.99, NULL, '04-16-500045-4', 4, 1, 5),
    ('Jornalist', '2015-06-25', 29.00, 105, '125165651652', 5, 4, 6),
    ('o diario da perda', '2024-08-10', 99.99, NULL, '856-4-26-457862-2', 4, 1, 7),
    ('vida de cao - a historia de 3 cachorros', '2025-01-23', 45.99, NULL, '764-1-83-514681-6', 6, 1, 7),
    ('Harry Potter e a Pedra Filosofal', '1997-06-26', 40.00, 264, '978-0-43-955493-0', 7, 5, 8),
    ('Percy Jackson e os Olimpianos', '2005-07-01 12:05:45', 299.50, 245, '456-4-82-124856-3', 7, 6, 9),
    ('Homem de Ferro', '1978-05-30 18:02:25', 125.90, NULL, '978-3-16-148491', 8, 7, 10),
    ('criador de progama', '2005-12-25 08:03:06', 0.00, NULL, '666-666', 1, 1, 11),
    ('As aventuras de π', '1999-04-25', 500.99, 1100, '666-9-24-420069-0', 4, 1, 12),
    ('O Senhor dos Anéis', '1954-07-29', 89.90, 1178, '978-0-261-10236-2', 7, 8, 13),
    ('1984', '1949-06-08', 45.50, 328, '978-85-359-0277-2', 9, 9, 14),
    ('Fogo na Caixa Dagua Edição de Colecionador', '2025-03-26 19:28:55', 420.69, 24, '666-9-24-420069-0', 3, 1, 15),
    ('Titulo 64DD', '1999-11-13', 129.99, NULL, '666-9-16-420069-0', 9, 10, 16),
    ('Fahrenheit 451', '2020-10-19', 69.90, 272, '978-6558300151', 10, 11, 17);
    
    
/*
Adcionando cláusula para juntar os conteudos de forma custosa e obsoleta      
    /*Selecionando todos os registros de todas as tabelas
    SELECT 
    livro.id,  -- Seleciona o identificador único do livro
    livro.titulo,  -- Seleciona o título do livro
    livro.data_publicacao,  -- Seleciona a data de publicação do livro
    livro.numero_paginas,  -- Seleciona o número de páginas do livro
    livro.preco,  -- Seleciona o preço do livro
    livro.isbn,  -- Seleciona o ISBN do livro
    genero.nome AS genero,  -- Seleciona o nome do gênero e renomeia a coluna como 'genero'
    editora.nome AS editora,  -- Seleciona o nome da editora e renomeia a coluna como 'editora'
    autor.nome AS autor  -- Seleciona o nome do autor e renomeia a coluna como 'autor'
FROM
    livro,  -- A tabela principal de onde os dados serão extraídos
    genero,  -- A tabela de gêneros
    editora,  -- A tabela de editoras
    autor  -- A tabela de autores
 WHERE -- Condição where
    livro.id_genero = genero.id  -- Junta a tabela 'livro' com 'genero' baseado no ID do gênero
    AND livro.id_editora = editora.id  -- Junta a tabela 'livro' com 'editora' baseado no ID da editora
    AND livro.id_autor = autor.id;  -- Junta a tabela 'livro' com 'autor' baseado no ID da editora   
    */
    
    /* Conectando com relacionamentos que se intersecionam para melhor desenpemho*/
    SELECT 
    livro.id,  -- Seleciona o identificador único do livro
    livro.titulo,  -- Seleciona o título do livro
    livro.data_publicacao,  -- Seleciona a data de publicação do livro
    livro.numero_paginas,  -- Seleciona o número de páginas do livro
    livro.preco,  -- Seleciona o preço do livro
    livro.isbn,  -- Seleciona o ISBN do livro
    genero.nome AS genero,  -- Seleciona o nome do gênero e renomeia a coluna como 'genero'
    editora.nome AS editora,  -- Seleciona o nome da editora e renomeia a coluna como 'editora'
    autor.nome AS autor  -- Seleciona o nome do autor e renomeia a coluna como 'autor'
FROM
    livro  -- A tabela principal de onde os dados serão extraídos
    INNER JOIN genero ON livro.id_genero = genero.id  -- Junta a tabela 'livro' com 'genero' baseado no ID do gênero
    INNER JOIN editora ON livro.id_editora = editora.id  -- Junta a tabela 'livro' com 'editora' baseado no ID da editora
    INNER JOIN autor ON livro.id_autor = autor.id;  -- Junta a tabela 'livro' com 'autor' baseado no ID do autor
    
    
    /*Para apagar registros de uma tabela*/
    -- Delete from "tabela"
    -- where "Expecificação de cláusula"
    
    
    /*Para apagar uma tabela pra sempre */
    -- Drop "tabela"
   -- where "Expecificação de cláusula"
   