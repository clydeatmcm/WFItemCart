CREATE TABLE Items (
    ItemId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    ImagePath NVARCHAR(255) NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    Category NVARCHAR(50) NOT NULL
);

INSERT INTO Items (Name, ImagePath, Price, Category) VALUES 
('Portable Vacuum', 'portable_vacuum.png', 19.99, 'Category A'),
('Study Lamp', 'study_lamp.png', 29.99, 'Category A'),
('Xbox', 'xbox.png', 9.99, 'Category B');