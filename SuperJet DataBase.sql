--USE master ;

--DROP Database SuperJet

Create Database SuperJet
GO
use SuperJet

create table Employee
(
	Employee_ID				Int			Not Null IDENTITY(1000,1),
	Employee_Name			VarChar(50) Not Null,
	Employee_BirthDate		Date		Not Null,
	Employee_Email			VarChar(255)Not Null,
	Employee_Address		VarChar(40)			, 
	Employee_Password		VarChar(20) Not Null,
	Employee_Salary			Int			Not Null,
	Employee_National_ID	VarChar(14) Not Null,
	Employee_HiredDate		Date		Not Null,
	Gender					VarChar(6)	Not Null,
	Employee_Type			VarChar(50) Not Null,

	Primary key(Employee_ID),
	Unique(Employee_Email),
	Unique(Employee_National_ID),
);

Create Table Buses
(
	Bus_ID					Int			Not Null IDENTITY(1,1),
	Model_Year				Int			Not Null,
	Bus_EngineNumber		VarChar(25) Not Null,
	Bus_Manufacturer		VarChar(20) Not Null,
	Bus_Model				VarChar(20) Not Null, 
	Bus_Redemtion_date		Date		Not Null,
	Bus_Traffic_Department	VarChar(20) Not Null,
	Bus_License				VarChar(10) Not Null,
	Bus_Type				VarChar(10) Not Null,
	Bus_Number_Of_Seats		Int			Not Null,

	Primary key(Bus_ID),
	Unique(Bus_EngineNumber),
	Unique(Bus_License),
);

Create Table BusDriver
(
	Driver_ID			Int			Not Null IDENTITY(1,1),
	Driver_Name			VarChar(50) Not Null,
	Driver_BirthDate	Date				,
	Driver_PhoneNumber	VarChar(11) Not Null,
	Driver_Address		VarChar(40)			, 
	Driver_Salary		Int			Not Null,
	Driver_National_ID	VarChar(14) Not Null,
	Driver_HiredDate	Date		Not Null,
	Gender				VarChar(6)			,
	BloodType			VarChar(6)			,
	Traffic_Department	VarChar(20) Not Null,
	Driving_License		VarChar(20) Not Null,
	Redemption_Date		Date		Not Null,
	D_Bus_ID			Int,
	Penalty             Int,
	Penalty_Date        Date,

	Primary key(Driver_ID)		,
	Unique(Driver_PhoneNumber)	,
	Unique(Driver_National_ID)	,
	Unique(Driving_License)		,
	Unique(D_Bus_ID)			,-- The Bus is Driven by only one driver

	Foreign Key(D_Bus_ID) References Buses(Bus_ID)
	On Delete Set Null
	On Update CASCADE,
);

Create Table Passenger
(
	Passenger_ID			Int			Not Null IDENTITY(1,1),
	Passenger_Name			VarChar(25) Not Null,
	Passenger_PhoneNumber	VarChar(15) Not Null,
	Passenger_Email			VarChar(255)		,
	Passenger_Gender		VarChar(6)	Not Null, 

	Primary key(Passenger_ID)		,
	Unique(Passenger_PhoneNumber)	,
	Unique(Passenger_Email)
);

Create Table PromoCodes
(
	PC_Name					VarChar(25) Not Null,
	Valid					Bit			Not Null,
	Discount				Int			Not Null,
	Employee_ID				Int					,

	Primary Key(PC_Name),

	Foreign Key(Employee_ID) References Employee
	On Delete Set Null
	On Update Cascade
);

