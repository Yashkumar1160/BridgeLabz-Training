--Create HealthClinic Database
CREATE DATABASE HealthClinic;

--Use HealthClinic Database

USE HealthClinic;


--Create Specialties Table
CREATE TABLE specialties (
    specialty_id INT IDENTITY(1,1) PRIMARY KEY,
    specialty_name VARCHAR(50) NOT NULL UNIQUE
);

--insert sample data
INSERT INTO specialties (specialty_name) VALUES
('Cardiology'),
('Dentist'),
('Neurology'),
('Orthopedic');


--Create Patients Table
CREATE TABLE patients (
    patient_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    dob DATE NOT NULL,
    phone VARCHAR(15) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    address VARCHAR(255),
    blood_group VARCHAR(5)
);

--Create Doctors Table
CREATE TABLE doctors (
    doctor_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    specialty_id INT NOT NULL,
    contact VARCHAR(15),
    consultation_fee DECIMAL(10,2),
    is_active BIT DEFAULT 1,
    CONSTRAINT fk_doctor_specialty
        FOREIGN KEY (specialty_id)
        REFERENCES specialties(specialty_id)
);

--Create Appointments Table
CREATE TABLE appointments (
    appointment_id INT IDENTITY(1,1) PRIMARY KEY,
    patient_id INT NOT NULL,
    doctor_id INT NOT NULL,
    appointment_date DATE NOT NULL,
    appointment_time TIME NOT NULL,
    status VARCHAR(20) NOT NULL,
    CONSTRAINT fk_appointment_patient
        FOREIGN KEY (patient_id)
        REFERENCES patients(patient_id),
    CONSTRAINT fk_appointment_doctor
        FOREIGN KEY (doctor_id)
        REFERENCES doctors(doctor_id)
);

--add constraint
ALTER TABLE appointments
ADD CONSTRAINT chk_appointment_status
CHECK (status IN ('SCHEDULED', 'CANCELLED', 'COMPLETED'));

--Create Visits Table
CREATE TABLE visits (
    visit_id INT IDENTITY(1,1) PRIMARY KEY,
    appointment_id INT NOT NULL,
    patient_id INT NOT NULL,
    doctor_id INT NOT NULL,
    diagnosis VARCHAR(255),
    notes VARCHAR(255),
    CONSTRAINT fk_visit_appointment
        FOREIGN KEY (appointment_id)
        REFERENCES appointments(appointment_id),
    CONSTRAINT fk_visit_patient
        FOREIGN KEY (patient_id)
        REFERENCES patients(patient_id),
    CONSTRAINT fk_visit_doctor
        FOREIGN KEY (doctor_id)
        REFERENCES doctors(doctor_id)
);

--Create Prescriptions Table
CREATE TABLE prescriptions (
    prescription_id INT IDENTITY(1,1) PRIMARY KEY,
    visit_id INT NOT NULL,
    medicine_name VARCHAR(100) NOT NULL,
    dosage VARCHAR(50),
    duration VARCHAR(50),
    CONSTRAINT fk_prescription_visit
        FOREIGN KEY (visit_id)
        REFERENCES visits(visit_id)
);

--Create Bills Table
CREATE TABLE bills (
    bill_id INT IDENTITY(1,1) PRIMARY KEY,
    visit_id INT NOT NULL,
    total_amount DECIMAL(10,2) NOT NULL,
    payment_status VARCHAR(20) NOT NULL,
    CONSTRAINT fk_bill_visit
        FOREIGN KEY (visit_id)
        REFERENCES visits(visit_id)
);

--add constraint
ALTER TABLE bills
ADD CONSTRAINT chk_payment_status
CHECK (payment_status IN ('PAID', 'UNPAID'));


--Create Payment_Transactions Table
CREATE TABLE payment_transactions (
    payment_id INT IDENTITY(1,1) PRIMARY KEY,
    bill_id INT NOT NULL,
    payment_date DATE NOT NULL,
    payment_mode VARCHAR(20),
    CONSTRAINT fk_payment_bill
        FOREIGN KEY (bill_id)
        REFERENCES bills(bill_id)
);


