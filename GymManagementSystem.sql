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
CREATE VIEW V_PackageListHasTrainer AS
SELECT *
FROM dbo.Package
WHERE (NumberOfPTSessions IS NOT NULL) AND (NumberOfPTSessions != 0);

GO
CREATE VIEW V_PackageListNoTrainer AS
SELECT *
FROM dbo.Package
WHERE (NumberOfPTSessions IS NULL) OR (NumberOfPTSessions = 0);


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
SELECT dbo.Equipment.[ID], dbo.Equipment.[Name], dbo.Equipment.[Status], dbo.Branch.[Name] AS BranchName, dbo.EquipmentCategory.[Name] AS Category, EquipmentCategory.ID AS CategoryID, BranchID, Price
FROM dbo.Equipment JOIN dbo.Branch ON Branch.ID = Equipment.BranchID
				   JOIN dbo.EquipmentCategory ON EquipmentCategory.ID = Equipment.CategoryID
GO
-- Xem danh sách thiết bị hư hỏng
CREATE VIEW V_DamagedEqpList AS
SELECT dbo.Equipment.[ID], dbo.Equipment.[Name], dbo.Equipment.[Status], dbo.Branch.[Name] AS BranchName, dbo.EquipmentCategory.[Name] AS Category, EquipmentCategory.ID AS CategoryID, BranchID, Price
FROM dbo.Equipment JOIN dbo.Branch ON Branch.ID = Equipment.BranchID
				   JOIN dbo.EquipmentCategory ON EquipmentCategory.ID = Equipment.CategoryID
WHERE dbo.Equipment.[Status] = 'unavailable'
Go 
	-- Xem danh sách thiết bị còn hoạt động
CREATE VIEW V_AvailableEqpList AS
SELECT dbo.Equipment.[ID], dbo.Equipment.[Name], dbo.Equipment.[Status], dbo.Branch.[Name] AS BranchName, dbo.EquipmentCategory.[Name] AS Category, EquipmentCategory.ID AS CategoryID, BranchID, Price
FROM dbo.Equipment JOIN dbo.Branch ON Branch.ID = Equipment.BranchID
				   JOIN dbo.EquipmentCategory ON EquipmentCategory.ID = Equipment.CategoryID
WHERE dbo.Equipment.[Status] = 'available'

GO 
--Xem danh sách BMI
CREATE VIEW V_BMIList AS
SELECT BMI.ID, BMI.Status, BMI.Weight, BMI.Height, BMI.Date, MemberID,Member.Name, Member.PhoneNumber
FROM BMI JOIN Member ON BMI.MemberID = Member.ID

GO

-- Xem danh sách thanh toán mua gói tập 
CREATE VIEW V_PaymentPackageList
AS 
	SELECT dbo.Payment.ID, dbo.[Member].[Name] AS 'Member Name', dbo.[Member].PhoneNumber AS 'Phone Number', 
		   dbo.Package.[Name] AS 'Package Name', dbo.Payment.PaymentAmount AS Amount, dbo.Payment.[Date], 
		   dbo.Branch.[Name] AS 'Branch Name'
	FROM dbo.Payment, dbo.[Member], dbo.Branch, dbo.Package
	WHERE (dbo.Payment.MemberID = dbo.[Member].ID) 
	      AND (dbo.Payment.BranchID = dbo.Branch.ID) 
		  AND (dbo.Payment.PackageID = dbo.Package.ID);

GO

-- Danh sách thi tiêu cho việc bảo trì và sửa chữa thiết bị 
CREATE VIEW V_PaymentEquipmentMaintenanceList
AS 
	SELECT dbo.MaintenanceData.ID, dbo.Equipment.[Name] AS 'Equiment Name', dbo.MaintenanceData.Cost, 
		   dbo.Branch.[Name] AS 'Branch Name', dbo.MaintenanceData.[Date] 
    FROM dbo.MaintenanceData, dbo.Equipment, dbo.Branch
	WHERE (dbo.MaintenanceData.EquipmentID = dbo.Equipment.ID) 
		  AND (dbo.Equipment.BranchID = dbo.Branch.ID);



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
	INNER JOIN inserted i ON eqp.ID = i.EquipmentID
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

INSERT INTO Branch ([ID], [Name], [Address])
VALUES
	('BR0001', N'Monster Thảo Điền', N'Quận 2, HCM'),
	('BR0002', N'Monster Thủ Đức', N'Tp. Thủ Đức, HCM'),
	('BRRoot', N'Monster GYM', N'trụ sở chính');

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
    ('WO0012', N'Barbell Hip Thrust', N'Legs', N'Bài tập đẩy hông bằng tạ giúp phát triển cơ mông và cơ chân.', 15),
	('WO0013', N'Tự do', N'All', N'Tập tùy thích.', 119);
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
	('EQC013', N'Tạ đơn'),
	('EQC014', N'Khác');
