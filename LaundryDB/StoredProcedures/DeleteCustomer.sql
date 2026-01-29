CREATE PROCEDURE DeleteCustomer
    @CustomerId INT
AS
BEGIN
    DELETE FROM Customers
    WHERE CustomerId = @CustomerId;
END