--Create Appoint_Audit Table
CREATE TABLE appointment_audit (
    audit_id INT IDENTITY(1,1) PRIMARY KEY,
    appointment_id INT NOT NULL,
    action VARCHAR(50),
    action_date DATETIME DEFAULT GETDATE(),
    CONSTRAINT fk_audit_appointment
        FOREIGN KEY (appointment_id)
        REFERENCES appointments(appointment_id)
);

--Create Users Table
CREATE TABLE users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    role VARCHAR(20) NOT NULL
);


--UC-1.1->Register New Patient
--GO marks start of new batch
GO
CREATE OR ALTER PROCEDURE Register_Patient
    @name VARCHAR(100), @dob DATE, @phone VARCHAR(15),
    @email VARCHAR(100), @address VARCHAR(255), @blood_group VARCHAR(10)
AS
BEGIN
--Validation to check if patient already exists
IF EXISTS(SELECT 1 FROM patients WHERE phone=@phone OR email=@email)
    BEGIN
        RAISERROR ('Patient with same phone or email already exists', 16, 1);
        RETURN;
    END
    --Insert patient details into table
    INSERT INTO patients(name,dob,phone,email,address,blood_group)
    VALUES(@name,@dob,@phone,@email,@address,@blood_group);
END;
--GO marks end of batch
GO


--UC-1.2->Update Patient Information
GO
CREATE OR ALTER PROCEDURE Update_Patient_Details
    @patient_id INT,
    @phone VARCHAR(15),
    @address VARCHAR(255)
AS
BEGIN

    IF NOT EXISTS (SELECT 1 FROM patients WHERE patient_id = @patient_id)
    BEGIN
        RAISERROR('Patient not found', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 FROM patients 
        WHERE phone = @phone AND patient_id <> @patient_id
    )
    BEGIN
        RAISERROR('Phone number already in use', 16, 1);
        RETURN;
    END

    UPDATE patients
    SET phone = @phone,
        address = @address
    WHERE patient_id = @patient_id;
END;
--GO marks end of batch
GO


--UC-1.3->Search Patient Records
GO
CREATE OR ALTER PROCEDURE SearchPatient
    @name VARCHAR(100) = NULL,
    @phone VARCHAR(15) = NULL,
    @patient_id INT = NULL
AS
BEGIN
    SELECT *
    FROM patients
    WHERE (@name IS NULL OR name LIKE '%' + @name + '%')
      AND (@phone IS NULL OR phone = @phone)
      AND (@patient_id IS NULL OR patient_id = @patient_id);
END;
GO

--UC-1.4->View Patient History
GO
CREATE OR ALTER PROCEDURE PatientVisitHistory
    @patient_id INT
AS
BEGIN

    SELECT 
        a.appointment_date,
        a.appointment_time,
        d.name AS doctor_name,
        v.diagnosis,
        v.notes
    FROM visits v
    INNER JOIN appointments a 
        ON v.appointment_id = a.appointment_id
    INNER JOIN doctors d 
        ON v.doctor_id = d.doctor_id
    WHERE v.patient_id = @patient_id
    ORDER BY a.appointment_date, a.appointment_time;
END;
GO

--UC-2.1->Add Doctor Profile
GO
CREATE OR ALTER PROCEDURE AddDoctor
    @name VARCHAR(100),
    @specialty_id INT,
    @contact VARCHAR(15),
    @consultation_fee DECIMAL(10,2)
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM specialties WHERE specialty_id = @specialty_id
    )
    BEGIN
        RAISERROR('Invalid specialty',16,1);
        RETURN;
    END

    INSERT INTO doctors (name, specialty_id, contact, consultation_fee, is_active)
    VALUES (@name, @specialty_id, @contact, @consultation_fee, 1);
END;
GO



