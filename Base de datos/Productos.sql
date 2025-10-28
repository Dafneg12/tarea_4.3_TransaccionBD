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

INSERT INTO product (nombre, codigo, descripcion, stock, precio, estado)
VALUES 
('Camiseta deportiva', 'ABC1234567890', 'Camiseta de algodón color azul', 50, 249.990, 'Activo');

insert into product (nombre, codigo, descripcion, stock, precio, estado) values 
('Papas', '126048611128', 'Papas fritas', 21, 14.12, 'Activo');

select * from product;

