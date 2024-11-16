INSERT INTO [dbo].[InventoryRequest] 
(requestID, requestStatus, mechanicID, requestDescription, reqTool) 
VALUES
(1, 'Pending', 1, 'Request for new set of wrenches.', 'Wrench Set'),
(2, 'Approved', 2, 'Request for tire changing equipment.', 'Tire Changer'),
(3, 'Denied', 3, 'Request for engine diagnostic tool.', 'Engine Diagnostics Tool'),
(4, 'Pending', 4, 'Request for wheel alignment machine.', 'Alignment Machine'),
(5, 'Approved', 5, 'Request for air compressor maintenance parts.', 'Air Compressor Parts'),
(6, 'Pending', 6, 'Request for new brake fluid tester.', 'Brake Fluid Tester');