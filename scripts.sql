-- Creación de tablas
CREATE TABLE Jugadores (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Nivel INT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE()
);

CREATE TABLE Bloques (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Tipo NVARCHAR(50) NOT NULL,
    Rareza NVARCHAR(20) NOT NULL
);

CREATE TABLE Inventario (
    Id INT PRIMARY KEY IDENTITY(1,1),
    JugadorId INT NOT NULL,
    BloqueId INT NOT NULL,
    Cantidad INT DEFAULT 1,
    FOREIGN KEY (JugadorId) REFERENCES Jugadores(Id),
    FOREIGN KEY (BloqueId) REFERENCES Bloques(Id)
);

-- Insertar 10 jugadores
INSERT INTO Jugadores (Nombre, Nivel) VALUES
('Steve, Nivel:15'),
('Alex, Nivel:12'),
('Notch, Nivel:99'),
('Herobrine, Nivel:100'),
('DiamondGamer, Nivel:45'),
('RedstoneMaster, Nivel:32'),
('CreeperHunter, Nivel:28'),
('EndermanSlayer, Nivel:60'),
('NetherExplorer, Nivel:38'),
('Technoblade, Nivel:70');

-- Insertar 10 bloques
INSERT INTO Bloques (Nombre, Tipo, Rareza) VALUES
('Madera de roble', 'Madera', 'Común'),
('Piedra', 'Mineral', 'Común'),
('Hierro', 'Mineral', 'Común'),
('Oro', 'Mineral', 'Raro'),
('Diamante', 'Mineral', 'Épico'),
('Esmeralda', 'Mineral', 'Épico'),
('Redstone', 'Mineral', 'Raro'),
('Lapislázuli', 'Mineral', 'Raro'),
('Obsidiana', 'Mineral', 'Raro'),
('Bloque de netherita', 'Mineral', 'Épico');

-- Insertar 10 registros de inventario
INSERT INTO Inventario (JugadorId, BloqueId, Cantidad) VALUES
(1, 1, 64),  -- Steve tiene 64 bloques de madera
(2, 3, 32),  -- Technoblade tiene 32 bloques de hierro
(3, 2, 128), -- Alex tiene 128 bloques de piedra
(4, 5, 5),   -- Notch tiene 5 diamantes
(5, 10, 1),  -- Herobrine tiene 1 bloque de netherita
(6, 5, 12),  -- DiamondGamer tiene 12 diamantes
(7, 7, 45),  -- RedstoneMaster tiene 45 redstone
(8, 4, 8),   -- CreeperHunter tiene 8 bloques de oro
(9, 6, 3),   -- EndermanSlayer tiene 3 esmeraldas
(10, 9, 14);  -- NetherExplorer  tiene 14 obsidianas