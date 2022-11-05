Use lcastro;
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
    Precio_X_Kilo INT NOT NULL,
    IoS SMALLINT NOT NULL
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
    Notas VARCHAR(60) NULL,
    IoS SMALLINT NOT NULL
);

CREATE TABLE if not exists Historial
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
    Notas VARCHAR(60) NULL,
    IoS SMALLINT NOT NULL
);

CREATE TABLE if not exists Siembra
(
	Id_Sector INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	Sector VARCHAR(10) NOT NULL ,
	Plantacion VARCHAR(50) NULL, 
	Estado VARCHAR(30)  NULL,
    Fase INT NULL,
	Inicio DATE NULL,
	Fin DATE NULL,
	Propietario VARCHAR(30) NOT NULL
);

CREATE TABLE if not exists inv
(
	Id_Inv INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	Nombre VARCHAR(50) NOT NULL,
	Cantidad INT NOT NULL,
	Comprador VARCHAR(30) NOT NULL
);

insert into Usuarios(CI,Nombres,Usuario ,Password,Telefono,Email,Tipo_usuario) 
values ('54287596', 'Juan Carlos', 'Juan01', '123','094225538','juan@gmail.com','Admin'),
('43164362', 'Matias Rodriguez', 'Matias02', '123','094225538','matias@gmail.com','Productor'),
('76237232', 'Carla Magna', 'Carla03', '123','094225538','Carla@gmail.com','Cliente');

					
insert into Insumos(Insumo,Precio_X_Unidad,Precio_X_Kilo,IoS) 
values('Trigo','20','250','1'),
('Cebada','20','200','1'),
('Limon','40','400','1'),
('Manzana','45','455','1'),
('Nitrogeno','237','237','0'),
('Fosforo','250','237','0');
