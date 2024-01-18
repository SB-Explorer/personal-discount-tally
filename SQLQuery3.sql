CREATE TABLE STOCK
( ProductId INT PRIMARY KEY,
  ProductName VARCHAR(255) NOT NULL,
  OriginalPrice DECIMAL(10,2) NOT NULL,
  DiscountPercentage DECIMAL(5,2) NOT NULL,
  DiscountPrice DECIMAL(10,2) NOT NULL,
  FinalPrice DECIMAL(10,2) NOT NULL
  );

  SELECT*FROM STOCK
  INSERT INTO STOCK (ProductId,ProductName,OriginalPrice,DiscountPercentage,DiscountPrice,FinalPrice) VALUES ('1','Kitchen Scale','2990.00','40','1199.00','1791.00')
  INSERT INTO STOCK (ProductId,ProductName,OriginalPrice,DiscountPercentage,DiscountPrice,FinalPrice) VALUES  ('2','Electric Oven','13990','50','7000','6990')
 