GO SELECT *FROM Equipment
INSERT INTO Equipment (ID, CategoryID, BranchID, Name, Status, Price)
VALUES
    ('EQ0001', 'EQC001', 'BR0001', N'Máy chạy MaxSpeed', 'available', 1000000.00),
    ('EQ0002', 'EQC002', 'BR0002', N'Máy gập có hỗ trợ', 'unavailable', 1500000.00),
    ('EQ0003', 'EQC003', 'BR0001', N'Xe đạp PowerTraining', 'available', 2000000.00),
    ('EQ0004', 'EQC004', 'BR0002', N'Máy đẩy ngực Hulk', 'unavailable', 1200000.00),
    ('EQ0005', 'EQC005', 'BR0001', N'Máy đẩy vai sau', 'available', 18000000.00),
    ('EQ0006', 'EQC006', 'BR0002', N'Máy Squat', 'unavailable', 2500000.00);

-- Kiểm tra lịch tập có huấn luyện viên nhưng bị trùng giờ với lịch của huấn luyện viên đó (insert, update woukloutplan) rollback báo lỗi.
GO
INSERT INTO Trainer ([ID], [Name], [Address], [PhoneNumber], [Gender], [BranchID])
VALUES
	('TR0001', N'Lê Nguyễn Bảo', N'ktx D2, Lê Văn Việt, Thủ Đức', '1234567890', 'm', 'BR0001'),
	('TR0002', N'Nguyễn Thiện Luân', N'ktx D2, Lê Văn Việt, Thủ Đức', '2345678901', 'm', 'BR0002'),
    ('TR0003', N'Hoàng Anh Tuấn', N'999 Đường Hàm Nghi, Quận 2, TP.HCM', '6789012345', 'm', 'BR0002'),
    ('TR0004', N'Phạm Minh Trí', N'222 Đường Lý Tự Trọng, Quận 5, TP.HCM', '7890123456', 'm', 'BR0001'),
    ('TR0005', N'Trainer 8', N'333 Đường Trường Sa, Quận 11, TP.HCM', '8901234567', 'm', 'BR0002'),
    ('TR0006', N'Lê Thị Mai', N'444 Đường Lê Lai, Quận 3, TP.HCM', '9012345678', 'f', 'BR0001'),
    ('TR0007', N'Nguyễn Đình Hoàng', N'555 Đường Nguyễn Trãi, Quận 10, TP.HCM', '0123456789', 'm', 'BR0002');


GO
INSERT INTO Package ([ID], [Name], [Periods], [Price], [Description], [NumberOfPTSessions])
VALUES
	('PK0001', N'Gói Vận Động Sức Khỏe', 3, 5000000, N'Gói tập thể dục hàng ngày', 15),
	('PK0002', N'Gói Siêu Thể Hình', 6, 1000000, N'Gói tập mục tiêu giữ dáng', 30),
	('PK0003', N'Gói Đỉnh Cao Sức Khỏe', 12, 1500000, N'Gói tập toàn diện', 15),
	('PK0004', N'Gói Thử Thách Tập Luyện', 1, 250000, N'Gói tập dành cho thử thách', NULL),
	('PK0005', N'Gói Tăng Sức Bền', 4, 750000, N'Gói tập nhẹ nhàng cải thiện sức bền', 8),
	('PK0006', N'Gói Thách Thức Thể Hình', 8, 1250000, N'Gói tập nâng cao cường độ', NULL),
	('PK0007', N'Gói Cải Thiện Sức Khỏe', 2, 400000, N'Gói tập ngắn hạn', 10),
	('PK0008', N'Gói Đặc Biệt Thể Hình', 6, 900000, N'Gói tập cao cấp', 12),
	('PK0009', N'Gói Tập Luyện Chuyên Sâu', 12, 1750000, N'Gói tập chuyên nghiệp', NULL),
	('PK0010', N'Gói Xây Dựng Cơ Bắp', 3, 600000, N'Gói tập xây dựng cơ bắp', 30);

