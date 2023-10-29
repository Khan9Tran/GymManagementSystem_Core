CREATE DATABASE GymManagerDB;
GO
USE GymManagerDB;


GO
CREATE TABLE Branch(
	[ID] CHAR(6) CONSTRAINT PK_Branch PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(50) NOT NULL
	);
GO

CREATE TABLE Trainer(
	[ID] CHAR(6) CONSTRAINT PK_Trainer PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(50) NOT NULL,
	[PhoneNumber] CHAR(10) NOT NULL UNIQUE CONSTRAINT CHK_TnPhoneNumber CHECK(LEN([PhoneNumber]) = 10),
	[Gender] CHAR(1) NOT NULL CONSTRAINT CHK_TnGender CHECK([Gender] = 'm' OR [Gender] = 'f' OR [Gender] = 'u') CONSTRAINT DF_TnGender DEFAULT('u'),
	[BranchID] CHAR(6) CONSTRAINT FK_Trainer_Branch FOREIGN KEY REFERENCES dbo.Branch(ID),
	);


GO

CREATE TABLE Employee(
	[ID] CHAR(6) CONSTRAINT PK_Employee PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[UserName] VARCHAR(20) NOT NULL UNIQUE,
	[Password] VARCHAR(20) NOT NULL,
	[BranchID] CHAR(6) CONSTRAINT FK_Employee_Branch FOREIGN KEY REFERENCES dbo.Branch(ID),
	[Role] CHAR(1) NOT NULL
	);
GO

