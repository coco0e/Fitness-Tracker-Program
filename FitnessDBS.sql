Create Table Users
(
UserID int not null IDENTITY(1,1) Primary key,
FirstName varchar(30),
LastName varchar(30),
UserName varchar(30),
Password varchar(30), 
Email varchar(30),
DOB varchar (30),
Gender varchar (30),
Phone_Number varchar (30),
Address varchar (30),
Weight int,
Height int,
)

Create Table Goals
(
GoalID int not null IDENTITY (1,1) Primary key,
UserID int,
StartDate date,
EndDate date, 
TotalCalories int,
Status varchar(30),
Foreign key (UserID) References Users(UserID)
)

Create Table Activity
(
ActivityID int not null IDENTITY (1,1) Primary key,
ActivityName varchar (30),
Metric1 varchar (30),
Metric2 varchar (30),
Metric3 varchar (30),
Description text
)

insert into Activity (ActivityName,Metric1,Metric2,Metric3)
values ('Walking', 'Steps', 'Distance', 'Time taken')

insert into Activity (ActivityName,Metric1,Metric2,Metric3)
values ('Swimming', 'Number of laps', 'Average heart rate ', 'time taken')

Create Table ApplyActivity 
(
  ApplyActivityID  varchar (20) not null Primary Key,
  ApplyDate Date,
  TotalActivity int,
  TotalCalories int,
  UserID int,
  ApplyStatus varchar (50),
  Foreign key (UserID) references Users(UserID)
)

Create Table ApplyActivityDetail
(
ApplyActivityID varchar (20),
ActivityID int,
AppMetric1 int,
AppMetric2 int,
AppMetric3 int,
UnitCalories int,
Foreign key (ApplyActivityID) references ApplyActivity(ApplyActivityID),
Foreign key (ActivityID) references Activity(ActivityID)
)
Drop table ApplyActivityDetail
Drop table ApplyActivity

Delete from Activity

Select*from Users

Select *from Activity