GO 
INSERT INTO Member ([ID], [MembershipTypeID], [Name], [Gender], [PhoneNumber], [Address], [Balance], [PackageID], [EndOfPackageDate], [RemainingTS])
VALUES
	('MB0001', '000001', 'Member 1', 'm', '1234567890', 'Address 1', 100.00, 'PK0001', '2023-12-30',11),
	('MB0002', '000002', 'Member 2', 'f', '2345678901', 'Address 2', 200.00, 'PK0002', '2023-12-30',5),
	('MB0003', '000003', 'Member 3', 'm', '3456789012', 'Address 3', 300.00, 'PK0003', '2023-12-30',5),
	('MB0004', '000001', 'Member 4', 'f', '4567890123', 'Address 4', 400.00, 'PK0004', '2023-12-30',NULL),
	('MB0005', '000002', 'Member 5', 'm', '5678901234', 'Address 5', 500.00, 'PK0005', '2023-12-30',44),
	('MB0006', '000003', 'Member 6', 'f', '6789012345', 'Address 6', 600.00, 'PK0006', '2023-12-30',NULL),
	('MB0007', '000001', 'Member 7', 'm', '7890123456', 'Address 7', 700.00, 'PK0007', '2023-12-30',10),
	('MB0008', '000002', 'Member 8', 'f', '8901234567', 'Address 8', 800.00, 'PK0008', '2023-12-30',1),
	('MB0009', '000003', 'Member 9', 'm', '9012345678', 'Address 9', 900.00, 'PK0009', '2023-12-30',NULL),
	('MB0010', '000001', 'Member 10', 'f', '0123456789', 'Address 10', 1000.00, 'PK0010', '2023-12-30',0);

GO 
INSERT INTO WorkOutPlan ([ID], [MemberID], [TrainerID], [BranchID], [Time], [Date])
VALUES
	('WOP001', 'MB0001', 'TR0002', 'BR0002', '20:00:00', '2023-12-01'),
	('WOP002', 'MB0002', 'TR0002', 'BR0002', '09:00:00', '2023-12-07'),
	('WOP003', 'MB0003', 'TR0003', 'BR0001', '10:00:00', '2023-12-04'),
	('WOP005', 'MB0005', 'TR0005', 'BR0001', '12:00:00', '2023-12-02'),
	('WOP007', 'MB0007', 'TR0007', 'BR0002', '14:00:00', '2023-12-07'),
	('WOP008', 'MB0008', 'TR0001', 'BR0001', '15:00:00', '2023-12-08')

GO

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
   	('WOP005', 'WO0010')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP007', 'WO0002')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP007', 'WO0003')
	INSERT INTO dbo.PlanDetails (WorkOutPlanID, WorkOutID)
VALUES
	('WOP008', 'WO0013')

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

-- PROCDURE Lấy danh sách các thanh toán được thực hiện bởi member thông qua số điện thoại 
GO
CREATE PROCEDURE dbo.PROC_FindListPaymentByPhoneNumber
    @PhoneNumber CHAR(10)
AS
BEGIN
    SELECT dbo.Payment.ID, dbo.[Member].[Name] AS 'Member Name', dbo.[Member].PhoneNumber AS 'Phone Number', 
		   dbo.Package.[Name] AS 'Package Name', dbo.Payment.PaymentAmount AS Amount, dbo.Payment.[Date], 
		   dbo.Branch.[Name] AS 'Branch Name'
	FROM dbo.Payment, dbo.[Member], dbo.Branch, dbo.Package
	WHERE (dbo.[Member].PhoneNumber = @PhoneNumber)
	      AND (dbo.Payment.MemberID = dbo.[Member].ID) 
	      AND (dbo.Payment.BranchID = dbo.Branch.ID) 
		  AND (dbo.Payment.PackageID = dbo.Package.ID);
END

GO
CREATE PROCEDURE dbo.PROC_PaymentByPhoneNumber
    @PhoneNumber CHAR(10)
AS
BEGIN
    SELECT memberInfor.[ID], memberInfor.[Name], memberInfor.[Balance], memberInfor.[MembershipTypeID], dbo.MembershipType.[Rate] FROM
	(SELECT [ID], [Name], [Balance], [MembershipTypeID] FROM [dbo].[Member] WHERE PhoneNumber = @PhoneNumber) 
	AS memberInfor, dbo.MembershipType
    WHERE memberInfor.MembershipTypeID = dbo.MembershipType.ID;
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

-- Tính tổng giá trị của một cột trong bảng 
CREATE PROCEDURE PROC_CalcSum
    @TableName CHAR(50),
    @ColumnName CHAR(50)
AS 
BEGIN
    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = N'SELECT SUM(' + QUOTENAME(@ColumnName) + N') FROM ' + QUOTENAME(@TableName) + N';';
    EXEC sp_executesql @SqlStatement;
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
	@Content NVARCHAR(50),
	@BranchID CHAR(6)
