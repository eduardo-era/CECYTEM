create database Horarios;
use Horarios;


CREATE TABLE IF NOT EXISTS Semestre(
  idSemestre INT NOT NULL AUTO_INCREMENT,
  Semestre VARCHAR(20) NOT NULL,
  PRIMARY KEY (idSemestre))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS Turno(
  idTurno INT NOT NULL AUTO_INCREMENT,
  Turno VARCHAR(20),
  PRIMARY KEY (idTurno))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS Especialidad (
  idEspecialidad INT NOT NULL AUTO_INCREMENT,
  Especialidad VARCHAR(100) ,
  PRIMARY KEY (idEspecialidad))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS Salon (
  idSalon INT NOT NULL AUTO_INCREMENT,
  Salon VARCHAR(10) NULL,
  PRIMARY KEY (idSalon))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS Grrupos (
  idGrupo INT NOT NULL AUTO_INCREMENT,
  Grupo VARCHAR(10) NULL,
  PRIMARY KEY (idGrupo))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS Hora (
  idHora INT NOT NULL AUTO_INCREMENT,
  hora varchar(15),
  PRIMARY KEY (idHora))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS Dia (
  idDia INT NOT NULL AUTO_INCREMENT,
  Dia VARCHAR(150) NULL,
  PRIMARY KEY (idDia))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS Materia (
  idMateria INT NOT NULL AUTO_INCREMENT,
  Materia VARCHAR(250) NULL,
  idSemestre INT NOT NULL,
  HorasP VARCHAR(3) NULL,
  HorasT VARCHAR(3) NULL,
  TotalHoras VARCHAR(5) NULL,
  PRIMARY KEY (idMateria),
  FOREIGN KEY (idSemestre)REFERENCES Semestre (idSemestre)
 )
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS Profesor (
  idProfesor INT NOT NULL AUTO_INCREMENT,
  Nombre VARCHAR(45) NOT NULL,
  ApellidoP VARCHAR(50) NOT NULL,
  ApellidoM VARCHAR(50) NOT NULL,
  Genero VARCHAR(10) NULL,
  EstadoCivil varchar(10),
  Curp VARCHAR(20) NOT NULL,
  Telefono VARCHAR(15) NULL,
  Celular VARCHAR(20) NULL,
  Correo VARCHAR (250) NULL,  
  LugarNacimiento VARCHAR(120) NULL,
  FechaNaciemiento varchar(20) NULL,
  RFC VARCHAR(50) NOT NULL,
  Calle VARCHAR(200) NULL,
  CodigoPostal varchar(5) NULL,
  Numero varchar(4) null,
  Colonia VARCHAR(30) NULL,
  Estado VARCHAR(100) NULL,
  Licenciatura VARCHAR(250) NULL,
  CedulaLicenciatura VARCHAR(30) NULL,
  Maestria VARCHAR(250) NULL,
  CedulaMestria VARCHAR(30) NULL,
  Doctorado VARCHAR(250) NULL,
  CedulaDoctorado VARCHAR(30) NULL,
  idMateria INT NOT NULL,
  FOREIGN KEY(idMateria) REFERENCES Materia(idMateria),
  PRIMARY KEY (idProfesor ))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS Profesor_Materia_Hora_Dia (

  idMHD INT NOT NULL auto_increment,
  idProfesor int not null,
  idMateria INT NOT NULL,
  idhora INT NOT NULL,
  idDia INT NOT NULL,

  FOREIGN KEY (idProfesor)REFERENCES Profesor (idProfesor),
  FOREIGN KEY (idMateria)REFERENCES Materia (idMateria),
  FOREIGN KEY (idhora)REFERENCES Hora (idhora),
  FOREIGN KEY (idDia)REFERENCES Dia (idDia),
  PRIMARY KEY (idMHD)
)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HORARIOS`.`Grupo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Grupo (
  idGrupo INT NOT NULL AUTO_INCREMENT,
  Grupo  VARCHAR(20) NULL,
  Turno   VARCHAR(40)  NULL,
  Especialidad VARCHAR(100) NULL,
  Salon VARCHAR(20) NULL,
  Semestre VARCHAR(50) NULL,
  idMAHD int NULL,
  FOREIGN KEY (idMAHD) REFERENCES Profesor_Materia_Hora_Dia (idMHD),
  PRIMARY KEY (idGrupo)
  
  )
ENGINE = InnoDB;

