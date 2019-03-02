USE ACTIVO_FIJO;

CREATE TRIGGER After_Insert_Marca
    AFTER INSERT
    ON MARCA
    FOR EACH ROW
BEGIN
    DECLARE op_desc VARCHAR(50);
    SET @op_desc := 'Se ha insertado el registro';

    INSERT INTO INSERTMARCA
        (Inserted_by, IDMarca,
         MarcaN,
         Descripcion)
    VALUES
        (666, NEW.IDMarca,
         NEW.NombreMarca,
         @op_desc);
END;

CREATE TRIGGER After_Update_Marca
    AFTER UPDATE
    ON MARCA
    FOR EACH ROW

BEGIN
    DECLARE op_desc VARCHAR(50);

    ##Cambio: Nombre
    IF OLD.NombreMarca != NEW.NombreMarca
    THEN
        SET @op_desc := 'Se ha modificado el nombre';

    ##Cambio: ninguno
    ELSEIF OLD.NombreMarca = NEW.NombreMarca
    THEN
        SET @op_desc := 'No se realizaron cambios';
    END IF;

    INSERT INTO UPDATEMARCA
        (IDMarca, Updated_by,
         MARCAA, MARCAN,
         Descripcion)
    VALUES
        (OLD.IDMarca, 666,
         OLD.NombreMarca, NEW.NombreMarca,
         @op_desc);
END;

CREATE TRIGGER After_Delete_Marca
    AFTER DELETE
    ON MARCA
    FOR EACH ROW

BEGIN
    DECLARE op_desc VARCHAR(50);
    SET @op_desc := 'Se ha eliminado el registro';

    INSERT INTO DELETEMARCA
        (Deleted_by, IDMarca,
         MarcaA,
         Descripcion)
    VALUES
        (666, OLD.IDMarca,
         OLD.NombreMarca,
         @op_desc);
END;

## Tabla Tipo

CREATE TRIGGER After_Insert_Tipo
    AFTER INSERT
    ON TIPO
    FOR EACH ROW

BEGIN
    DECLARE op_desc VARCHAR(50);
    SET @op_desc := 'Se ha insertado el registro';

    INSERT INTO INSERTTIPO
        (Inserted_by, IDTipo,
         TipoN,
         Descripcion)
    VALUES
        (666, NEW.IDTipo,
         NEW.Tipo,
         @op_desc);
END;

CREATE TRIGGER After_Update_Tipo
    AFTER UPDATE
    ON TIPO
    FOR EACH ROW

BEGIN
    DECLARE op_desc VARCHAR(50);
    SET @op_desc := 'Se ha cambiado el nombre del tipo';
    INSERT INTO UPDATETIPO
        (IDTipo, Updated_by,
         TIPOA, TIPON,
         Descripcion)
    VALUES
        (OLD.IDTipo, 666,
         OLD.Tipo, NEW.Tipo,
         @op_desc);
END;

CREATE TRIGGER After_Delete_Tipo
    AFTER DELETE
    ON TIPO
    FOR EACH ROW

BEGIN
    DECLARE op_desc VARCHAR(50);
    SET @op_desc := 'Se ha eliminado el registro';

    INSERT INTO DELETETIPO
        (Deleted_by, IDTipo,
         TipoA,
         Descripcion)
    VALUES
        (1, OLD.IDTipo,
         OLD.Tipo,
         @op_desc);
END;

CREATE TRIGGER After_Insert_Usuario
  AFTER INSERT ON ACTIVO_FIJO.usuario
  FOR EACH ROW
BEGIN
    DECLARE op_desc VARCHAR(50);
    SET @op_desc := 'Se inserto un usuario';
    INSERT INTO INSERTUSUARIO(Inserted_by, IDUsuarioInsertado, UsernameN, PasswordN, NombreN, DUIN, Descripcion)
      VALUES (1, NEW.IDUSUARIO, NEW.USUARIO, NEW.CLAVE, NEW.Nombre, NEW.DUI, @op_desc);
END;

CREATE TRIGGER After_Delete_Usuario
  AFTER DELETE ON ACTIVO_FIJO.usuario
  FOR EACH ROW
BEGIN
    DECLARE op_desc VARCHAR(50);
    SET @op_desc := 'Se Elimino un usuario';
    INSERT INTO DELETEUSUARIO(Deleted_by, IDUsuarioEliminado, UsernameA, PasswordA, NombreA, DUIA, Descripcion)
    VALUES (1, OLD.IDUSUARIO, OLD.Nombre, OLD.CLAVE, OLD.Nombre, OLD.DUI, @op_desc);
END;

CREATE TRIGGER After_Update_Usuario
  AFTER UPDATE ON ACTIVO_FIJO.usuario
  FOR EACH ROW
  BEGIN
    DECLARE op_desc VARCHAR(50);
    ##CAMBIO DE USUARIO
    IF OLD.USUARIO != NEW.USUARIO AND OLD.CLAVE != NEW.CLAVE AND OLD.DUI != NEW.DUI AND OLD.Nombre != NEW.Nombre
      THEN SET @op_desc := 'Se modificaron todos los campos';
    ELSEIF OLD.USUARIO != NEW.USUARIO AND OLD.Clave = NEW.Clave AND OLD.Nombre = NEW.Nombre AND NEW.DUI = OLD.DUI
    THEN
        SET @op_desc := 'Se ha modificado el username';
     ##Cambio: Password
    ELSEIF OLD.USUARIO = NEW.USUARIO AND OLD.Clave != NEW.Clave AND OLD.DUI = NEW.DUI AND OLD.Nombre = NEW.Nombre
    THEN
        SET @op_desc := 'Se ha modificado la contraseña';
        ##Cambio: rol
    ELSEIF OLD.USUARIO = NEW.USUARIO
        AND OLD.Clave = NEW.Clave
        AND OLD.DUI != NEW.DUI
        AND OLD.Nombre = NEW.Nombre
    THEN
        SET @op_desc := 'Se ha modificado el DUI';

    ##Cambio: IDPropietario
    ELSEIF OLD.USUARIO = NEW.USUARIO
        AND OLD.Clave = NEW.Clave
        AND OLD.DUI = NEW.DUI
        AND OLD.Nombre != NEW.Nombre
    THEN
        SET @op_desc := 'Se ha modificado el Nombre';
    end if;
    INSERT INTO UPDATEUSUARIO(Updated_by, IDUsuarioActualizado, UsernameA, UsernameN, PasswordA, PasswordN, NombreA, NombreN, DUIA, DUIN, Descripcion)
    VALUES (1, IDUSUARIO, OLD.USUARIO, NEW.USUARIO, OLD.CLAVE, NEW.CLAVE, OLD.Nombre, NEW.Nombre, OLD.DUI, NEW.DUI, @op_desc);
END;
