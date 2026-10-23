CREATE DATABASE IF NOT EXISTS EduSmart;
USE EduSmart;

CREATE TABLE Professor (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    senhaHash VARCHAR(255) NOT NULL
);

CREATE TABLE Aluno (
    id INT AUTO_INCREMENT PRIMARY KEY,
    ra VARCHAR(20) UNIQUE NOT NULL,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Disciplina (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cargaHoraria INT NOT NULL
);

CREATE TABLE Matricula (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idAluno INT NOT NULL,
    idDisciplina INT NOT NULL,
    idProfessor INT NOT NULL,
    semestre VARCHAR(10) NOT NULL,
    FOREIGN KEY (idAluno) REFERENCES Aluno(id),
    FOREIGN KEY (idDisciplina) REFERENCES Disciplina(id),
    FOREIGN KEY (idProfessor) REFERENCES Professor(id)
);

CREATE TABLE Nota (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idMatricula INT NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    valor DECIMAL(5,2) NOT NULL,
    dataLancamento DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (idMatricula) REFERENCES Matricula(id) ON DELETE CASCADE
);

CREATE TABLE Falta (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idMatricula INT NOT NULL,
    dataFalta DATE NOT NULL,
    quantidade INT DEFAULT 1,
    FOREIGN KEY (idMatricula) REFERENCES Matricula(id) ON DELETE CASCADE
);

CREATE TABLE AlertaRisco (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idMatricula INT NOT NULL,
    nivelRisco ENUM('Baixo', 'Medio', 'Alto') NOT NULL,
    justificativaIa TEXT NOT NULL,
    dataAnalise DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (idMatricula) REFERENCES Matricula(id) ON DELETE CASCADE
);