CREATE TABLE EquipmentCategory(
	[ID] CHAR(6) CONSTRAINT PK_EquipmentCategory PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Equipment (
	[ID] CHAR(6) CONSTRAINT PK_Equiment PRIMARY KEY,
	[CategoryID] CHAR(6) CONSTRAINT FK_Equiment_EquimentCategory FOREIGN KEY REFERENCES dbo.EquipmentCategory(ID),
	[BranchID] CHAR(6) CONSTRAINT FK_Equiment_Branch FOREIGN KEY REFERENCES dbo.Branch(ID),
	[Name] NVARCHAR(50) NOT NULL,
	[Status] NVARCHAR(50) NULL, 
	[Price] MONEY NOT NULL CONSTRAINT CHK_EqpPrice CHECK([Price] >= 0)
	);
GO

CREATE TABLE MaintenanceData(
	[ID] CHAR(6) CONSTRAINT PK_MaintenanceData PRIMARY KEY,
	[EquipmentID] CHAR(6) CONSTRAINT FK_MaintenanceData_Equipment FOREIGN KEY REFERENCES dbo.Equipment(ID) ON DELETE SET NULL,
	[Date] DATE NOT NULL CONSTRAINT CHK_MaintDataDate CHECK(DATEDIFF(Day, [Date], GETDATE()) >= 0) DEFAULT GETDATE(),
	[Cost] MONEY NOT NULL CONSTRAINT CHK_MaintDataCost CHECK([Cost] >= 0),
	[Description] NTEXT NULL
	);


GO

CREATE TABLE Package(
	[ID] CHAR(6) CONSTRAINT PK_Package PRIMARY KEY,
	[Name] NVARCHAR(100) NOT NULL, 
	[Periods] INT NOT NULL CONSTRAINT CHK_PkgPeriods CHECK ([Periods] > 0), 
	[Price] MONEY NOT NULL CONSTRAINT CHK_PkgPrice CHECK([Price] >= 0), 
	[Description] NTEXT NULL, 
	[NumberOfPTSessions] INT NULL CONSTRAINT CHK_PkgNumberOfPTSessions  CHECK([NumberOfPTSessions] >= 0)
	);

GO
CREATE TABLE MembershipType(
	[ID] CHAR(6) CONSTRAINT PK_MembershipType PRIMARY KEY, 
	[Rate] FLOAT(2) NOT NULL, 
	[Rank] NVARCHAR(50)
	);
GO
CREATE TABLE Member(
	[ID] CHAR(6) CONSTRAINT PK_Member PRIMARY KEY, 
	[MembershipTypeID] CHAR(6) CONSTRAINT FK_Member_MembershipType FOREIGN KEY REFERENCES dbo.MembershipType(ID),
	[Name] NVARCHAR(50) NOT NULL, 
	[Gender] CHAR(1) NOT NULL CONSTRAINT CHK_MemberGender CHECK([Gender] = 'm' OR [Gender] = 'f' OR [Gender] = 'u') CONSTRAINT DF_MemberGender DEFAULT('u'),
	[PhoneNumber] CHAR(10) NOT NULL UNIQUE CONSTRAINT CHK_MemberPhoneNumber CHECK(LEN([PhoneNumber]) = 10), 
	[Address] NVARCHAR(50) NOT NULL,
	[Balance] MONEY NOT NULL CONSTRAINT CHK_MemberBalance CHECK([Balance] >= 0), 
	[PackageID] CHAR(6) CONSTRAINT FK_Member_Package FOREIGN KEY REFERENCES dbo.Package(ID), 
	[EndOfPackageDate] DATE,
	[RemainingTS] INT CONSTRAINT CHK_MemberRemainingTS CHECK(RemainingTS >= 0)
	);
GO

CREATE TABLE WorkOut(
	[ID] CHAR(6) CONSTRAINT PK_WorkOut PRIMARY KEY, 
	[Name] NVARCHAR(50) NOT NULL, 
	[Type] NVARCHAR(50) NOT NULL, 
	[Description] NTEXT NULL, 
	[Duration] INT NOT NULL CONSTRAINT CHK_WorkOutDuration CHECK([Duration] >= 0)
	);
GO

CREATE TABLE WorkOutPlan(
	[ID] CHAR(6) CONSTRAINT PK_WorkOutPlan PRIMARY KEY,
	[MemberID] CHAR(6) CONSTRAINT FK_WorkOutPlan_Member FOREIGN KEY REFERENCES dbo.Member(ID),
	[TrainerID] CHAR(6) CONSTRAINT FK_WorkOutPlan_Trainer FOREIGN KEY REFERENCES dbo.Trainer(ID), 
	[BranchID] CHAR(6) CONSTRAINT FK_WorkOutPlan_Branch FOREIGN KEY REFERENCES dbo.Branch(ID),
	[Time] TIME NOT NULL, 
	[Date] DATE NOT NULL,
	CONSTRAINT CHK_WopDateTime CHECK([TIME] >= '06:00:00' AND [TIME] < '21:00:00' AND  (CAST([Date] AS DATETIME) + CAST([Time] AS DATETIME)) >  DATEADD(minute, 15, GETDATE()))
	);

GO
CREATE TABLE BMI(
	[ID] CHAR(6) CONSTRAINT PK_BMI PRIMARY KEY,
	[MemberID] CHAR(6) CONSTRAINT FK_BMI_Member FOREIGN KEY REFERENCES dbo.Member(ID) ON DELETE CASCADE,
	[Height] INT NOT NULL,
	[Weight] DECIMAL(4, 1) NOT NULL,
	[Date] DATETIME NOT NULL CONSTRAINT CHK_BMIDate CHECK(DATEDIFF(Day, [Date], GETDATE()) >= 0) DEFAULT GETDATE(),
	[Status] NVARCHAR(50),
	CONSTRAINT CHK_BMI CHECK([Height] > 0 AND [Weight] > 0)
	);

GO
CREATE TABLE Payment(
	[ID] CHAR(6) CONSTRAINT PK_Payment PRIMARY KEY, 
	[Date] DATETIME NOT NULL CONSTRAINT CHK_PaymentDate CHECK(DATEDIFF(SECOND, [Date], GETDATE()) >= 0) DEFAULT GETDATE(),  
	[Note] NVARCHAR(50) NULL, 
	[PaymentAmount] MONEY NOT NULL CONSTRAINT CHK_PmtPaymentAmount CHECK([PaymentAmount] >= 0),
	[BranchID] CHAR(6) CONSTRAINT FK_Payment_Branch FOREIGN KEY REFERENCES dbo.Branch(ID) ON DELETE SET NULL,
	[PackageID] CHAR(6) CONSTRAINT FK_Payment_Package FOREIGN KEY REFERENCES dbo.Package(ID) ON DELETE SET NULL, 
	[MemberID] CHAR(6) CONSTRAINT FK_Payment_Member FOREIGN KEY REFERENCES dbo.Member(ID) ON DELETE SET NULL,
	[EmployeeID] CHAR(6) CONSTRAINT FK_Payment_Employee FOREIGN KEY REFERENCES dbo.Employee(ID) ON DELETE SET NULL
	);

GO
CREATE TABLE PlanDetails(
	[WorkOutPlanID] CHAR(6) CONSTRAINT FK_PlanDetails_WorkOutPlan FOREIGN KEY REFERENCES dbo.WorkOutPlan(ID) ON DELETE CASCADE,
	[WorkOutID] CHAR(6) CONSTRAINT FK_PlanDetails_WorkOut FOREIGN KEY REFERENCES  dbo.WorkOut(ID) ON DELETE CASCADE,
	CONSTRAINT PK_PlanDetails PRIMARY KEY(WorkOutPlanID, WorkOutID)
	);

GO
--Xem lịch tập các hội viên 
CREATE VIEW V_MemberWorkOutSchedule AS
SELECT WOP.ID, WOP.MemberID, Member.Name AS MemberName, WOP.TrainerID, Trainer.Name AS TrainerName, WOP.BranchID, Branch.Name AS BranchName, WOP.[Time], WOP.[Date]
FROM dbo.WorkOutPlan WOP
	LEFT JOIN dbo.Member ON WOP.MemberID = Member.ID
	LEFT JOIN dbo.Branch ON WOP.BranchID = Branch.ID
	LEFT JOIN dbo.Trainer ON WOP.TrainerID = Trainer.ID
GO

--Xem lịch tập các hội viên trong ngày
CREATE VIEW V_MemberWorkOutScheduleInDay AS
SELECT WOP.ID, WOP.MemberID, Member.Name AS MemberName, WOP.TrainerID, Trainer.Name AS TrainerName, WOP.BranchID, Branch.Name AS BranchName, WOP.[Time], WOP.[Date]
FROM dbo.WorkOutPlan WOP
	LEFT JOIN dbo.Member ON WOP.MemberID = Member.ID
	LEFT JOIN dbo.Branch ON WOP.BranchID = Branch.ID
	LEFT JOIN dbo.Trainer ON WOP.TrainerID = Trainer.ID
WHERE CONVERT(DATE, wop.Date) = CONVERT(DATE, GETDATE());
GO
--Xem buổi tập sắp tới
CREATE VIEW V_MemberWorkOutScheduleUpcoming AS
SELECT WOP.ID, WOP.MemberID, Member.Name AS MemberName, WOP.TrainerID, Trainer.Name AS TrainerName, WOP.BranchID, Branch.Name AS BranchName, WOP.[Time], WOP.[Date]
FROM dbo.WorkOutPlan WOP
	LEFT JOIN dbo.Member ON WOP.MemberID = Member.ID
	LEFT JOIN dbo.Branch ON WOP.BranchID = Branch.ID
	LEFT JOIN dbo.Trainer ON WOP.TrainerID = Trainer.ID
WHERE CONVERT(DATE, wop.Date) >= CONVERT(DATE, GETDATE());
GO
--View xem các buổi tập đang diễn ra
CREATE VIEW  V_MemberWorkOutScheduleCurrent AS
SELECT WOP.ID, WOP.MemberID, Member.Name AS MemberName, WOP.TrainerID, Trainer.Name AS TrainerName, WOP.BranchID, Branch.Name AS BranchName, WOP.[Time], WOP.[Date]
FROM WorkOutPlan WOP
JOIN (
    SELECT PD.WorkOutPlanID, SUM([Duration]) AS TotalDuration
    FROM WorkOut WO
	JOIN PlanDetails PD ON WO.ID = PD.WorkOutID 
    GROUP BY PD.WorkOutPlanID
)	
	AS WD ON WOP.ID = WD.WorkOutPlanID
	LEFT JOIN Member ON WOP.MemberID = Member.ID 
	LEFT JOIN Trainer ON WOP.TrainerID = Trainer.ID
	LEFT JOIN Branch ON WOP.BranchID = Branch.ID
	WHERE WOP.[Time] <= CONVERT(TIME, GETDATE())
	AND DATEADD(MINUTE, WD.TotalDuration,[Time]) >= CONVERT(TIME, GETDATE()) AND  [Date] = CONVERT(DATE, GETDATE())
GO

--Danh sách thành viên hết hạn gói tập
CREATE VIEW V_ExpiredMembershipList AS
SELECT 
	mb.ID, mb.[Name], EndOfPackageDate, mb.PhoneNumber
FROM 
	dbo.Member mb
WHERE
	mb.EndOfPackageDate < CAST(GETDATE() AS DATE);

GO
-- Xem danh sách các chi nhánh
CREATE VIEW V_BranchList AS
SELECT *
FROM dbo.Branch

GO

-- Xem danh sách các gói tập
CREATE VIEW V_PackageList AS
SELECT *
FROM dbo.Package

GO

-- Xem danh sách các bài tập
CREATE VIEW V_WorkOutList AS
SELECT *
FROM dbo.WorkOut

GO

--Xem danh sách pt
CREATE VIEW V_TrainerList AS
SELECT t.ID, t.Name, t.Address, t.PhoneNumber, t.Gender, b.Name AS Branch, t.BranchID
FROM dbo.Trainer t
	JOIN dbo.Branch b ON t.BranchID = b.ID
GO
--Xem danh sách hội viên
CREATE VIEW V_MemberList AS
SELECT m.[ID], m.[Name], m.[Gender], m.[PhoneNumber], m.[Address], m.[Balance], mt.[rank] AS MemberRank, p.[Name] AS MemberPackage, m.RemainingTS, m.EndOfPackageDate
FROM dbo.Member m
	JOIN dbo.MembershipType mt ON m.MembershipTypeID = mt.ID
	LEFT JOIN dbo.Package p ON m.PackageID = p.ID

GO
CREATE VIEW V_MembershipType AS
SELECT *
FROM dbo.MembershipType


GO

-- Xem danh sách thiết bị hư hỏng
CREATE VIEW V_DamagedEqpList AS
SELECT dbo.Equipment.[ID], dbo.Equipment.[Name], dbo.Equipment.[Status], dbo.Branch.[Name] AS BranchName, dbo.EquipmentCategory.[Name] AS Category
FROM dbo.Equipment JOIN dbo.Branch ON Branch.ID = Equipment.BranchID
				   JOIN dbo.EquipmentCategory ON EquipmentCategory.ID = Equipment.CategoryID
WHERE dbo.Equipment.[Status] = 'unavailable'
Go
	-- Xem danh sách thiết bị còn hoạt động
CREATE VIEW V_AvailableEqpList AS
SELECT dbo.Equipment.[ID], dbo.Equipment.[Name], dbo.Equipment.[Status], dbo.Branch.[Name] AS BranchName, dbo.EquipmentCategory.[Name] AS Category
FROM dbo.Equipment JOIN dbo.Branch ON Branch.ID = Equipment.BranchID
				   JOIN dbo.EquipmentCategory ON EquipmentCategory.ID = Equipment.CategoryID
WHERE dbo.Equipment.[Status] = 'available'
GO
--Xem danh sách thiết bị sửa chữa trong ngày
CREATE VIEW V_MaintDataListInDay AS
SELECT eq.EquipmentID , eq.Description, eq.Cost
FROM dbo.MaintenanceData eq
WHERE CONVERT(date, eq.Date) = CONVERT(DATE, GETDATE());

GO
--Xem danh sách hóa đơn thực hiện trong ngày
CREATE VIEW V_PaymentListInDay AS
SELECT dbo.Payment.[ID], dbo.Member.[ID] AS MemberID, dbo.Member.[Name] AS MemberName, dbo.Package.[Name] AS PackageName,  dbo.Payment.[PaymentAmount],
	   dbo.Branch.[Name] AS BranchName, dbo.Payment.[Date], dbo.Employee.[Name] as [Cashier] 
FROM  dbo.Payment JOIN dbo.Member ON Member.ID = Payment.MemberID
				  JOIN dbo.Package ON Package.ID = Payment.PackageID
				  JOIN dbo.Branch ON Branch.ID = Payment.BranchID
				  JOIN dbo.Employee ON Employee.ID = Payment.EmployeeID
WHERE CAST(dbo.Payment.[Date] AS DATE) = CAST(GETDATE() AS DATE)

GO

--Xem danh sách các thiết bị
CREATE VIEW V_EquipmentList AS
SELECT e.[ID], e.[Name], e.[Status], e.[Price], ec.[Name] AS Category, b.[Name] AS Branch
FROM dbo.Equipment e
	JOIN dbo.Branch b ON e.BranchID = b.ID
	JOIN dbo.EquipmentCategory ec ON e.CategoryID = ec.ID
GO

--Xem danh sách BMI
CREATE VIEW V_BMIList AS
SELECT BMI.ID, BMI.Status, BMI.Weight, BMI.Height, BMI.Date, MemberID,Member.Name, Member.PhoneNumber
FROM BMI JOIN Member ON BMI.MemberID = Member.ID
GO

-- Trigger cập nhật số dư khi hội viên thực hiện thanh toán và tính số tiền khách cần phải trả cập nhật về Payment
CREATE TRIGGER TR_UpdateMemberBalance
ON Payment
	AFTER INSERT AS
BEGIN
	DECLARE @BalanceTmp MONEY 
	DECLARE @Amount MONEY
	SELECT @BalanceTmp = M.Balance, @Amount = I.PaymentAmount FROM Member M JOIN inserted I ON M.ID = I.MemberID  
    UPDATE M
    SET Balance = 
		CASE
			WHEN @Amount >=  @BalanceTmp
			THEN 
				MT.Rate * @Amount
			ELSE 
				@BalanceTmp - @Amount + (MT.Rate *  @Amount) 
		END
    FROM Member M
    INNER JOIN inserted I ON M.ID = I.MemberID
    INNER JOIN MembershipType MT ON M.MembershipTypeID = MT.ID;

	UPDATE P
    SET PaymentAmount = 
		CASE
			WHEN @Amount >=  @BalanceTmp
			THEN 
				@Amount - @BalanceTmp
			ELSE 
				0
		END
    FROM Payment P
    INNER JOIN inserted I ON P.ID = I.ID
END;


GO
--Trigger thêm gói tập/ gia hạn và chỉnh ngày hết hạn gói tập khi hội viên thực hiện thanh toán và chỉnh số buổi tập với PT.
CREATE TRIGGER TR_UpdatePkgOfMember
ON Payment
	AFTER INSERT AS
BEGIN
    UPDATE M
    SET EndOfPackageDate = 
		CASE
			WHEN (M.PackageID = I.PackageID) AND ( CAST(I.[Date] AS DATE)) < M.EndOfPackageDate THEN 
				DATEADD(MONTH, P.Periods,  M.EndOfPackageDate)	
			ELSE
				DATEADD(MONTH, P.Periods, GETDATE())
		END
	, RemainingTS = 
		CASE
		--Khi gia hạn thì giữ lại số buổi tập còn lại với PT cho hội viên ngược lại buổi tập còn lại sẽ được tính theo package
			WHEN (M.PackageID = I.PackageID) AND ( CAST(I.[Date] AS DATE)) < M.EndOfPackageDate THEN 
				ISNULL(M.RemainingTS, 0) + ISNULL(P.NumberOfPTSessions, 0)
			ELSE
				ISNULL(P.NumberOfPTSessions, 0)
		END,
		PackageID = I. PackageID
		
    FROM Member M
    INNER JOIN inserted I ON M.ID = I.MemberID
    INNER JOIN Package P ON I.PackageID = P.ID;
END;
GO


--Trigger thêm membershiptype là 'thành viên' cho hội viên mới
CREATE TRIGGER TR_AssignDefaultMembershipType
ON Member
AFTER INSERT
AS
BEGIN
    -- Kiểm tra hội viên có được đặt mã membership chưa
    IF NOT EXISTS (SELECT 1 FROM inserted WHERE MembershipTypeID IS NOT NULL)
    BEGIN
        -- Gán mặc định cho hội viên mới 'Thành viên'
        UPDATE Member
        SET MembershipTypeID = (
            SELECT ID
            FROM MembershipType
            WHERE Rank = N'Thành viên'
        )
        WHERE ID IN (SELECT ID FROM inserted);
    END
END;
GO
--Trigger đặt tình trạng BMI dựa theo công thức
CREATE TRIGGER TR_BMIStatus
ON dbo.BMI
AFTER INSERT, UPDATE
AS
BEGIN
UPDATE BMI
SET Status = CASE
WHEN (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) / 100),2) < 18.5) THEN N'Gầy'
WHEN (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) / 100),2) >= 18.5) AND (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) / 100),2) < 25) THEN N'Bình thường'
WHEN (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) / 100),2) >= 25) AND (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) / 100),2) < 30) THEN N'Thừa Cân'
WHEN (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) / 100),2) >= 30) AND (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) /100),2) < 35) THEN N'Béo phì cấp độ 1'
WHEN (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) / 100),2) >= 35) AND (B.Weight / POWER((CAST(B.Height AS DECIMAL(6,2)) / 100),2) < 40) THEN N'Béo phì cấp độ 2'
ELSE N'Béo phì cấp độ 3'
END
FROM BMI B
INNER JOIN inserted I ON B.ID = I.ID;
END;

