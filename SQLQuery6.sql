INSERT INTO [dbo].[Receptionist] 
(receptionistID, recepPassword, recepAccountStatus, recepEmail, recepName) 
VALUES
(1, 'recept123', 'Active', 'emma.jones@example.com', 'Emma Jones'),
(2, 'recept234', 'Active', 'lucas.smith@example.com', 'Lucas Smith'),
(3, 'recept345', 'Inactive', 'mia.brown@example.com', 'Mia Brown'),
(4, 'recept456', 'Active', 'oliver.james@example.com', 'Oliver James'),
(5, 'recept567', 'Active', NULL, 'Ava Taylor'), -- Email is optional, so it can be NULL
(6, 'recept678', 'Inactive', 'sophia.green@example.com', 'Sophia Green');