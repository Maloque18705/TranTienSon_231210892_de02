create database TranTienSon_231210892_de02
go

use TranTienSon_231210892_de02
go

CREATE TABLE TtsCatalog (
    ttsId INT IDENTITY(1,1) PRIMARY KEY,
    ttsCateName NVARCHAR(100) NOT NULL,
    ttsCatePrice DECIMAL(18,2) CHECK (ttsCatePrice >= 100 AND ttsCatePrice <= 5000),
    ttsCateQty INT CHECK (ttsCateQty >= 0),
    ttsPicture NVARCHAR(255),
    ttsCateActive BIT DEFAULT 1
);
GO

INSERT INTO TtsCatalog (ttsCateName, ttsCatePrice, ttsCateQty, ttsPicture, ttsCateActive)
VALUES
(N'Sản phẩm A', 250, 10, N'a.jpg', 1),
(N'Sản phẩm B', 1500, 5, N'b.jpg', 1),
(N'Sản phẩm C', 3000, 2, N'c.jpg', 0);
GO