GO


--Trigger kiểm tra gói tập trùng tên
CREATE TRIGGER TR_UniquePackage
ON dbo.Package
AFTER INSERT, UPDATE
AS
BEGIN
	IF EXISTS (
		SELECT *
		FROM inserted i
		WHERE EXISTS (
			SELECT *
			FROM dbo.Package p
			WHERE p.Name = i.Name AND p.ID <> i.ID
		)
	)
	BEGIN
		RAISERROR ('Tên gói tập này đã tồn tại',16,1)
		ROLLBACK;
	END
END
GO

--Trigger thay đổi trạng thái thiết bị khi đã thực hiện bảo trì
CREATE TRIGGER TR_ChangeStEquipment ON dbo.MaintenanceData
FOR INSERT
AS
BEGIN
	UPDATE dbo.Equipment
	SET [Status] = 'available'
	FROM dbo.Equipment eqp
	INNER JOIN inserted i ON eqp.ID = i.ID
END;
GO
--Trigger báo quá số lượng đăng ký cho giờ tập trong khoản trước sau 45 phút (Dung tích chứa 50 member) 
CREATE TRIGGER TR_OverCapacity ON WorkOutPlan
AFTER INSERT, UPDATE 
AS
BEGIN
	IF  50 < (SELECT COUNT(*)
	FROM WorkOutPlan wop
	INNER JOIN inserted i ON wop.[Date] = i.[Date] AND ABS(CAST(DATEDIFF(MINUTE, i.Time, wop.Time) AS INT)) <= 45
)
	BEGIN
		RAISERROR ('Vui lòng chọn giờ khác (Cách 45 phút) vì đã quá số lượng đăng ký trong khoảng thời gian này',16,1)
		ROLLBACK;
	END
