CREATE TABLE IF NOT EXISTS comer (
    Fruta VARCHAR(50) NOT NULL,
    Textura VARCHAR(100) NOT NULL,
    Sabor VARCHAR(10) NOT NULL
);

SELECT 
    *
FROM
    comer
WHERE
Fruta like 'Laranja';

insert into comer
(Fruta,
Textura,
Sabor)

values 
('Laranja','Lisa e suculenta','Doce e cítrico'),
('Mirtilo','Lisa e mácia','Doce'),
('Pera','Pastosa','Como uma maçã aquosa'),
('Manga','Lisa e mole','Suculenta e doce'),
('Uva','Mácia','Doce e saborosa');


