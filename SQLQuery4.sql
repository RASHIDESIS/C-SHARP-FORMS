INSERT INTO [dbo].[Customer] 
(customerID, cusName, cusPassword, cusEmail, cusAccStatus) 
VALUES
(1, 'John Doe', 'password1', 'john.doe@example.com', 'Active'),
(2, 'Jane Smith', 'password2', 'jane.smith@example.com', 'Active'),
(3, 'Robert Brown', 'password3', 'robert.brown@example.com', 'Inactive'),
(4, 'Emily Davis', 'password4', 'emily.davis@example.com', 'Active'),
(5, 'Michael Wilson', 'password5', 'michael.wilson@example.com', 'Inactive'),
(6, 'Sarah Johnson', 'password6', NULL, 'Active'); -- Email is optional, so it can be NULL