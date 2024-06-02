INSERT INTO "Customer"("PIN","FirstName","LastName","Email","Password")
VALUES
	('12345678912','Filip','Leskovic','filipleskovic@gmail.com','filip123'),
	('12345678913','Sven','Radic','svenradic@gmail.com','sven1234');

INSERT INTO "Category"("Id","Name","Description")
VALUES
	(DEFAULT,'T-shirt','Great t-shirt'),
	(DEFAULT,'Jeans','Great Jeans');

INSERT INTO "Producer"("Id","Name","Address","Description")
VALUES
	(DEFAULT,'Nike','Brace Radica 1','Sport design'),
	(DEFAULT,'Hugo Boss','Brace Radica 2','Best quality');

INSERT INTO "Product"("Id","ProducerId","CategoryId","ProductName","Description")
VALUES
	(DEFAULT,5,3,'Nike Swoosh t-shirt','The best t-shirt!'),
	(DEFAULT,6,3,'BOSS YELLOW','Hugo yellow t-shirt'),
	(DEFAULT,6,4,'BOSS BLACK','Hugo black jeans');

INSERT INTO "Delivery"("Id","Address","City")
VALUES
	(DEFAULT,'Brace Radica 3','Osijek'),
	(DEFAULT,'Brace Radica 4','Osijek'),
	(DEFAULT,'Brace Radica 3','Zagreb');

INSERT INTO "Bill" ("Id","CustomerPIN","DateTimeCreated","DeliveryId")
VALUES
	(DEFAULT,'12345678912',DATE '2024-06-01',7),
	(DEFAULT,'12345678913',DATE '2024-06-01',8);
	
INSERT INTO "Article" ("Id","ProductId","Size","Price","Quantity")	
VALUES
	(DEFAULT,10,'M',30,40),
	(DEFAULT,11,'S',55.0,12);

INSERT INTO "ArticleBill" ("Id","ArticleId","BillId","Quantity","ArticlePrice")
VALUES
	(DEFAULT,7,3,1,30),
	(DEFAULT,8,4,2,60.5);