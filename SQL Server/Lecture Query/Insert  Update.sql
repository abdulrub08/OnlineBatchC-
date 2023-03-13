--How To Insert The Record
Select * from FloorInfo
Select * from RoomInfo
Select * from BedInfo order by ID

INsert into BedInfo(Name,IsActive,FloorID,RoomID)
			 Values('B7',0,3,6)

INsert into BedInfoTest(PID,Name,IsActive,RoomID,FloorID)
			 Values(1,'B7',0,6,3)

Select * from BedInfoTest

INsert into BedInfo Values(3,6,'B6','TestData',0)


Update BedInfo set Name='B9' where ID=6
Update BedInfo set Name='B10' where ID=7
Update BedInfo set Name='B11' where ID=8

