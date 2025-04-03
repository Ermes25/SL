
//--Crear la base de datos
//CREATE DATABASE ListaDeCompras;
//USE ListaDeCompras;

//--Tabla de Categorías
//CREATE TABLE Categorias (
//    idCategoria INT AUTO_INCREMENT PRIMARY KEY,
//    Nombre VARCHAR(100) NOT NULL,
//    Activo BOOLEAN DEFAULT TRUE
//);

//--Tabla de Artículos
//CREATE TABLE Articulos (
//    idArticulo INT AUTO_INCREMENT PRIMARY KEY,
//    NombreArticulo VARCHAR(100) NOT NULL,
//    Cantidad INT NOT NULL,
//    Precio DECIMAL(10, 2) NOT NULL,
//    idCategoria INT,
//    Activo BOOLEAN DEFAULT TRUE,
//    FechaCreacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
//    FOREIGN KEY (idCategoria) REFERENCES Categorias(idCategoria) ON DELETE SET NULL
//);

//--Crear la Vista vControlACs
//CREATE VIEW vControlACs AS
//SELECT 
//    c.idCategoria,
//    c.Nombre AS Categoria,
//    SUM(a.Cantidad) AS TotalCantidad,
//    SUM(a.Precio * a.Cantidad) AS TotalPrecio
//FROM Categorias c
//LEFT JOIN Articulos a ON c.idCategoria = a.idCategoria
//WHERE a.Activo = TRUE
//GROUP BY c.idCategoria, c.Nombre;

//--Insertar categorías de ejemplo
//INSERT INTO Categorias (Nombre) VALUES ('Frutas');
//INSERT INTO Categorias (Nombre) VALUES ('Lácteos');
//INSERT INTO Categorias (Nombre, Activo) VALUES ('Panadería', FALSE);

//--Insertar artículos de ejemplo
//INSERT INTO Articulos (NombreArticulo, Cantidad, Precio, idCategoria) VALUES ('Manzanas', 5, 2.50, 1);
//INSERT INTO Articulos (NombreArticulo, Cantidad, Precio, idCategoria, Activo) VALUES ('Leche entera', 2, 1.20, 2, FALSE);
//INSERT INTO Articulos (NombreArticulo, Cantidad, Precio, idCategoria) VALUES ('Pan integral', 1, 0.80, 3);