AS
BEGIN
	IF (@BranchID = 'BRRoot') --Neu chi nhanh goc duoc quyen search tren tat ca chi nhanh
	BEGIN
		IF (@FilterType = 0)
			SELECT * FROM V_TrainerList WHERE (ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content)
		ELSE IF (@FilterType = 1)
			SELECT * FROM V_TrainerList WHERE ((Gender = 'm') AND (ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content))
		ELSE IF (@FilterType = 2)
			SELECT * FROM V_TrainerList WHERE ((Gender = 'f') AND (ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content))
	END
	ELSE
	BEGIN
		IF (@FilterType = 0)
			SELECT * FROM V_TrainerList WHERE (ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content) AND (V_TrainerList.BranchID = @BranchID)
		ELSE IF (@FilterType = 1)
			SELECT * FROM V_TrainerList WHERE ((Gender = 'm') AND (ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content) AND (V_TrainerList.BranchID = @BranchID))
		ELSE IF (@FilterType = 2)
			SELECT * FROM V_TrainerList WHERE ((Gender = 'f') AND (ID = @Content OR Address LIKE N'%' + @Content + '%' OR Name  LIKE N'%' + @Content + '%' OR PhoneNumber  LIKE N'%' + @Content + '%' OR Branch  LIKE N'%' + @Content + '%' OR BranchID = @Content) AND (V_TrainerList.BranchID = @BranchID))
	END
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

GO


GO
--Proc Lấy thông tin nhân viên 
CREATE PROCEDURE PROC_UserInfo
@UserName VARCHAR(20)
AS 
	SELECT Employee.[Name], dbo.Employee.[ID] AS EmployeeID, [Password], [UserName], Branch.[ID], Branch.[Name] AS  BranchName, [Role] FROM Employee JOIN Branch ON Employee.BranchID = Branch.ID 
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
	IF (@YourRole = 2 AND @BranchID = 'BRRoot')
		RAISERROR ('Bạn không được thêm thành viên vào chi nhánh chính',16,1)
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
	IF (@YourRole = 2 AND @BranchID = 'BRRoot')
		RAISERROR ('Bạn không được thêm thành viên vào chi nhánh chính',16,1)
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
GO

--PROC TÌm ds equipment
CREATE PROCEDURE PROC_FindEquipment
    @FilterType INT,
    @Content NVARCHAR(50),
    @BranchID CHAR(6)
AS
BEGIN
    IF @BranchID = 'BRRoot' -- Tìm trên tất cả các chi nhánh
    BEGIN
        IF @FilterType = 0 -- All
        BEGIN
            SELECT *
            FROM V_EquipmentList eq
            WHERE eq.[Name] LIKE N'%' + @Content + '%'
        END
        ELSE IF @FilterType = 1 -- Avai
        BEGIN
            SELECT *
            FROM V_AvailableEqpList eq
            WHERE eq.[Name] LIKE N'%' + @Content + '%'
        END
        ELSE IF @FilterType = 2 -- Unvai
        BEGIN
            SELECT *
            FROM V_DamagedEqpList eq
            WHERE eq.[Name] LIKE N'%' + @Content + '%'
        END
    END
    ELSE -- Tìm trên một chi nhánh cụ thể
    BEGIN
        IF @FilterType = 0 -- All
        BEGIN
            SELECT *
            FROM V_EquipmentList eq
            WHERE eq.[Name] LIKE N'%' + @Content + '%'
                AND eq.[BranchID] = @BranchID
        END
        ELSE IF @FilterType = 1 -- Avai
        BEGIN
            SELECT *
            FROM V_AvailableEqpList eq
            WHERE eq.[Name] LIKE N'%' + @Content + '%'
                AND eq.[BranchID] = @BranchID
        END
        ELSE IF @FilterType = 2 -- Unvai
        BEGIN
            SELECT *
            FROM V_DamagedEqpList eq
            WHERE eq.[Name] LIKE N'%' + @Content + '%'
                AND eq.[BranchID] = @BranchID
        END
    END
END


GO
--PROC Đổi trạng thái
CREATE PROCEDURE PROC_SetUnavailable
    @ID CHAR(6)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thực hiện các thay đổi cần thiết trên dữ liệu
        UPDATE Equipment
        SET Status = N'unavailable'
        WHERE ID = @ID;
        
        -- Commit transaction nếu không có lỗi xảy ra
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback transaction nếu có lỗi xảy ra
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
GO
--PROC Tìm lịch sử sửa chửa
CREATE PROCEDURE PROC_FindMaintenanceData
@ID CHAR(6)
AS
BEGIN
	SELECT * FROM MaintenanceData
	WHERE MaintenanceData.EquipmentID = @ID
