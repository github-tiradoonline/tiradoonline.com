USE InterviewQuestionsAnswers
GO



-- DROP FOREIGN KEYS
IF OBJECT_ID('FK_Answers_Questions_QuestionID') IS NOT NULL
	ALTER TABLE Answers DROP CONSTRAINT FK_Answers_Questions_QuestionID;
GO

IF OBJECT_ID('FK_Questions_Subjects_SubjectID') IS NOT NULL
	ALTER TABLE Questions DROP CONSTRAINT FK_Questions_Subjects_SubjectID;
GO






IF OBJECT_ID('Subjects') IS NOT NULL
	DROP TABLE Subjects;
GO

CREATE TABLE Subjects
(
	SubjectID 		INT IDENTITY(1001, 1) NOT NULL,
	Subject			VARCHAR(100) NOT NULL,
	create_dt		DATETIME DEFAULT GETDATE() NOT NULL
);
GO

ALTER TABLE Subjects ADD CONSTRAINT PK_Subjects PRIMARY KEY (SubjectID);
GO

CREATE UNIQUE INDEX UIDX_Subjects_Subject ON Subjects(Subject);
GO

INSERT INTO Subjects (Subject) VALUES ('T-SQL');
INSERT INTO Subjects (Subject) VALUES ('.NET');
GO

SELECT * FROM Subjects;



IF OBJECT_ID('Questions') IS NOT NULL
	DROP TABLE Questions;
GO

CREATE TABLE Questions
(
	QuestionID 		INT IDENTITY(1001, 1) NOT NULL,
	SubjectID		INT NOT NULL,
	Question		VARCHAR(MAX) NOT NULL,
	create_dt		DATETIME DEFAULT GETDATE() NOT NULL
);
GO

ALTER TABLE Questions ADD CONSTRAINT PK_Questions PRIMARY KEY (QuestionID);
GO

ALTER TABLE Questions ADD CONSTRAINT FK_Questions_Subjects_SubjectID FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID);
GO

INSERT INTO Questions (SubjectID, Question) VALUES (1001, 'What is a composite key?');
GO

CREATE UNIQUE INDEX UIDX_Questions_SubjectID_Question ON Questions(SubjectID) INCLUDE (Question);
GO

SELECT * FROM Questions;
GO


IF OBJECT_ID('Answers') IS NOT NULL
	DROP TABLE Answers;
GO

CREATE TABLE Answers
(
	AnswerID 		INT IDENTITY(1001, 1) NOT NULL,
	QuestionID		INT NOT NULL,
	Answer			VARCHAR(MAX) NOT NULL,
	create_dt		DATETIME DEFAULT GETDATE() NOT NULL
);
GO

ALTER TABLE Answers ADD CONSTRAINT PK_Answers PRIMARY KEY (AnswerID);
GO


ALTER TABLE Answers ADD CONSTRAINT FK_Answers_Questions_QuestionID FOREIGN KEY (QuestionID) REFERENCES Questions(QuestionID);
GO

INSERT INTO Answers (QuestionID, Answer) VALUES (1001, 'A composite key is having 2 primary keys in one table.');
GO

CREATE UNIQUE INDEX UIDX_Answers_AnswerID_Question ON Answers(QuestionID) INCLUDE (Answer);
GO


SELECT * FROM Answers;
GO