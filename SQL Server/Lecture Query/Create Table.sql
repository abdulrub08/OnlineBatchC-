Use HospitalDB

Create Table BedInfoTest1
(
PID int Primary Key,--Primary Key
FloorID int not Null,--Null Not Allowed
RoomID int,--Null Allowed
Name varchar(100),
Ramark varchar(200),
IsActive bit default(0),--With Default Value
CreatedDate DateTime default GetDate(), --With Default Value
Foreign Key(FloorID) References FloorInfo(ID)-- With Foreign Key
)

Select  GetDate()

--Drop table BedInfo

Select B.Name as BranchName,B.Address,B.Location,F.ID,F.Name,F.Ramark from FloorInfo as F
join BranchInfo B on B.ID=F.BrachID

Select * from BedInfo B
Join FloorInfo F on F.ID=B.FloorID
where F.Name='W1' and IsActive=0

--How To Add Column in EXisting Table
Alter table BranchInfo Add City Varchar(30)

--How To Modify Column in Existing Table Column
Alter table BranchInfo Change column City to Country


ALTER TABLE BranchInfo RENAME COLUMN Country TO City;

EXEC sp_rename 'BranchInfo.City', 'Country', 'COLUMN'

--How To Drop Column in Existing Table
ALTER TABLE BranchInfo Drop COLUMN Country

Select * from BranchInfo