END

GO 
--PROC thêm lịch sử sửa chửa
CREATE PROCEDURE PROC_AddMaintenanceData
    @ID CHAR(6),
    @EquipmentID CHAR(6),
    @Date DATE,
    @Cost MONEY,
    @Description NTEXT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem thiết bị có trạng thái "Unavailable" không
    DECLARE @Status NVARCHAR(20);
    SELECT @Status = Status
    FROM Equipment
    WHERE ID = @EquipmentID;

    IF @Status <> 'Unavailable' AND  @Status <> 'unavailable'
    BEGIN
       RAISERROR ('Thiết bị không có trạng thái "Unavailable".',16,1);
        RETURN;
    END;

    -- Kiểm tra xem giá sửa chữa có cao hơn giá Price gốc của thiết bị không
    DECLARE @Price MONEY;
    SELECT @Price = Price
    FROM Equipment
    WHERE ID = @EquipmentID;

    IF @Cost > @Price
    BEGIN
        RAISERROR ('Giá sửa chữa cao hơn giá Price gốc của thiết bị.',16,1)
        RETURN;
    END;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thêm dữ liệu lịch sử sửa chữa vào bảng MaintenanceData
        INSERT INTO MaintenanceData(ID, EquipmentID, [Date], Cost, [Description])
        VALUES (@ID, @EquipmentID, @Date, @Cost, @Description);

        -- Commit transaction nếu không có lỗi xảy ra
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback transaction nếu có lỗi xảy ra
        ROLLBACK TRANSACTION;

        RAISERROR('Thêm lịch sử sửa chửa thất bại',16,1);
    END CATCH;
END

GO
--FUNC Tìm Gia thiet bị 
CREATE FUNCTION FUNC_FindPrice(@ID CHAR(6))
RETURNS MONEY
AS
BEGIN
	DECLARE @tmp MONEY
	SELECT @tmp = Price FROM Equipment WHERE (ID = @ID)
	RETURN @tmp
END


GO
--PROC Thay mới thiết bị
CREATE PROCEDURE PROC_ReplaceEquipment
    @ID CHAR(6),
    @EquipmentID CHAR(6),
    @Date DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem thiết bị có trạng thái "Unavailable" không
    DECLARE @Status NVARCHAR(20);
    SELECT @Status = Status
    FROM Equipment
    WHERE ID = @EquipmentID;

    IF @Status <> 'Unavailable' AND  @Status <> 'unavailable'
    BEGIN
       RAISERROR ('Thiết bị không có trạng thái "Unavailable".',16,1);
        RETURN;
    END;


    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thêm dữ liệu lịch sử sửa chữa vào bảng MaintenanceData
        INSERT INTO MaintenanceData(ID, EquipmentID, [Date], Cost, [Description])
        VALUES (@ID, @EquipmentID, @Date, dbo.FUNC_FindPrice(@EquipmentID), N'Thay thế thiết bị mới tương tự');

        -- Commit transaction nếu không có lỗi xảy ra
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback transaction nếu có lỗi xảy ra
        ROLLBACK TRANSACTION;

        RAISERROR('Thay đổi thiết bị thất bại',16,1);
    END CATCH;
END
GO
--Insert Trainer
CREATE PROCEDURE PROC_InsertTrainer
    @ID CHAR(6),
    @Name NVARCHAR(50),
    @Address NVARCHAR(50),
    @PhoneNumber CHAR(10),
    @Gender NVARCHAR(10),
    @BranchID CHAR(6)
AS
BEGIN
    SET NOCOUNT ON;

    -- Chuyển đổi giá trị giới tính
    SET @Gender = CASE 
                    WHEN @Gender = 'Male' THEN 'm'
                    WHEN @Gender = 'Female' THEN 'f'
                    WHEN @Gender = 'Unknown' THEN 'u'
                    ELSE @Gender
                 END;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thêm dữ liệu trainer vào bảng Trainer
        INSERT INTO Trainer (ID, Name, Address, PhoneNumber, Gender, BranchID)
        VALUES (@ID, @Name, @Address, @PhoneNumber, @Gender, @BranchID);

        -- Commit transaction nếu không có lỗi xảy ra
        COMMIT TRANSACTION;

        SELECT 'Thêm trainer thành công.' AS Result;
    END TRY
    BEGIN CATCH
        -- Rollback transaction nếu có lỗi xảy ra
        ROLLBACK TRANSACTION;

        -- Lấy thông báo lỗi để trả về
        SELECT ERROR_MESSAGE() AS Result;
    END CATCH;
