SELECT ClassID
, CLassDate
, StartTime
, EndTime
, ProgramVariety.ProgramVarietyID
, ProgramVariety.Name AS ProgramVarietyName
, Program.ProgramID
, Program.Name AS ProgramName
, Staff.StaffID
, Staff.Name AS StaffName
FROM Class
INNER JOIN Staff ON Staff.StaffID = Class.StaffID
INNER JOIN Program ON Program.ProgramID = Class.ProgramID
INNER JOIN ProgramVariety ON ProgramVariety.ProgramVarietyID = Program.ProgramVarietyID
ORDER BY ClassDate, StartTime;