END;
GO
--Trigger kiểm tra buổi tập có thời lượng quá 2 tiếng
CREATE TRIGGER TR_OverTimeTraining
ON PlanDetails
AFTER INSERT, UPDATE 
AS
BEGIN

   DECLARE @totalDuration INT

   SELECT @totalDuration = SUM(Duration)
   FROM PlanDetails pd
   JOIN WorkOut wo ON pd.WorkOutID = wo.ID
   JOIN inserted i ON i.WorkOutPlanID = pd.WorkOutPlanID
   IF @totalDuration > 120
   BEGIN
      RAISERROR ('Thời lượng tập quá 2 tiếng',16,1);
	  ROLLBACK;
   END
END


GO



--Trigger Kiểm tra buổi tập đăng ký nằm ngoài ngày hết hạng gói tập
CREATE TRIGGER	TR_ExceededPkgEndDate ON WorkOutPlan
AFTER INSERT, UPDATE
AS 
BEGIN
	IF EXISTS (
		SELECT *
		FROM inserted i
		JOIN Member m 
			ON m.ID = i.MemberID
		WHERE i.[Date] > m.EndOfPackageDate
	)
	BEGIN
		RAISERROR ('Lịch tập nằm ngoài hạn gói tập',16,1)
		ROLLBACK;
	END
END;

GO

-- Kiểm tra liệu member còn số buổi tập với trainer hay không 
CREATE TRIGGER TR_WorkOutPlanHaveTrainer ON dbo.WorkOutPlan
FOR INSERT, UPDATE
AS 
BEGIN

	IF EXISTS (SELECT * FROM inserted, dbo.Member WHERE inserted.TrainerID IS NOT NULL 
						        AND inserted.MemberID=dbo.Member.ID
							AND (Member.RemainingTS IS NULL
						        OR   Member.RemainingTS=0))
	BEGIN
		RAISERROR ('Số buổi tập với Trainer đã hết',16,1)
		ROLLBACK
	END
END
GO

-- Kiểm tra việc đăng ký mới lịch tập với huấn luyện viên có bị trùng lịch không 
CREATE TRIGGER TR_WorkOutPlaConflictChecking ON WorkOutPlan
FOR INSERT, UPDATE 
AS
BEGIN
		IF EXISTS (SELECT * FROM inserted, dbo.WorkOutPlan 
							WHERE (inserted.TrainerID = dbo.WorkOutPlan.TrainerID) 
							AND (inserted.ID != WorkOutPlan.ID)
							AND (inserted.[Date] = dbo.WorkOutPlan.[Date])
							AND ABS(CAST(DATEDIFF(MINUTE, inserted.[Time], WorkOutPlan.[Time]) AS INT)) <= 120)
		BEGIN
				RAISERROR ('Trainer đã có lịch trong khung giờ này',16,1)
				ROLLBACK
		END
		
END


GO

INSERT INTO MembershipType (ID, [Rank], Rate)
VALUES ('000001', N'Thành viên', 0),
       ('000002', N'Đồng', 0.04),
       ('000003', N'Bạc', 0.08),
       ('000004', N'Vàng', 0.12),
	   ('000005', N'Bạch kim', 0.16)

INSERT INTO WorkOut (ID, Name, Type, Description, Duration)
VALUES
    ('WO0001', N'Squat', N'Legs', N'Bài tập gập người giúp phát triển cơ chân và hông.', 10),
    ('WO0002', N'Deadlift', N'Legs', N'Bài tập kéo đạp tập trung vào cơ lưng và cơ chân.', 15),
    ('WO0003', N'Bench Press', N'Chest', N'Bài tập đẩy tạ ngang tập trung vào cơ ngực, vai và cánh tay.', 15),
    ('WO0004', N'Shoulder Press', N'Shoulders', N'Bài tập đẩy tạ vai giúp phát triển cơ vai và cơ tay trên.', 10),
    ('WO0005', N'Barbell Row', N'Back', N'Bài tập kéo tạ ngang tập trung vào cơ lưng và cơ tay.', 12),
    ('WO0006', N'Bicep Curl', N'Arms', N'Bài tập curl tạ cơ bắp cánh tay.', 8),
    ('WO0007', N'Tricep Extension', N'Arms', N'Bài tập nghịch cánh tay.', 12),
    ('WO0008', N'Lunges', N'Legs', N'Bài tập chân trước giúp cải thiện sức mạnh chân và cơ mông.', 15),
    ('WO0009', N'Romanian Deadlift', N'Legs', N'Bài tập kéo đạp chân thẳng tập trung vào cơ lưng và cơ chân.', 15),
    ('WO0010', N'Overhead Press', N'Shoulders', N'Bài tập đẩy tạ từ trên đầu tập trung vào cơ vai và cơ tay trên.', 7),
    ('WO0011', N'Incline Bench Press', N'Chest', N'Bài tập đẩy tạ nghiêng tập trung vào cơ ngực, vai và cánh tay.', 12),
    ('WO0012', N'Barbell Hip Thrust', N'Legs', N'Bài tập đẩy hông bằng tạ giúp phát triển cơ mông và cơ chân.', 15);
GO