END



--Update Trainer
GO
CREATE PROCEDURE PROC_UpdateTrainer
    @ID CHAR(6),
    @Name NVARCHAR(50),
    @Address NVARCHAR(50),
    @PhoneNumber CHAR(10),
    @Gender NVARCHAR(10),
    @BranchID CHAR(6)
AS
BEGIN
    SET NOCOUNT ON;

    -- Chuyển đổi giá trị giới tính
    SET @Gender = CASE 
                    WHEN @Gender = 'Male' THEN 'm'
                    WHEN @Gender = 'Female' THEN 'f'
                    WHEN @Gender = 'Unknown' THEN 'u'
                    ELSE @Gender
                 END;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thêm dữ liệu trainer vào bảng Trainer
          UPDATE Trainer
			SET Name = @Name,
				Address = @Address,
				PhoneNumber = @PhoneNumber,
				Gender = @Gender,
				BranchID = @BranchID
			WHERE ID = @ID;

        -- Commit transaction nếu không có lỗi xảy ra
        COMMIT TRANSACTION;

        SELECT N'Cập nhật Trainer thành công.' AS Result;
    END TRY
    BEGIN CATCH
        -- Rollback transaction nếu có lỗi xảy ra
        ROLLBACK TRANSACTION;

        -- Lấy thông báo lỗi để trả về
        SELECT ERROR_MESSAGE() AS Result;
    END CATCH;
END

GO

--PROC thêm workout
CREATE PROCEDURE PROC_AddWorkout
    @ID CHAR(6),
    @Name NVARCHAR(50),
    @Type VARCHAR(50),
    @Description NTEXT,
    @Duration INT
AS
BEGIN
	IF EXISTS (SELECT * FROM WorkOut WHERE [Name] = @Name)
		RAISERROR('Bài tập đã tồn tại',16 ,1)
	ELSE
    INSERT INTO WorkOut([ID], [Name], [Type], [Description], [Duration])
    VALUES (@ID, @Name, @Type, @Description, @Duration)
END

GO

--PROC DELETE Workout
CREATE PROCEDURE PROC_DeleteWorkout
@ID CHAR(6)
AS 
BEGIN
	DELETE WorkOut WHERE [ID] = @ID
END

GO

--PROC update thông tin workout
CREATE PROCEDURE PROC_UpdateWorkout
	@ID char(6),
    @Name NVARCHAR(50),
    @Type VARCHAR(50),
    @Description NTEXT,
    @Duration INT
AS
BEGIN
		UPDATE WorkOut
		SET
			[Name] = @Name,
			[Type] = @Type,
			[Description] = @Description,
			[Duration] = @Duration
		WHERE [ID] = @ID

END

GO

-- Tạo bảng Ảo lưu khoản thời gian
CREATE TABLE TimeSlot (
    SlotID INT PRIMARY KEY IDENTITY(1, 1),
    StartTime TIME,
    EndTime TIME
);

-- Điền dữ liệu vào bảng từ 6h đến 11h tối, cách nhau 2 tiếng
DECLARE @StartTime TIME = '06:00:00'; -- 6h tối
DECLARE @EndTime TIME = '20:00:00'; -- 11h tối

WHILE @StartTime <= @EndTime
BEGIN
    INSERT INTO TimeSlot (StartTime, EndTime)
    VALUES (@StartTime, DATEADD(HOUR, 2, @StartTime));

    SET @StartTime = DATEADD(HOUR, 2, @StartTime);
END
	INSERT INTO TimeSlot (StartTime, EndTime)
    VALUES ('22:00:00', '23:00:00');
SELECT *FROM TimeSlot
GO

--FUNC Lấy lịch làm việc theo ngày của trainer

CREATE FUNCTION FUNC_TrainerSchedule(@TrainerID CHAR(6), @Date Date)
RETURNS TABLE
AS

	RETURN
	SELECT CAST(StartTime AS CHAR(9)) + ' - ' + CAST(EndTime AS CHAR(9)) AS TimeFrame, ID, Time FROM
	(SELECT WorkOutPlan.ID, WorkOutPlan.Time
	FROM Trainer 
		LEFT JOIN   
		WorkOutPlan ON Trainer.ID = WorkOutPlan.TrainerID WHERE Trainer.ID = @TrainerID AND WorkOutPlan.Date = @Date) AS TnPlan
	RIGHT JOIN TimeSlot 
	ON (TimeSlot.StartTime <= TnPlan.Time AND TimeSlot.EndTime > TnPlan.Time) OR TnPlan.Time IS NULL 
		


