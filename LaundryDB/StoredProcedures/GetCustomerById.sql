CREATE PROCEDURE GetCustomerById
    @CustomerId INT
AS
BEGIN
    SELECT * FROM Customers
    WHERE CustomerId = @CustomerId;
END
