CREATE PROCEDURE CreateCustomer
    @CustomerName NVARCHAR(100),
    @LaundryDate DATE
AS
BEGIN
    INSERT INTO Customers (CustomerName, LaundryDate)
    VALUES (@CustomerName, @LaundryDate);
END