GO
--View category
CREATE VIEW V_CategoryList
AS
SELECT *FROM EquipmentCategory



Go
--Thêm Equipment
CREATE PROCEDURE PROC_AddEquipment
    @ID CHAR(6),
    @Name NVARCHAR(50),
    @Status NVARCHAR(50),
	@Price NVARCHAR(50),
	@BranchID CHAR(6),
	@CategoryID CHAR(6)
AS
BEGIN
	DECLARE @TruePrice MONEY
	BEGIN TRY
		SET @TruePrice = CAST(@Price AS MONEY)
	END TRY
	BEGIN CATCH
		RAISERROR ('Price không hợp lệ',16,1)
		RETURN
	END CATCH
	BEGIN TRY
		INSERT INTO Equipment(ID, Name, Status, Price, BranchID, CategoryID)
			VALUES (@ID, @Name, @Status, @Price, @BranchID, @CategoryID);
	END TRY
	BEGIN CATCH
		RAISERROR ('Thêm thất bại',16,1)
		RETURN
	END CATCH
END
GO

--Cập nhật Equipment
CREATE PROCEDURE PROC_UpdateEquipment
    @ID CHAR(6),
    @Name NVARCHAR(50),
    @Status NVARCHAR(50),
	@Price NVARCHAR(50),
	@BranchID CHAR(6),
	@CategoryID CHAR(6)
AS
BEGIN
	DECLARE @TruePrice MONEY
	BEGIN TRY
		SET @TruePrice = CAST(@Price AS MONEY)
	END TRY
	BEGIN CATCH
		RAISERROR ('Price không hợp lệ',16,1)
		RETURN
	END CATCH
	BEGIN TRY
		UPDATE Equipment
		SET  
			Name = @Name,
			Status = @Status,
			Price = @Price,
			BranchID = @BranchID,
			CategoryID = @CategoryID
		WHERE 
			ID = @ID 
	END TRY
	BEGIN CATCH
		RAISERROR ('Cập nhật thất bại',16,1)
		RETURN
	END CATCH
END


Go
-- Xóa Equipment
CREATE PROCEDURE PROC_DeleteEquipment
    @ID CHAR(6)
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Equipment WHERE ID = @ID)
	BEGIN
		RAISERROR ('Thiết bị không tồn tại',16,1)
		RETURN
	END
	BEGIN TRY
	DELETE Equipment
		WHERE 
			ID = @ID
	END TRY
	BEGIN CATCH
		RAISERROR ('Xóa thất bại',16,1)
	END CATCH
END

GO

--PROC thêm equipmentCategory
CREATE PROCEDURE PROC_AddEquipmentCategory
	@ID CHAR(6),
	@Name NVARCHAR(50)
AS
BEGIN
	IF EXISTS (SELECT * FROM EquipmentCategory WHERE [Name] = @Name)
		RAISERROR('Category đã tồn tại',16 ,1)
	ELSE
    INSERT INTO EquipmentCategory([ID], [Name])
    VALUES (@ID, @Name)
END

GO

--PROC DELETE equipmentCategory
CREATE PROCEDURE PROC_DeleteEquipmentCategory
@ID CHAR(6)
AS 
BEGIN
	DELETE EquipmentCategory WHERE [ID] = @ID
END

GO

--PROC update thông tin equipmentCategory
CREATE PROCEDURE PROC_UpdateEquipmentCategory
	@ID char(6),
    @Name NVARCHAR(50)
AS
BEGIN
		UPDATE EquipmentCategory
		SET
			[Name] = @Name
		WHERE [ID] = @ID

END

GO

--Proc tìm kiếm trong category list
CREATE PROCEDURE PROC_FindEquipmentCategory
	@Content NVARCHAR(50)
AS
BEGIN
			SELECT * FROM V_CategoryList WHERE (ID = @Content OR Name LIKE N'%' + @Content + '%')
END

GO

--Hàm tìm kiếm Workout
CREATE FUNCTION FUNC_FindWorkout(@Content NVARCHAR(100))
RETURNS TABLE
AS
	RETURN SELECT * FROM V_WorkOutList WHERE ID = @Content OR [Name] LIKE  N'%' + @Content + '%' OR [Type] LIKE  N'%' + @Content + '%' OR [Description] LIKE  N'%' + @Content + '%' OR [Duration] LIKE  N'%' + @Content + '%' 
	
GO