INSERT INTO EquipmentCategory (ID, Name)
VALUES
    ('EQC001', N'Máy chạy bộ'),
	('EQC002', N'Máy tập bụng'),
    ('EQC003', N'Xe đạp đứng'),
    ('EQC004', N'Máy tập ngực'),
    ('EQC005', N'Máy tập vai'),
    ('EQC006', N'Máy tập chân'),
	('EQC007', N'Máy tập tay'),
	('EQC008', N'Máy tập lưng/xô'),
	('EQC009', N'Thanh đòn'),
	('EQC010', N'Bánh tạ'),
	('EQC011', N'Ghế tập'),
	('EQC012', N'Thảm'),
	('EQC013', N'Tạ đơn');


-- Kiểm tra lịch tập có huấn luyện viên nhưng bị trùng giờ với lịch của huấn luyện viên đó (insert, update woukloutplan) rollback báo lỗi.
GO
INSERT INTO Branch ([ID], [Name], [Address])
VALUES
	('BR0001', 'Branch 1', '123 Main St'),
	('BR0002', 'Branch 2', '456 Elm St'),
	('BR0003', 'Branch 3', '789 Oak St'),
	('BR0004', 'Branch 4', '321 Pine St'),
	('BR0005', 'Branch 5', '987 Cedar St');

GO
INSERT INTO Trainer ([ID], [Name], [Address], [PhoneNumber], [Gender], [BranchID])
VALUES
	('TR0001', 'Trainer 1', 'Address 1', '1234567890', 'm', 'BR0001'),
	('TR0002', 'Trainer 2', 'Address 2', '2345678901', 'f', 'BR0002'),
	('TR0003', 'Trainer 3', 'Address 3', '3456789012', 'm', 'BR0003'),
	('TR0004', 'Trainer 4', 'Address 4', '4567890123', 'f', 'BR0004'),
	('TR0005', 'Trainer 5', 'Address 5', '5678901234', 'm', 'BR0005'),
	('TR0006', 'Trainer 6', 'Address 6', '6789012345', 'f', 'BR0001'),
	('TR0007', 'Trainer 7', 'Address 7', '7890123456', 'm', 'BR0002'),
	('TR0008', 'Trainer 8', 'Address 8', '8901234567', 'f', 'BR0003'),
	('TR0009', 'Trainer 9', 'Address 9', '9012345678', 'm', 'BR0004'),
	('TR0010', 'Trainer 10', 'Address 10', '0123456789', 'f', 'BR0005');


GO
INSERT INTO Package ([ID], [Name], [Periods], [Price], [Description], [NumberOfPTSessions])
VALUES
	('PK0001', 'Package 1', 3, 100.00, 'Description 1', 5),
	('PK0002', 'Package 2', 6, 200.00, 'Description 2', 10),
	('PK0003', 'Package 3', 12, 300.00, 'Description 3', 15),
	('PK0004', 'Package 4', 1, 50.00, 'Description 4', NULL),
	('PK0005', 'Package 5', 4, 150.00, 'Description 5', 8),
	('PK0006', 'Package 6', 8, 250.00, 'Description 6', NULL),
	('PK0007', 'Package 7', 2, 80.00, 'Description 7', 4),
	('PK0008', 'Package 8', 6, 180.00, 'Description 8', 12),
	('PK0009', 'Package 9', 12, 350.00, 'Description 9', NULL),
	('PK0010', 'Package 10', 3, 120.00, 'Description 10', 6);

GO 
INSERT INTO Member ([ID], [MembershipTypeID], [Name], [Gender], [PhoneNumber], [Address], [Balance], [PackageID], [EndOfPackageDate],RemainingTS)
VALUES
	('MEM011', '000001', 'Member 1', 'm', '1234567890', 'Address 1', 100.00, 'PK0001', '2023-12-01',11),
	('MEM002', '000002', 'Member 2', 'f', '2345678901', 'Address 2', 200.00, 'PK0002', '2023-12-01',0),
	('MEM003', '000003', 'Member 3', 'm', '3456789012', 'Address 3', 300.00, 'PK0003', '2023-12-01',NULL),
	('MEM004', '000001', 'Member 4', 'f', '4567890123', 'Address 4', 400.00, 'PK0004', '2023-12-01',23),
	('MEM005', '000002', 'Member 5', 'm', '5678901234', 'Address 5', 500.00, 'PK0005', '2023-12-01',44),
	('MEM006', '000003', 'Member 6', 'f', '6789012345', 'Address 6', 600.00, 'PK0006', '2023-12-01',0),
	('MEM007', '000001', 'Member 7', 'm', '7890123456', 'Address 7', 700.00, 'PK0007', '2023-12-01',NULL),
	('MEM008', '000002', 'Member 8', 'f', '8901234567', 'Address 8', 800.00, 'PK0008', '2023-12-01',1),
	('MEM009', '000003', 'Member 9', 'm', '9012345678', 'Address 9', 900.00, 'PK0009', '2023-12-01',3),
	('MEM010', '000001', 'Member 10', 'f', '0123456789', 'Address 10', 1000.00, 'PK0010', '2023-12-01',2);

GO 
INSERT INTO WorkOutPlan ([ID], [MemberID], [TrainerID], [BranchID], [Time], [Date])
VALUES

	('WOP002', 'MEM002', 'TR0002', 'BR0002', '09:00:00', '2023-12-01'),
	('WOP003', 'MEM003', 'TR0003', 'BR0003', '10:00:00', '2023-12-01'),
	('WOP004', 'MEM004', 'TR0004', 'BR0004', '11:00:00', '2023-11-01'),
	('WOP005', 'MEM005', 'TR0005', 'BR0005', '12:00:00', '2023-11-01'),
	('WOP006', 'MEM006', 'TR0006', 'BR0001', '13:00:00', '2023-11-01'),
	('WOP007', 'MEM007', 'TR0007', 'BR0002', '14:00:00', '2023-11-07'),
	('WOP008', 'MEM008', 'TR0008', 'BR0003', '15:00:00', '2023-11-08'),
	('WOP009', 'MEM009', 'TR0009', 'BR0004', '16:00:00', '2023-11-09'),
	('WOP010', 'MEM010', 'TR0010', 'BR0005', '17:00:00', '2023-11-10');

GO
-- Testing
INSERT INTO WorkOutPlan ([ID], [MemberID], [TrainerID], [BranchID], [Time], [Date])
VALUES
	('WOP014', 'MEM012', 'TR0001', 'BR0001', '10:00:00', '2023-11-01')

INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP001', 'WO0001')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP001', 'WO0003')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP002', 'WO0005')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP002', 'WO0001')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP003', 'WO0007')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP003', 'WO0009')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP004', 'WO0004')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
   	('WOP005', 'WO0010')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP006', 'WO0006')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP007', 'WO0002')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP007', 'WO0003')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP008', 'WO0005')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP009', 'WO0008')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP010', 'WO0007')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP010', 'WO0006');
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP010', 'WO0003');

GO
---PROCDURE Tìm Member theo phone
GO
CREATE PROCEDURE dbo.PROC_FindMemberByPhoneNumber
    @PhoneNumber CHAR(10)
AS
BEGIN
    SELECT *
    FROM V_MemberList
    WHERE PhoneNumber = @PhoneNumber
END
GO
---Tìm chi nhánh
CREATE PROCEDURE dbo.PROC_FindBranchByContent
	@Content NVARCHAR(50)
