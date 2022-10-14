CREATE TABLE if not exists Usuarios
(
	Id_User INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	CI VARCHAR(8) NOT NULL,
	Nombres VARCHAR(50) NOT NULL,
	Usuario VARCHAR(50) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Telefono VARCHAR(9) NULL,
	Email VARCHAR(50) NOT NULL,
	Tipo_usuario VARCHAR(50) NULL
);

CREATE TABLE if not exists Insumos
(
	Id_Insumo INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	Insumo VARCHAR(50) NOT NULL,
    Precio_X_Unidad INT NOT NULL,
    Precio_X_Kilo INT NOT NULL
    );

CREATE TABLE if not exists Compras
(
	Id_Compra INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	Nombre VARCHAR(50) NOT NULL,
	Cantidad INT NOT NULL,
	Precio INT NOT NULL,
	Precio_Final INT NOT NULL,
	Fecha_Actual VARCHAR(11) NOT NULL,
	Hora_Actual VARCHAR(9) NOT NULL,
	Comprador VARCHAR(30) NOT NULL,
    Tipo_de_Pago VARCHAR(60) NOT NULL,
    Notas VARCHAR(60) NULL
);
select * from Compras;
insert into Usuarios(CI,Nombres,Usuario ,Password,Telefono,Email,Tipo_usuario) 
values ('54287596', 'Juan Carlos', 'Juan01', '123','094225538','juan@gmail.com','Admin'),
('43164362', 'Matias Rodriguez', 'Matias02', '123','094225538','matias@gmail.com','Productor'),
('76237232', 'Carla Magna', 'Carla03', '123','094225538','Carla@gmail.com','Cliente');

							
insert into Insumos(Insumo,Precio_X_Unidad,Precio_X_Kilo) 
values('Trigo','0','250'),
('Cebada','0','200'),
('Limon','0','400'),
('Naranja','0','450'),
('Manzana','0','455'),
('Papa Rosada','0','300'),
('Zapallo Criollo','0','310');
select Precio_X_Kilo from Insumos where Insumo='Trigo';



					



