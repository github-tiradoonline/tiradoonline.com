EXEC sp_attach_db 'InterviewQuestionsAnswers', 'C:\Storage\Projects\tiradoonline.com\tiradoonline.InterviewQuestionsAnswers\Database\InterviewQuestionsAnswers.mdf', 'C:\Storage\Projects\tiradoonline.com\tiradoonline.InterviewQuestionsAnswers\Database\InterviewQuestionsAnswers.ldf'
GO

EXEC sp_addlogin 'InterviewQuestionsAnswers_user', 'InterviewQuestionsAnswers', 'InterviewQuestionsAnswers', @sid=0x07BD11391EDA1C459A16FB2C96E118A5;
GO