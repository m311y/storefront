SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [Description], [LastUpdated], [CategoryId]) VALUES (1, 'Dress',2.99, 'A Dress', NULL, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
