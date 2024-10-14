USE [PAdGWebAppMVC.Models.BlogArticleDBContext]
GO

INSERT INTO [dbo].[BlogArticles] ([BA_Titolo],[BA_Categoria],[BA_Descrizione],[BA_URL],[BA_DataOra_Pubblicazione])
     VALUES
           ('Abrogazione della legge 104','TutelaConcepito','Descrizione articolo abrogazione della legge 104','AbrogazioneLegge104.chtml',getdate())
GO