Create Table WeeklyTrips
(
	WeeklyTrip_ID			Int			Not Null IDENTITY(1,1),
	Starting_Point			VarChar(20) Not Null,
	Ending_Point			VarChar(20) Not Null,
	WeeklyTrips_DriverID	Int					,
	WeeklyTrip_Day			VarChar(10) Not Null,
	WeeklyTrip_Time			Time		Not Null,
	Price					Int			Not Null,
	Is_Available			Bit			Not Null,
	PromoCode				VarChar(25)			,

	Primary Key(WeeklyTrip_ID)												,
	Unique(Starting_Point, Ending_Point, WeeklyTrip_Day, WeeklyTrip_Time)	,

	Foreign Key(WeeklyTrips_DriverID) References BusDriver
	On Delete Set Null
	On Update Cascade,

	Foreign Key(PromoCode) References PromoCodes
	On Delete Set Null
	On Update Cascade,
);

Create Table BusTrip
(
	Trip_ID				Int IDENTITY(1,1) Not Null,
	Trip_Date			Date,
	Weekly_Trips_ID		Int,

	Primary key(Trip_ID),

	Foreign Key(Weekly_Trips_ID) References WeeklyTrips
	On Delete Set Null	/* In Order not to delete the trips done*/ 
	On Update Cascade,
);

Create Table PassengerTrip 
(	
	PT_Passenger_ID		Int,
	PT_Trip_ID			Int,
	Number_Of_Seats		Int		Not Null,
	Total_Money_Paid    int     not null,	

	Primary Key(PT_Passenger_ID,PT_Trip_ID),

	Foreign Key(PT_Passenger_ID) References Passenger
	On Delete Cascade /*(Restrict) for the upcoming trips, will be deleted*/
	On Update Cascade,

	Foreign Key(PT_Trip_ID) References BusTrip
	On Delete Cascade
	On Update Cascade,
);

Create Table Complaints
(
	Complaint_ID		Int IDENTITY(1,1) Not Null,
	C_Driver_ID			Int,
	C_Trip_ID			Int,
	C_Passenger_ID		Int,
	Complaint			VarChar (5000) Not Null,
	Complaint_Date		Date,

	Primary key(Complaint_ID),

	Foreign Key(C_Driver_ID) References BusDriver
	On Delete Set Null
	On Update Cascade,
	Foreign Key(C_Trip_ID) References BusTrip
	On Delete Cascade
	On Update no action,
	Foreign Key(C_Passenger_ID) References Passenger
	On Delete Cascade
	On Update Cascade,
);

Create Table Packages
(
	Package_Name	VarChar(30) Not Null,
	Duration		Int			Not Null,
	Price			Int			Not Null,
	Is_Available	Bit			Not Null,

	Primary Key(Package_Name)
);

Create Table Rent_Contract
(
	Contract_ID			Int IDENTITY(1,1)	Not Null,
	RentDate			Date				Not Null,
	EndDate				Date				Not Null,
	Price				Int					Not Null,
	Client_Name			VarChar(25)			Not Null,
	Client_NationalID	VarChar(14)			Not Null,
	Client_Address		VarChar(25)			Not Null,
	Client_Gender		VarChar(6)					,
	Rented_BusID		Int							,
	Phone_Number		varChar(11) Not Null		,

	Primary Key(Contract_ID),
	
	Foreign Key(Rented_BusID) References Buses
	On Delete Set Null /*RESTRICT*/ 
	On Update Cascade,
);

Create Table AD_Contract
(
	Contract_ID				Int IDENTITY(1,1)	Not Null,
	StartDate				Date				Not Null,
	EndDate					Date				Not Null,
	Client_Name				VarChar(25)			Not Null,/*owner name*/
	Client_NationalID		VarChar(14)			Not Null,
	Client_Address			VarChar(25)			Not Null,
	Client_Phone			VarChar(11)					,
	Package_ID				VarChar(30)					,
	AD_Bus_ID				Int							,

	Primary Key(Contract_ID),

	Foreign Key(Package_ID) References Packages
	On Delete Set Null 
	On Update Cascade,

	Foreign Key(AD_Bus_ID) References Buses
	On Delete Set NUll /*IDK*/ 
	On Update Cascade,
);
