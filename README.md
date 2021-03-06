# Interfata-simpla-de-Login-folosind-EF6

  Proiectul de fata prezinta in mod practic etapele realizarii si utilizarii unui model Entity Framework pentru o aplicatie software (in C#) ce utilizeaza o legatura la o baza de date.

  Modelul de programare centrat pe baza de date, presupune ca baza de date este creata si apoi se genereaza modelul logic ce contine tipurile folosite in logica aplicatiei.
Acest lucru se face folosind mediul de dezvoltare VStudio. 

Baza de date in exemplul nostru Login_Magazin este cea mai simpla cu putinta, continand un singur tabel denumit Users_1.

![](Login_Magazin-dbo.png)
---




Scriptul pentru creearea bazei de date este urmatorul:
```
USE [Login_Magazin]
GO

/****** Object:  Table [Login_Magazin].[Users_1]    Script Date: 01/03/2021 22:00:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Login_Magazin].[Users_1](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [nvarchar](40) NOT NULL,
	[Password_] [nvarchar](40) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) ON [PRIMARY]
GO
```
De asemenea, pentru usurinta introducerii datelor din form-uri in DB a fost creeata o procedura de insert data:

```
USE [Login_Magazin]
GO

/****** Object:  StoredProcedure [Login_Magazin].[uspNewUser_Name]    Script Date: 01/03/2021 22:06:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Login_Magazin].[uspNewUser_Name]  
@User_Name NVARCHAR (40),  
@Password_ NVARCHAR (40),  
@Type INT = 1,
@User_ID INT OUTPUT
AS  
BEGIN  
INSERT INTO [Login_Magazin].[Users_1] ([User_Name], [Password_], [Type])  VALUES (@User_Name, @Password_, @Type);  
SET @User_ID = SCOPE_IDENTITY();  
RETURN @User_ID  
END   
GO
```
In acest moment baza de date este pregatita pentru a fi accesata si incarcata cu date. 

Partea grafica a proiectului include doua form-uri . Primul, formularul de Login, invita la logare cu un nume si o parola existenta:

![](Interfata-simpla-de-Login-folosind-EF6/Properties/frmLogin.jpg)

 sau in lipsa acestora se poate creea un cont nou.
 
![](Interfata-simpla-de-Login-folosind-EF6/Properties/frmNewUser.jpg)




