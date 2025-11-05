create database products;
use products;

create table product(
idproducto int auto_increment primary key,
nombre varchar(30) not null,
codigo varchar(13) not null unique,
descripcion varchar(100) not null,
stock int unsigned not null, 
precio decimal(10,3) not null,
estado ENUM('Activo', 'Inactivo') DEFAULT 'Activo',
fecha_actualizacion DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);


insert into product (nombre, codigo, descripcion, stock, precio, estado) values 
('Paleta', '812999014384', 'Pleta chipileta', 2, 5.50, 'Activo'),
('Cerillos', '75057992', 'Cerillos flama', 14, 10.40, 'Activo'),
('Rimel', '7501734430291', 'Rimel prosa', 21, 35.65, 'Activo'),
('Paracetamol', '7501159590359', 'Pastillas', 12, 20.0, 'Activo'),
('Pintura acrilica', '7501230030117', 'Pintura blanca', 5, 24.5, 1),
('Crema', '8004995633542', 'Body lotion', 18, 212.1, 1),
('Antitranspirante', '75062897', 'Bamboo y aloe vera', 19, 76.8, 1);

select * from product;
TRUNCATE TABLE product;