AS
BEGIN
	SELECT * 
	FROM V_BranchList
	WHERE Name LIKE '%' + @Content + '%' OR ID = @Content OR Address LIKE '%' + @Content + '%'
END
GO
---Tìm trainer
CREATE PROCEDURE dbo.PROC_FindTrainerByBranchAndContent
	@Content NVARCHAR(50),
	@Branch NVARCHAR(50)
AS
BEGIN
	SELECT * 
	FROM V_TrainerList
	WHERE (Name LIKE '%' + @Content + '%' OR ID = @Content OR Address LIKE '%' + @Content + '%' OR PhoneNumber LIKE '%' + @Content + '%') AND (BranchID = @Branch)
END

GO

--Thêm WorkOutPlan
CREATE PROCEDURE PROC_AddWorkOutPlan
    @ID CHAR(6),
    @MemberID CHAR(6),
    @TrainerID CHAR(6) = NULL,
    @BranchID CHAR(6),
    @Time TIME,
    @Date DATE
AS
BEGIN
	  IF NOT EXISTS
    (
        SELECT *
        FROM WorkOutPlan
        WHERE MemberID = @MemberID
        AND [Date] = @Date
        AND (
            (DATEADD(HOUR, -2, Time) <= @Time AND @Time <= Time)
            OR (Time <= @Time AND @Time <= DATEADD(HOUR, 2, Time))
        )
    )
	BEGIN
		INSERT INTO WorkOutPlan (ID, MemberID, TrainerID, BranchID, Time, Date)
		VALUES (@ID, @MemberID, @TrainerID, @BranchID, @Time, @Date)
	END
	ELSE 
	BEGIN
		RAISERROR ('Hai buổi tập quá gần nhau',16,1);
	END
END

GO
--Thêm Plandetails
CREATE PROCEDURE PROC_AddPlanDetails
    @WorkOutPlanID CHAR(6),
    @WorkOutID CHAR(6)
AS
BEGIN
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- Thêm dòng vào bảng PlanDetails
        INSERT INTO PlanDetails (WorkOutPlanID, WorkOutID)
        VALUES (@WorkOutPlanID, @WorkOutID);
        
        -- Nếu không có lỗi, commit giao dịch
        COMMIT TRANSACTION;
        
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi, rollback giao dịch và xóa dòng tương ứng trong bảng WorkOutPlan
        ROLLBACK TRANSACTION;
        
        DELETE FROM WorkOutPlan
        WHERE ID = @WorkOutPlanID;
        
        RAISERROR ( 'Buổi tập có thời lượng quá 2 tiếng',16,1);
    END CATCH;
END
GO

--Proc tìm kiếm trogn lịch tập
CREATE PROCEDURE PROC_FindWorkOutPlan
	@FilterType INT,
	@Content NVARCHAR(50)
AS
BEGIN
	IF (@FilterType = 0)
			SELECT * FROM V_MemberWorkOutSchedule WHERE (ID = @Content OR MemberName LIKE N'%' + @Content + '%' OR TrainerName  LIKE N'%' + @Content + '%' OR BranchName  LIKE N'%' + @Content + '%' OR MemberID = @Content OR TrainerID = @Content OR BranchID = @Content)
	ELSE IF (@FilterType = 1)
		SELECT * FROM V_MemberWorkOutScheduleInDay WHERE  (ID = @Content OR MemberName LIKE N'%' + @Content + '%' OR TrainerName  LIKE N'%' + @Content + '%' OR BranchName  LIKE N'%' + @Content + '%' OR MemberID = @Content OR TrainerID = @Content OR BranchID = @Content)
	ELSE IF (@FilterType = 2)
		SELECT * FROM V_MemberWorkOutScheduleCurrent WHERE  (ID = @Content OR MemberName LIKE N'%' + @Content + '%' OR TrainerName  LIKE N'%' + @Content + '%' OR BranchName  LIKE N'%' + @Content + '%' OR MemberID = @Content OR TrainerID = @Content OR BranchID = @Content)
	ELSE IF (@FilterType = 3)
		SELECT * FROM V_MemberWorkOutScheduleUpcoming WHERE  (ID = @Content OR MemberName LIKE N'%' + @Content + '%' OR TrainerName  LIKE N'%' + @Content + '%' OR BranchName  LIKE N'%' + @Content + '%' OR MemberID = @Content OR TrainerID = @Content OR BranchID = @Content)
END
GO
-- PROC Cập nhật remaingTS
CREATE PROCEDURE PROC_UpdateRemainingTS
@WorkOutPlanID char(6)
AS
BEGIN
	UPDATE Member SET RemainingTS = RemainingTS - 1
	FROM Member JOIN WorkOutPlan ON Member.ID = WorkOutPlan.MemberID 
	WHERE WorkOutPlan.ID = @WorkOutPlanID AND WorkOutPlan.TrainerID IS NOT NULL
END

GO
CREATE PROCEDURE PROC_UpdateWorkOutPlan
	@Date Date,
	@Time Time,
	@ID CHAR(6),
	@MemberID CHAR(6)
AS 
BEGIN
	IF NOT EXISTS
    (
        SELECT *
        FROM WorkOutPlan
        WHERE MemberID = @MemberID
        AND [Date] = @Date
        AND (
            (DATEADD(HOUR, -2, Time) <= @Time AND @Time <= Time)
            OR (Time <= @Time AND @Time <= DATEADD(HOUR, 2, Time))
        )
		AND WorkOutPlan.ID != @ID
    )
	BEGIN
		IF  (SELECT TrainerID FROM WorkOutPlan WHERE ID = @ID) IS NOT NULL 
		BEGIN
			UPDATE Member SET RemainingTS = RemainingTS + 1 WHERE Member.ID = @MemberID
		END
		UPDATE WorkOutPlan SET Time = @Time, Date = @Date WHERE WorkOutPlan.ID = @ID
	END
	ELSE
	BEGIN
		RAISERROR ( 'Buổi tập có thời gian quá gần với một lịch khác mà Member đăng ký',16,1);
	END
END

GO

--Hàm tìm WorkOut theo WorkOutPlanID
CREATE FUNCTION FUNC_FindWorkOutByWorkOutPlan(@ID char(6))
RETURNS TABLE
AS
	RETURN SELECT * FROM V_WorkOutList WHERE ID IN (SELECT WorkOutID FROM PlanDeTails WHERE WorkOutPlanID = @ID)
GO

--Hàm lấy Member dựa theo ngày cùng với tổng số tiền chi tiêu
CREATE FUNCTION FUNC_ListMemberWithTotalPaymentAmount(@StartDate Date,@EndDate Date)
RETURNS TABLE
AS
	RETURN SELECT  Member.ID, Member.Name, Member.PhoneNumber, ISNULL(SUM(PayByDate.PaymentAmount), 0) as TotalPaymentAmount 
	FROM Member LEFT JOIN (SELECT * FROM Payment WHERE Payment.Date >= @StartDate AND Payment.Date <= @EndDate ) As PayByDate ON Member.ID = PayByDate.MemberID
	GROUP BY Member.ID, Member.Name, Member.PhoneNumber 
