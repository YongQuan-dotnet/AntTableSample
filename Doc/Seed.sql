USE [PropertyDB]
GO

INSERT INTO [dbo].[Properties]
           ([Address]
           ,[Suburb]
           ,[Postcode]
           ,[State])
     VALUES
	 	   ('1 Elizabeth Rd', 'Sydney', '2000', 'NSW'),
		   ('2 Elizabeth Rd', 'Sydney', '2000', 'NSW'),
		   ('3 Elizabeth Rd', 'Sydney', '2000', 'NSW'),
		   ('4 Elizabeth Rd', 'Sydney', '2000', 'NSW'),
           ('1 Queen St', 'Rosebery', '2018', 'NSW'),
		   ('2 Queen St', 'Rosebery', '2018', 'NSW'),
		   ('3 Queen St', 'Chatswood', '2067', 'NSW'),
		   ('4 Queen St', 'Chatswood', '2067', 'NSW'),
		   ('1 Ravenswood Ave', 'Carlingford', '2118', 'NSW'),
		   ('2 Ravenswood Ave', 'Carlingford', '2118', 'NSW'),
		   ('3 Ravenswood Ave', 'Epping', '2121', 'NSW'),
		   ('4 Ravenswood Ave', 'Epping', '2121', 'NSW')

GO