--UC-2.2->Assign/Update Doctor Specialty
GO
CREATE OR ALTER PROCEDURE UpdateDoctorSpecialty
    @doctor_id INT,
    @specialty_id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM doctors WHERE doctor_id = @doctor_id)
    BEGIN
        RAISERROR('Doctor not found',16,1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM specialties WHERE specialty_id = @specialty_id)
    BEGIN
        RAISERROR('Specialty not found',16,1);
        RETURN;
    END

    UPDATE doctors
    SET specialty_id = @specialty_id
    WHERE doctor_id = @doctor_id;
END;
GO


--UC-2.3->View Doctors by Specialty
GO
CREATE OR ALTER PROCEDURE GetDoctorsBySpecialty
    @specialty_name VARCHAR(50)
AS
BEGIN
    SELECT 
        d.doctor_id,
        d.name,
        d.contact,
        d.consultation_fee
    FROM doctors d
    JOIN specialties s 
        ON d.specialty_id = s.specialty_id
    WHERE s.specialty_name = @specialty_name
      AND d.is_active = 1;
END;
GO


--UC-2.4->Deactivate Doctor Profile
GO
CREATE OR ALTER PROCEDURE DeactivateDoctor
    @doctor_id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM doctors WHERE doctor_id = @doctor_id)
    BEGIN
        RAISERROR('Doctor not found',16,1);
        RETURN;
    END

    UPDATE doctors
    SET is_active = 0
    WHERE doctor_id = @doctor_id;
END;
GO



--UC-3.1->Book New Appointment
GO
CREATE OR ALTER PROCEDURE BookAppointment
    @patient_id INT,
    @doctor_id INT,
    @appointment_date DATE,
    @appointment_time TIME
AS
BEGIN

    -- Validate patient
    IF NOT EXISTS (SELECT 1 FROM patients WHERE patient_id = @patient_id)
    BEGIN
        RAISERROR('Patient not found', 16, 1);
        RETURN;
    END

    -- Validate doctor
    IF NOT EXISTS (SELECT 1 FROM doctors WHERE doctor_id = @doctor_id AND is_active = 1)
    BEGIN
        RAISERROR('Doctor not available', 16, 1);
        RETURN;
    END

    -- Check slot availability
    IF EXISTS (
        SELECT 1 FROM appointments
        WHERE doctor_id = @doctor_id
          AND appointment_date = @appointment_date
          AND appointment_time = @appointment_time
          AND status = 'SCHEDULED'
    )
    BEGIN
        RAISERROR('Appointment slot already booked', 16, 1);
        RETURN;
    END

    INSERT INTO appointments (
        patient_id, doctor_id, appointment_date, appointment_time, status
    )
    VALUES (
        @patient_id, @doctor_id, @appointment_date, @appointment_time, 'SCHEDULED'
    );
END;
GO

--UC-3.2->Check Doctor Availability
GO
CREATE OR ALTER PROCEDURE CheckDoctorAvailability
    @doctor_id INT,
    @appointment_date DATE
AS
BEGIN

    SELECT 
        appointment_time,
        COUNT(*) AS booked_count
    FROM appointments
    WHERE doctor_id = @doctor_id
      AND appointment_date = @appointment_date
      AND status = 'SCHEDULED'
    GROUP BY appointment_time
    ORDER BY appointment_time;
END;
GO


--UC-3.3->Cancel Appointment
GO
CREATE OR ALTER PROCEDURE CancelAppointment
    @appointment_id INT