GO
--Hàm tìm số ngươi theo hạng membership 
CREATE FUNCTION FUNC_FindNumberOfMemberByMemberShip(@MembershipID char(6))
RETURNS INT
AS
BEGIN
	DECLARE @tmp INT
	SELECT @tmp = COUNT(*) 
	FROM Member JOIN MembershipType ON Member.MembershipTypeID = MembershipType.ID 
	WHERE @MembershipID = MembershipType.ID
	RETURN @tmp
END


GO

--PROC tạo mùa membership mới theo công thức
CREATE PROCEDURE PROC_NewSeason
@StartDate Date,
@EndDate Date
AS
BEGIN
	UPDATE Member 
	SET  MembershipTypeID = '000001'
	FROM FUNC_ListMemberWithTotalPaymentAmount(@StartDate,@EndDate) as List
	WHERE Member.ID = List.ID AND TotalPaymentAmount < 4000000

	UPDATE Member 
	SET  MembershipTypeID = '000002'
	FROM FUNC_ListMemberWithTotalPaymentAmount(@StartDate,@EndDate) as List
	WHERE Member.ID = List.ID AND TotalPaymentAmount >= 4000000 AND TotalPaymentAmount < 8000000

	UPDATE Member 
	SET  MembershipTypeID = '000003'
	FROM FUNC_ListMemberWithTotalPaymentAmount(@StartDate,@EndDate) as List
	WHERE Member.ID = List.ID AND TotalPaymentAmount >= 8000000 AND TotalPaymentAmount < 12000000

	UPDATE Member 
	SET  MembershipTypeID = '000004'
	FROM FUNC_ListMemberWithTotalPaymentAmount(@StartDate,@EndDate) as List
	WHERE Member.ID = List.ID AND TotalPaymentAmount >= 12000000 AND TotalPaymentAmount < 16000000

	UPDATE Member 
	SET  MembershipTypeID = '000005'
	FROM FUNC_ListMemberWithTotalPaymentAmount(@StartDate,@EndDate) as List
	WHERE Member.ID = List.ID AND TotalPaymentAmount >= 16000000
END

GO
--Proc tìm alll member
CREATE PROCEDURE PROC_FindAllMember
	@FilterType INT,
	@Content NVARCHAR(50)
AS
BEGIN
	IF (@FilterType = 0)
		SELECT * FROM V_MemberList WHERE (ID = @Content OR [Name] LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE '%' + @Content + '%' OR [Address]  LIKE N'%' + @Content + '%')
	ELSE IF (@FilterType = 1)
		SELECT * FROM V_MemberList WHERE (ID = @Content OR [Name] LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE '%' + @Content + '%' OR [Address]  LIKE N'%' + @Content + '%') AND EndOfPackageDate >= CAST(GETDATE() AS DATE)
	ELSE IF (@FilterType = 2)
		SELECT * FROM V_MemberList WHERE (ID = @Content OR [Name] LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE '%' + @Content + '%' OR [Address]  LIKE N'%' + @Content + '%') AND (EndOfPackageDate < CAST(GETDATE() AS DATE) OR EndOfPackageDate is NULL)
END

GO 
--Proc Update member
CREATE PROCEDURE PROC_UpdateMember
@Name NVARCHAR(100),
@PhoneNumber CHAR(10),
@Address NVARCHAR(50),
@Gender NVARCHAR(30),
@ID CHAR(6)
AS
BEGIN
	IF @Gender = 'Nam' OR @Gender = 'Male' OR @Gender = 'M' OR @Gender = 'm' OR @Gender = 'male' OR @Gender = 'nam'
	BEGIN
		SET @Gender = 'm'
	END
	ELSE IF @Gender = 'Nu' OR @Gender = 'Female' OR @Gender = 'F' OR @Gender = 'f' OR @Gender = 'female' OR @Gender = 'nu' OR @Gender = N'nữ' OR @Gender = 'Nữ'
	BEGIN
		SET @Gender = 'f'
	END
	ELSE IF @Gender = 'U' OR @Gender = 'u' OR @Gender = 'Unknown' OR @Gender = 'unknown'
	BEGIN
		SET @Gender = 'u'
	END
	ELSE 
	BEGIN
		RAISERROR ( N'Giới tính không hợp lệ',16,1);
		RETURN
	END
	UPDATE Member 
	SET Name = @Name, PhoneNumber = @PhoneNumber, [Address] = @Address, Gender = @Gender 
	WHERE ID = @ID
END

GO
--FUNCTION Tìm ID của Membership theo rank
CREATE FUNCTION FUNC_FindMembershipByRank(@Rank NVARCHAR(50))
RETURNS CHAR(6)
AS
BEGIN
	DECLARE @tmp CHAR(6) 
	SET @tmp = 'None'
	SELECT @tmp = MembershipType.ID FROM MembershipType WHERE MembershipType.Rank = @Rank
	RETURN @tmp
END

GO
--PROC Load BMI mới nhất của thành viên
CREATE PROCEDURE PROC_LatestBMI @MemberID char(6)
AS
BEGIN
	SELECT TOP 1 *
    FROM BMI
    WHERE MemberID = @MemberID
    ORDER BY Date DESC;
END

INSERT INTO BMI(ID,MemberID,Weight,Height,Date) VALUES('000001','MEM011',60,175,'2023/10/25');

GO
--Proc tìm trainerlist
CREATE PROCEDURE PROC_FindTrainerList
	@FilterType INT,
	@Content NVARCHAR(50)
AS
BEGIN
	IF (@FilterType = 0)
		SELECT * FROM V_TrainerList WHERE (ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content)
	ELSE IF (@FilterType = 1)
		SELECT * FROM V_TrainerList WHERE ((Gender = 'm') AND ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content)
	ELSE IF (@FilterType = 2)
		SELECT * FROM V_TrainerList WHERE ((Gender = 'f') AND ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content)
END
GO
--PROC Insert BMI
CREATE PROCEDURE PROC_AddBMI
    @ID CHAR(6),
    @Date DATETIME,
    @Weight DECIMAL(4,1),
    @Height INT,
    @MemberPhone CHAR(10)
AS
BEGIN
	BEGIN TRY

		DECLARE @MemberID CHAR(6)
		SELECT @MemberID = ID FROM Member WHERE PhoneNumber = @MemberPhone 
		IF @MemberID IS NULL 
		BEGIN
			RAISERROR ('Thêm thất bại, không tìm thấy Member',16,1)
			RETURN
		END
		ELSE
		INSERT INTO BMI(ID, Date, Weight, Height, MemberID)
			VALUES (@ID, @Date, @Weight, @Height, @MemberID)
	END TRY
	BEGIN CATCH
		RAISERROR ('Thêm thất bại',16,1)
		RETURN 0
	END CATCH
	SELECT * FROM V_BMIList
END

--Cập nhật BMI và trả về trạng thái
GO
CREATE PROCEDURE PROC_UpdateBMI @ID CHAR(6), @Weight DECIMAL(4,1), @Height INT
AS
BEGIN
	BEGIN TRY
		UPDATE BMI
		SET Weight = @Weight, Height = @Height
		WHERE ID = @ID
	END TRY
	BEGIN CATCH
		RAISERROR ('Thông tin không đúng',16,1)
		RETURN
	END CATCH
	SELECT [Status] FROM BMI WHERE ID = @ID
END
GO

