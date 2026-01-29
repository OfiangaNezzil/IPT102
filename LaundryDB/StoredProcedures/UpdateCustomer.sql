CREATE PROCEDURE UpdateCustomer
    @CustomerId INT,
    @CustomerName NVARCHAR(100),
    @LaundryDate DATE
AS
BEGIN
    UPDATE Customers
    SET CustomerName = @CustomerName,
        LaundryDate = @LaundryDate
    WHERE CustomerId = @CustomerId;
END
