USE ACTIVO_FIJO;


CREATE TABLE UPDATEUSUARIO (
  IDCambio             INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
  Updated_by           INT                NOT NULL, -- ID del usuario que realiza el cambio
  IDUsuarioActualizado INT                NOT NULL, -- ID del usuario que ha sido modificado
  UsernameA            VARCHAR(10)        NOT NULL,
  UsernameN            VARCHAR(10)        NOT NULL,
  PasswordA            VARCHAR(10)        NOT NULL,
  PasswordN            VARCHAR(10)        NOT NULL,
  NombreA              VARCHAR(100)       NOT NULL,
  NombreN              VARCHAR(100)       NOT NULL,
  DUIA                 CHAR(10)           NOT NULL,
  DUIN                 CHAR(10)           NOT NULL,
  Descripcion          VARCHAR(50),
  FechaCambio          TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);

CREATE TABLE INSERTUSUARIO (
  IDCambio           INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
  Inserted_by        INT                NOT NULL, ---Quien insertó al usuario
  IDUsuarioInsertado INT                NOT NULL,
  UsernameN          VARCHAR(10)        NOT NULL,
  PasswordN          VARCHAR(10)        NOT NULL,
  NombreN            VARCHAR(100)       NOT NULL,
  DUIN               CHAR(10)           NOT NULL,
  Descripcion        VARCHAR(50),
  FechaCambio        TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);

CREATE TABLE DELETEUSUARIO (
  IDCambio           INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
  Deleted_by         INT                NOT NULL, ##Quien borró al usuario
  IDUsuarioEliminado INT                NOT NULL, ##Usuario que ha sido eliminado
  UsernameA          VARCHAR(10)        NOT NULL,
  PasswordA          VARCHAR(10)        NOT NULL,
  NombreA            VARCHAR(100)       NOT NULL,
  DUIA               CHAR(10)           NOT NULL,
  Descripcion        VARCHAR(50),
  FechaCambio        TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);

CREATE TABLE UPDATETIPO (
  IDCambio    INT       AUTO_INCREMENT PRIMARY KEY,
  Updated_by  INT         NOT NULL,
  IDTipo      INT         NOT NULL,
  TIPOA       VARCHAR(50) NOT NULL,
  TIPON       VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(50),
  FechaCambio TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);

CREATE TABLE INSERTTIPO (
  IDCambio    INT       AUTO_INCREMENT PRIMARY KEY,
  Inserted_by INT         NOT NULL,
  IDTipo      INT         NOT NULL,
  TIPON       VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(50),
  FechaCambio TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);

CREATE TABLE DELETETIPO (
  IDCambio    INT       AUTO_INCREMENT PRIMARY KEY,
  Deleted_by  INT         NOT NULL,
  IDTipo      INT         NOT NULL,
  TIPOA       VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(50),
  FechaCambio TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);


CREATE TABLE UPDATEMARCA (
  IDCambio    INT       AUTO_INCREMENT PRIMARY KEY,
  Updated_by  INT         NOT NULL,
  IDMarca     INT         NOT NULL,
  MARCAA      VARCHAR(50) NOT NULL,
  MARCAN      VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(50),
  FechaCambio TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);

CREATE TABLE INSERTMARCA (
  IDCambio    INT       AUTO_INCREMENT PRIMARY KEY,
  Inserted_by INT         NOT NULL,
  IDMarca     INT         NOT NULL,
  MARCAN      VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(50),
  FechaCambio TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);

CREATE TABLE DELETEMARCA (
  IDCambio    INT       AUTO_INCREMENT PRIMARY KEY,
  Deleted_by  INT         NOT NULL,
  IDMarca     INT         NOT NULL,
  MARCAA      VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(50),
  FechaCambio TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  UNIQUE (IDCambio)
);

CREATE TABLE UPDATEADMINISTRAR (
  IDCambio     INT AUTO_INCREMENT          NOT NULL PRIMARY KEY,
  Updated_By   INT                         NOT NULL,
  IDUsuarioA   INT                         NOT NULL,
  IDUsuarioN   INT                         NOT NULL,
  IDBienA      INT                         NOT NULL,
  IDBienN      INT                         NOT NULL,
  FechaCompraA DATE                        NOT NULL,
  FechaCompraN DATE                        NOT NULL,
  CostoA       FLOAT(15, 2) DEFAULT '0.00' NOT NULL,
  CostoN       FLOAT(15, 2) DEFAULT '0.00' NOT NULL,
  CantidadA    INT DEFAULT '0'             NOT NULL,
  CantidadN    INT DEFAULT '0'             NOT NULL,
  Descripcion  VARCHAR(50),
  FechaCambio  TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE INSERTAMINISTRAR (
  IDCambio     INT AUTO_INCREMENT          NOT NULL PRIMARY KEY,
  Inserted_By  INT                         NOT NULL,
  IDUsuarioN   INT                         NOT NULL,
  IDBienN      INT                         NOT NULL,
  FechaCompraN DATE                        NOT NULL,
  CostoN       FLOAT(15, 2) DEFAULT '0.00' NOT NULL,
  CantidadN    INT DEFAULT '0'             NOT NULL,
  Descripcion  VARCHAR(50),
  FechaCambio  TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE DELETEADMINISTRAR (
  IDCambio     INT AUTO_INCREMENT          NOT NULL PRIMARY KEY,
  UDeleted_By  INT                         NOT NULL,
  IDUsuarioA   INT                         NOT NULL,
  IDBienA      INT                         NOT NULL,
  FechaCompraA DATE                        NOT NULL,
  CostoA       FLOAT(15, 2) DEFAULT '0.00' NOT NULL,
  CantidadA    INT DEFAULT '0'             NOT NULL,
  Descripcion  VARCHAR(50),
  FechaCambio  TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

SELECT * FROM USUARIO;