--Func lấy ngày và thể trạng 
CREATE FUNCTION FUNC_DataForChartBMI(@PhoneNumber CHAR(10))
RETURNS TABLE
AS
RETURN
    SELECT [Date], 
           CAST(([Weight] / POWER(([Height] / 100), 2)) AS DECIMAL(5, 2)) AS Rate
    FROM V_BMIList
    WHERE PhoneNumber = @PhoneNumber
GO
--Hàm tìm kiếm Branch
CREATE FUNCTION FUNC_FindBranch(@Content NVARCHAR(100))
RETURNS TABLE
AS
	RETURN SELECT * FROM V_BranchList WHERE ID = @Content OR [Name] LIKE  N'%' + @Content + '%' OR [Address] LIKE  N'%' + @Content + '%'

GO

--Proc insert Branch
CREATE PROCEDURE PROC_AddBranch
    @ID CHAR(6),
    @Name NVARCHAR(50),
    @Address NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Branch (ID, Name, Address)
			VALUES (@ID, @Name, @Address);
	END TRY
	BEGIN CATCH
		RAISERROR ('Thêm thất bại',16,1)
	END CATCH
END
GO
--Proc update branch
CREATE PROCEDURE PROC_UpdateBranch
    @ID CHAR(6),
    @Name NVARCHAR(50),
    @Address NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		UPDATE Branch
		SET Name = @Name,
			Address = @Address
		WHERE 
			ID = @ID
	END TRY
	BEGIN CATCH
		RAISERROR ('Cập nhật thất bại',16,1)
	END CATCH
END

GO
--Proc update branch
CREATE PROCEDURE PROC_DeleteBranch
    @ID CHAR(6)
AS
BEGIN
	BEGIN TRY
	IF (@ID = 'BRRoot')
	BEGIN
		RAISERROR ('Không thể xóa chi nhánh gốc',16,1)
		RETURN
	END
	ELSE
	BEGIN
		DELETE Branch
		WHERE 
			ID = @ID
	END
	END TRY
	BEGIN CATCH
		RAISERROR ('Xóa thất bại, cần phải đảm bảo chi nhánh trống',16,1)
	END CATCH
END

USE GymManagerDB

GO
--Func check đăng nhập hợp lệ không
CREATE FUNCTION FUNC_LoginAuthentication(@UserName varchar(20), @Password nvarchar(20))
RETURNS INT
AS
BEGIN
	IF EXISTS (SELECT * FROM Employee WHERE UserName = @UserName AND [Password] = @Password)
		RETURN 1
	RETURN 0
END
SELECT *FROM Employee
INSERT INTO Branch(ID, Name, Address) VALUES('BRRoot',N'Monster GYM', N'Số 1, Võ Văn Ngân, Thủ Đức')
INSERT INTO Employee(ID,Name,Password,UserName,BranchID,Role) VALUES('Admin0','admin','admin', 'admin', 'BRRoot', '1')

GO
--Proc Lấy thông tin nhân viên 
CREATE PROCEDURE PROC_UserInfo
@UserName VARCHAR(20)
AS 
	SELECT Employee.Name, Password, UserName, Branch.ID, Branch.Name AS  BranchName, Role FROM Employee JOIN Branch ON Employee.BranchID = Branch.ID 
	WHERE UserName = @UserName

GO
--View Xem nhân viên
CREATE VIEW V_EmployeeList
AS
SELECT * FROM Employee

GO
--Tìm nhân viên 
CREATE FUNCTION dbo.FUNC_FindEmployee
(
    @Content NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Employee
    WHERE [Name] LIKE N'%' + @Content + '%'
       OR [UserName] LIKE '%' + @Content + '%'
);

GO
--PROC thêm nhân viên
CREATE PROCEDURE PROC_AddEmployee
    @ID CHAR(6),
    @Name NVARCHAR(50),
    @UserName VARCHAR(20),
    @Password VARCHAR(20),
    @Role CHAR(1),
    @BranchID CHAR(6),
	@YourRole CHAR(1)
AS
BEGIN
	IF (@YourRole = 2 AND (@Role = 1 OR (SELECT TOP 1 Role FROM Employee WHERE UserName = @UserName) = 1 ))
		RAISERROR ('Bạn không đủ quyền',16,1)
	ELSE
	IF EXISTS (SELECT * FROM Employee WHERE UserName = @UserName)
		RAISERROR('User name đã tồn tại',16 ,1)
	ELSE
    INSERT INTO Employee ([ID], [Name], [UserName], [Password], [Role], [BranchID])
    VALUES (@ID, @Name, @UserName, @Password, @Role, @BranchID)
END

GO
--PROC Reser pass
CREATE PROCEDURE PROC_ResetPasswordToDefault
    @EmployeeID CHAR(6),
	@YourRole CHAR(1)
AS
BEGIN
    UPDATE Employee
    SET [Password] = '123456'
    WHERE [ID] = @EmployeeID
END

GO

--PROC update thông tin employee
CREATE PROCEDURE PROC_UpdateEmployeeInfo
    @UserName VARCHAR(20),
    @Name NVARCHAR(50),
    @Role CHAR(1),
    @BranchID CHAR(6),
	@YourRole CHAR(1)
AS
BEGIN
	IF (@YourRole = 2 AND (@Role = 1 OR (SELECT TOP 1 Role FROM Employee WHERE UserName = @UserName) = 1 ))
		RAISERROR ('Bạn không đủ quyền',16,1)
	ELSE
	BEGIN
		UPDATE Employee
		SET
			[Name] = @Name,
			[Role] = @Role,
			[BranchID] = @BranchID
		WHERE [UserName] = @UserName
	END
END
GO
--DROC DELETE employee
CREATE PROCEDURE PROC_DeleteEmployee
@UserName VARCHAR(20),
@YourRole CHAR(1)
AS 
BEGIN
	IF (@YourRole = 2 AND (SELECT TOP 1 Role FROM Employee WHERE UserName = @UserName) = 1)
		RAISERROR ('Bạn không đủ quyền',16,1)
	ELSE
	DELETE Employee WHERE UserName = @UserName
END

Go
--Đổi pass
CREATE PROCEDURE PROC_ChangePassword
    @Password VARCHAR(20),
    @UserName VARCHAR(20),
    @NewPassword VARCHAR(20),
    @ReEnterPassword VARCHAR(20)
AS
BEGIN
    -- Kiểm tra mật khẩu hiện tại có đúng không
    IF EXISTS (SELECT 1 FROM Employee WHERE [UserName] = @UserName AND [Password] = @Password)
    BEGIN
        -- Kiểm tra mật khẩu mới và mật khẩu nhập lại có khớp nhau không
        IF @NewPassword = @ReEnterPassword
        BEGIN
            -- Cập nhật mật khẩu mới
            UPDATE Employee
            SET [Password] = @NewPassword
            WHERE [UserName] = @UserName

            SELECT N'Mật khẩu đã được thay đổi thành công.' AS Result
        END
        ELSE
        BEGIN
            SELECT N'Mật khẩu mới và mật khẩu nhập lại không khớp.' AS Result
        END
    END
    ELSE
    BEGIN
        SELECT N'Mật khẩu hiện tại không chính xác.' AS Result
    END
END