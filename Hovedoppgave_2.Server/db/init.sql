-- Opprett database
CREATE DATABASE IF NOT EXISTS `report-db`;
USE `report-db`;

-- Opprett tabell for produkter
CREATE TABLE IF NOT EXISTS Report (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Content VARCHAR(255) NOT NULL,
    CreatedAt DATETIME NOT NULL,
    UpdatedAt DATETIME NOT NULL,
    UserId INT NOT NULL,
    User VARCHAR(255) NOT NULL
);

-- Sett inn testdata
INSERT INTO Report (Title, Content, CreatedAt, UpdatedAt, UserId, User) VALUES
('Test', 'TestTestTest', '2024-05-22 14:30:00', '2024-05-22 15:00:00', 1, 'TestUser');

-- Opprett databasebruker for API
CREATE USER IF NOT EXISTS 'report-api'@'%' IDENTIFIED BY 'securepass';

-- Gi brukeren nødvendige rettigheter
GRANT ALL PRIVILEGES ON `report-db`.* TO 'report-api'@'%';

-- Aktiver endringer
FLUSH PRIVILEGES;
