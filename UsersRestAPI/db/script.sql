create table permisos(
    id_permiso int not null auto_increment,
    nombre varchar(15),
    descripcion varchar (30),
    primary key (id_permiso)
);

create table roles(
    id_rol int not null auto_increment,
    nombre varchar(15),
    descripcion varchar (30),
    primary key (id_rol)
);

create table roles_permissos(
    id_rol int not null,
    id_permiso int not null,
    FOREIGN KEY (id_rol) REFERENCES roles(id_rol),
    FOREIGN KEY (id_permiso) REFERENCES permisos(id_permiso)
);

create table usuarios(
    id_usuario int not null primary key,
    id_rol int not null,
    nombre varchar(15),
    apellido varchar(20),
    telefono varchar(15),
    foto varchar(200),
    FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);

ENGINE=InnoDB