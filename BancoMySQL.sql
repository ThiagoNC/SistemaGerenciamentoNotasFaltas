CREATE DATABASE IF NOT EXISTS EduSmart;
USE EduSmart;

CREATE TABLE Professor (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    senha_hash VARCHAR(255) NOT NULL
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
    carga_horaria INT NOT NULL
);

CREATE TABLE Matricula (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_aluno INT NOT NULL,
    id_disciplina INT NOT NULL,
    id_professor INT NOT NULL,
    semestre VARCHAR(10) NOT NULL,
    FOREIGN KEY (id_aluno) REFERENCES Aluno(id),
    FOREIGN KEY (id_disciplina) REFERENCES Disciplina(id),
    FOREIGN KEY (id_professor) REFERENCES Professor(id)
);

CREATE TABLE Nota (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_matricula INT NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    valor DECIMAL(5,2) NOT NULL,
    data_lancamento DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_matricula) REFERENCES Matricula(id) ON DELETE CASCADE
);

CREATE TABLE Falta (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_matricula INT NOT NULL,
    data_falta DATE NOT NULL,
    quantidade INT DEFAULT 1,
    FOREIGN KEY (id_matricula) REFERENCES Matricula(id) ON DELETE CASCADE
);

CREATE TABLE Alerta_Risco (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_matricula INT NOT NULL,
    nivel_risco ENUM('Baixo', 'Medio', 'Alto') NOT NULL,
    justificativa_ia TEXT NOT NULL,
    data_analise DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_matricula) REFERENCES Matricula(id) ON DELETE CASCADE
);