AS
BEGIN

    BEGIN TRANSACTION;

    IF NOT EXISTS (
        SELECT 1 FROM appointments 
        WHERE appointment_id = @appointment_id
          AND status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        RAISERROR('Appointment not found or already cancelled', 16, 1);
        RETURN;
    END

    UPDATE appointments
    SET status = 'CANCELLED'
    WHERE appointment_id = @appointment_id;

    COMMIT;
END;
GO


--UC-3.4->Reschedule Appointment
GO
CREATE OR ALTER PROCEDURE RescheduleAppointment
    @appointment_id INT,
    @new_doctor_id INT,
    @new_date DATE,
    @new_time TIME
AS
BEGIN
    BEGIN TRANSACTION;

    -- Check appointment exists and is scheduled
    IF NOT EXISTS (
        SELECT 1 FROM appointments 
        WHERE appointment_id = @appointment_id
          AND status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        RAISERROR('Appointment not found', 16, 1);
        RETURN;
    END

    -- Ensure new doctor is active
    IF NOT EXISTS (
        SELECT 1 FROM doctors
        WHERE doctor_id = @new_doctor_id
          AND is_active = 1
    )
    BEGIN
        ROLLBACK;
        RAISERROR('New doctor is not active', 16, 1);
        RETURN;
    END

    -- Check new slot availability
    IF EXISTS (
        SELECT 1 FROM appointments
        WHERE doctor_id = @new_doctor_id
          AND appointment_date = @new_date
          AND appointment_time = @new_time
          AND status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        RAISERROR('New slot already booked', 16, 1);
        RETURN;
    END

    UPDATE appointments
    SET doctor_id = @new_doctor_id,
        appointment_date = @new_date,
        appointment_time = @new_time
    WHERE appointment_id = @appointment_id;

    COMMIT;
END;
GO


--UC-3.5->View Daily Appointment Schedule
GO
CREATE OR ALTER PROCEDURE ViewDailyAppointments
    @appointment_date DATE
AS
BEGIN

    SELECT 
        a.appointment_time,
        p.name AS patient_name,
        d.name AS doctor_name,
        a.status
    FROM appointments a
    JOIN patients p ON a.patient_id = p.patient_id
    JOIN doctors d ON a.doctor_id = d.doctor_id
    WHERE a.appointment_date = @appointment_date
    ORDER BY a.appointment_time;
END;
GO


--UC-4.1->Record Patient Visit
GO
CREATE OR ALTER PROCEDURE RecordPatientVisit
    @appointment_id INT,
    @patient_id INT,
    @doctor_id INT,
    @diagnosis VARCHAR(255),
    @notes VARCHAR(255)
AS
BEGIN
    BEGIN TRANSACTION;

    -- Check appointment exists and is scheduled
    IF NOT EXISTS (
        SELECT 1 FROM appointments
        WHERE appointment_id = @appointment_id
          AND status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        RAISERROR('Appointment not found or already completed', 16, 1);
        RETURN;
    END

    -- Ensure appointment belongs to given patient and doctor
    IF NOT EXISTS (
        SELECT 1 FROM appointments
        WHERE appointment_id = @appointment_id
          AND patient_id = @patient_id
          AND doctor_id = @doctor_id
    )
    BEGIN
        ROLLBACK;
        RAISERROR('Patient or Doctor does not match appointment', 16, 1);
        RETURN;
    END

    -- Prevent multiple visits for same appointment
    IF EXISTS (
        SELECT 1 FROM visits WHERE appointment_id = @appointment_id
    )
    BEGIN
        ROLLBACK;
        RAISERROR('Visit already recorded for this appointment', 16, 1);
        RETURN;
    END

    -- Insert visit record
    INSERT INTO visits (
        appointment_id,
        patient_id,
        doctor_id,
        diagnosis,
        notes
    )
    VALUES (
        @appointment_id,
        @patient_id,
        @doctor_id,
        @diagnosis,
        @notes
    );

    COMMIT;
END;
GO


--UC-4.2->View Patient Medical History
GO
CREATE OR ALTER PROCEDURE ViewPatientMedicalHistory
    @patient_id INT
AS
BEGIN
    SELECT 
        a.appointment_date,
        d.name AS doctor_name,
        v.diagnosis,
        v.notes,
        pr.medicine_name,
        pr.dosage,
        pr.duration
    FROM visits v
    JOIN appointments a 
        ON v.appointment_id = a.appointment_id
    JOIN doctors d 
        ON v.doctor_id = d.doctor_id
    LEFT JOIN prescriptions pr 
        ON v.visit_id = pr.visit_id
    WHERE v.patient_id = @patient_id
    ORDER BY a.appointment_date DESC;
END;
GO


--UC-4.3->Add Prescription Details
GO
CREATE OR ALTER PROCEDURE AddPrescription
    @visit_id INT,
    @medicine_name VARCHAR(100),
    @dosage VARCHAR(50),
    @duration VARCHAR(50)
AS
BEGIN
    -- Validate visit
    IF NOT EXISTS (
        SELECT 1 FROM visits WHERE visit_id = @visit_id
    )
    BEGIN
        RAISERROR('Visit not found', 16, 1);
        RETURN;
    END

    INSERT INTO prescriptions (
        visit_id,
        medicine_name,
        dosage,
        duration
    )
    VALUES (
        @visit_id,
        @medicine_name,
        @dosage,
        @duration
    );
END;
GO


--UC-5.1->Generate Bill for Visit
GO
CREATE OR ALTER PROCEDURE GenerateBillForVisit
    @visit_id INT
AS
BEGIN
    DECLARE @doctor_fee DECIMAL(10,2);

    -- Validate visit
    IF NOT EXISTS (
        SELECT 1 FROM visits WHERE visit_id = @visit_id
    )
    BEGIN
        RAISERROR('Visit not found', 16, 1);
        RETURN;
    END

    -- Prevent duplicate bill
    IF EXISTS (
        SELECT 1 FROM bills WHERE visit_id = @visit_id
    )
    BEGIN
        RAISERROR('Bill already generated for this visit', 16, 1);
        RETURN;
    END

    -- Get doctor consultation fee
    SELECT @doctor_fee = d.consultation_fee
    FROM visits v
    JOIN doctors d ON v.doctor_id = d.doctor_id
    WHERE v.visit_id = @visit_id;

    -- Insert bill
    INSERT INTO bills (visit_id, total_amount, payment_status)
    VALUES (@visit_id, @doctor_fee, 'UNPAID');
END;
GO


--UC-5.2->Record Payment
GO
CREATE OR ALTER PROCEDURE RecordPayment
    @bill_id INT,
    @payment_mode VARCHAR(20)
AS
BEGIN
    BEGIN TRANSACTION;

    -- Validate bill
    IF NOT EXISTS (
        SELECT 1 FROM bills 
        WHERE bill_id = @bill_id AND payment_status = 'UNPAID'
    )
    BEGIN
        ROLLBACK;
        RAISERROR('Bill not found or already paid', 16, 1);
        RETURN;
    END

    -- Update bill status
    UPDATE bills
    SET payment_status = 'PAID'
    WHERE bill_id = @bill_id;

    -- Insert payment transaction
    INSERT INTO payment_transactions (bill_id, payment_date, payment_mode)
    VALUES (@bill_id, GETDATE(), @payment_mode);

    COMMIT;
END;
GO

--UC-5.3->View Outstanding Bills
GO
CREATE OR ALTER PROCEDURE ViewOutstandingBills
AS
BEGIN
    SELECT 
        p.patient_id,
        p.name AS patient_name,
        COUNT(b.bill_id) AS total_bills,
        SUM(b.total_amount) AS outstanding_amount
    FROM bills b
    JOIN visits v ON b.visit_id = v.visit_id
    JOIN patients p ON v.patient_id = p.patient_id
    WHERE b.payment_status = 'UNPAID'
    GROUP BY p.patient_id, p.name;
END;
GO

--UC-5.4->Generate Revenue Report
GO
CREATE OR ALTER PROCEDURE GenerateRevenueReport
    @from_date DATE,
    @to_date DATE,
    @min_revenue DECIMAL(10,2)
AS
BEGIN
    SELECT 
        CAST(pt.payment_date AS DATE) AS revenue_date,
        d.name AS doctor_name,
        s.specialty_name,
        SUM(b.total_amount) AS total_revenue
    FROM payment_transactions pt
    JOIN bills b ON pt.bill_id = b.bill_id
    JOIN visits v ON b.visit_id = v.visit_id
    JOIN doctors d ON v.doctor_id = d.doctor_id
    JOIN specialties s ON d.specialty_id = s.specialty_id
    WHERE pt.payment_date BETWEEN @from_date AND @to_date
    GROUP BY 
        CAST(pt.payment_date AS DATE),
        d.name,
        s.specialty_name
    HAVING SUM(b.total_amount) >= @min_revenue
    ORDER BY revenue_date;
END;
GO


--UC-6.1->Manage Specialty Lookup
--Add Specialty
GO
CREATE OR ALTER PROCEDURE AddSpecialty
    @specialty_name VARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM specialties WHERE specialty_name = @specialty_name)
    BEGIN
        RAISERROR('Specialty already exists', 16, 1);
        RETURN;
    END

    INSERT INTO specialties (specialty_name)
    VALUES (@specialty_name);
END;
GO

--Update Specialty
GO
CREATE OR ALTER PROCEDURE UpdateSpecialty
    @specialty_id INT,
    @specialty_name VARCHAR(50)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM specialties WHERE specialty_id = @specialty_id)
    BEGIN
        RAISERROR('Specialty not found', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 FROM specialties
        WHERE specialty_name = @specialty_name
          AND specialty_id <> @specialty_id
    )
    BEGIN
        RAISERROR('Specialty name already exists',16,1);
        RETURN;
    END

    UPDATE specialties
    SET specialty_name = @specialty_name
    WHERE specialty_id = @specialty_id;
END;
GO


--View All Specialty
GO
CREATE OR ALTER PROCEDURE GetAllSpecialties
AS
BEGIN
    SELECT specialty_id, specialty_name
    FROM specialties
    ORDER BY specialty_name;
END;
GO


--Delete Specialty
GO
CREATE OR ALTER PROCEDURE DeleteSpecialty
    @specialty_id INT
AS
BEGIN
    DECLARE @doctorCount INT;

    -- Check specialty exists
    IF NOT EXISTS (
        SELECT 1 FROM specialties WHERE specialty_id = @specialty_id
    )
    BEGIN
        RAISERROR('Specialty not found', 16, 1);
        RETURN;
    END

    -- Check if doctors are assigned
    SELECT @doctorCount = COUNT(*)
    FROM doctors
    WHERE specialty_id = @specialty_id;

    IF @doctorCount > 0
    BEGIN
        RAISERROR('Cannot delete specialty. Doctors are assigned to it.', 16, 1);
        RETURN;
    END

    DELETE FROM specialties
    WHERE specialty_id = @specialty_id;
END;
GO



/* Appointment audit trigger */
GO
CREATE OR ALTER TRIGGER trg_AppointmentAudit
ON appointments
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- INSERT
    INSERT INTO appointment_audit (appointment_id, action)
    SELECT i.appointment_id, 'INSERTED'
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1 FROM deleted d 
        WHERE d.appointment_id = i.appointment_id
    );

    -- UPDATE
    INSERT INTO appointment_audit (appointment_id, action)
    SELECT i.appointment_id, 'UPDATED'
    FROM inserted i
    JOIN deleted d
        ON i.appointment_id = d.appointment_id;

    -- DELETE
    INSERT INTO appointment_audit (appointment_id, action)
    SELECT d.appointment_id, 'DELETED'
    FROM deleted d
    WHERE NOT EXISTS (
        SELECT 1 FROM inserted i 
        WHERE i.appointment_id = d.appointment_id
    );

END;
GO




/* Visit complete trigger */
GO
CREATE OR ALTER TRIGGER trg_VisitAutoComplete
ON visits
AFTER INSERT
AS
BEGIN
    UPDATE a
    SET status = 'COMPLETED'
    FROM appointments a
    JOIN inserted i
        ON a.appointment_id = i.appointment_id
    WHERE a.status = 'SCHEDULED';
END;
GO



/* Prevent doctor deletion trigger */
GO
CREATE OR ALTER TRIGGER trg_PreventDoctorDelete
ON doctors
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM appointments a
        JOIN deleted d ON a.doctor_id = d.doctor_id
        WHERE a.status = 'SCHEDULED'
    )
    BEGIN
        RAISERROR('Doctor has scheduled appointments. Cannot delete.',16,1);
        RETURN;
    END

    DELETE FROM doctors
    WHERE doctor_id IN (SELECT doctor_id FROM deleted);
END;
GO