CREATE PROCEDURE PROC_AddPackage
    @ID CHAR(6),
    @Name NVARCHAR(100),
    @Periods INT,
    @Price MONEY,
    @Description NTEXT,
    @NumberOfPTSessions INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Check and set NumberOfPTSessions to NULL if it's 0
        IF @NumberOfPTSessions = 0
        BEGIN
            SET @NumberOfPTSessions = NULL;
        END

        INSERT INTO Package (ID, Name, Periods, Price, Description, NumberOfPTSessions)
        VALUES (@ID, @Name, @Periods, @Price, @Description, @NumberOfPTSessions);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT N'Thêm thất bại' AS Result
		RETURN
    END CATCH
	SELECT N'Thêm thành công' AS Result
END


GO

CREATE PROCEDURE PROC_FindAllPackages
    @FilterType INT,
    @Content NVARCHAR(50)
AS
BEGIN
	IF (@FilterType = 0)
	BEGIN
		SELECT *
		FROM V_PackageList
		WHERE (
				ID = @Content
				OR [Name] LIKE N'%' + @Content + '%'
				OR [Description] LIKE N'%' + @Content + '%'
			) 
	END
	IF (@FilterType = 1)
	BEGIN
		SELECT *
		FROM V_PackageList
		WHERE (
				ID = @Content
				OR [Name] LIKE N'%' + @Content + '%'
				OR [Description] LIKE N'%' + @Content + '%'
			) AND (NumberOfPTSessions IS NOT NULL)
	END
	IF (@FilterType = 2)
	BEGIN
		SELECT *
		FROM V_PackageList
		WHERE (
				ID = @Content
				OR [Name] LIKE N'%' + @Content + '%'
				OR [Description] LIKE N'%' + @Content + '%'
			) AND (NumberOfPTSessions IS NULL)
	END
END

GO

CREATE PROCEDURE PROC_UpdatePackage
    @ID CHAR(6),
    @Name NVARCHAR(100),
    @Periods INT,
    @Price MONEY,
    @Description NTEXT,
    @NumberOfPTSessions INT
AS
BEGIN
    DECLARE @RowCount INT;

    -- Check if the ID exists in the Package table
    SELECT @RowCount = COUNT(*)
    FROM Package
    WHERE ID = @ID;
	IF @NumberOfPTSessions = 0
        BEGIN
            SET @NumberOfPTSessions = NULL;
        END
    IF @RowCount > 0
    BEGIN
        -- The ID exists, perform the update
        BEGIN TRY
            BEGIN TRANSACTION;

            UPDATE Package
            SET
                [Name] = @Name,
                Periods = @Periods,
                Price = @Price,
                [Description] = @Description,
                NumberOfPTSessions = @NumberOfPTSessions
            WHERE ID = @ID;

            COMMIT TRANSACTION;

            -- Return a success message or code if needed
            SELECT N'Cập nhật gói tập thành công' AS Result;
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION;
            THROW;
        END CATCH
    END
    ELSE
    BEGIN
        -- The ID does not exist, return an error message or code
        SELECT N'Package với ID ' + @ID + N' không tồn tại' AS Result;
    END
END
GO

CREATE FUNCTION FUNC_CheckPackageMembers
(
    @PackageID CHAR(6)
)
RETURNS BIT
AS
BEGIN
    DECLARE @HasMembers BIT = 0;

    -- Check if there are any members registered for the package
    IF EXISTS (SELECT 1 FROM Member WHERE PackageID = @PackageID)
    BEGIN
        SET @HasMembers = 1;
    END

    RETURN @HasMembers;
END
GO
CREATE PROCEDURE PROC_DeletePackage @ID CHAR(6)
AS
BEGIN
	IF (dbo.FUNC_CheckPackageMembers(@ID) = 1)
	BEGIN
		 SELECT N'Gói tập vẫn còn lượt sử dụng ' AS Result;
	END
	ELSE
	BEGIN
		DELETE Package WHERE ID = @ID
		 SELECT N'Xóa thành công' AS Result;
	END
END

GO


INSERT INTO Employee(ID,Name,Password,UserName,BranchID,Role) VALUES('Admin0','admin','admin', 'admin', 'BRRoot', '1')

INSERT INTO Employee(ID,Name,Password,UserName,BranchID,Role) VALUES('mg0001','manager','manager', 'manager1', 'BR0001', '2')
INSERT INTO Employee(ID,Name,Password,UserName,BranchID,Role) VALUES('mg0002','manager','manager', 'manager2', 'BR0002', '2')

INSERT INTO Employee(ID,Name,Password,UserName,BranchID,Role) VALUES('st0001','employee','employee', 'employee1', 'BR0001', '0')
INSERT INTO Employee(ID,Name,Password,UserName,BranchID,Role) VALUES('st0002','employee','employee', 'employee2', 'BR0002', '0')