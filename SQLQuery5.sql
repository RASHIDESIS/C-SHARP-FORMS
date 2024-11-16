INSERT INTO [dbo].[Mechanic] 
(mechanicID, mecPassword, mecName, mecEmail) 
VALUES
(1, 'mech12345', 'Tom Parker', 'tom.parker@example.com'),
(2, 'mech23456', 'Linda White', 'linda.white@example.com'),
(3, 'mech34567', 'Gary Brown', 'gary.brown@example.com'),
(4, 'mech45678', 'Alice Green', 'alice.green@example.com'),
(5, 'mech56789', 'Mark Taylor', NULL),  -- Email is optional, so it can be NULL
(206, 'mech67890', 'Nancy Wilson', 'nancy.wilson@example.com');