CREATE TABLE "Customer"(
	"PIN" CHAR(11) PRIMARY KEY NOT NULL,
	"FirstName" VARCHAR(255) NOT NULL,
	"LastName" VARCHAR(255) NOT NULL,
	"Email" VARCHAR(255) NOT NULL,
	"Password" VARCHAR (255) NOT NULL
);
CREATE TABLE "Delivery"(
	"Id" SERIAL PRIMARY KEY,
	"Address" VARCHAR (255),
	"City" VARCHAR (255)
);
CREATE TABLE "CustomerDelivery"(
	"Id" SERIAL PRIMARY KEY,
	"CustomerPIN" CHAR(11) NOT NULL,
	"DeliveryId" INT NOT NULL,
	CONSTRAINT "FK_CustomerDelivery_Customer_CustomerPIN" 
		FOREIGN KEY("CustomerPIN")
		REFERENCES  "Customer"("PIN")
		ON DELETE CASCADE,

	CONSTRAINT "FK_CustomerDelivery_Delivery_DeliveryId" 
		FOREIGN KEY("DeliveryId")
		REFERENCES  "Delivery"("Id")
		ON DELETE CASCADE
);
CREATE TABLE "Producer"(
	"Id" SERIAL PRIMARY KEY,
	"Name" VARCHAR (255) NOT NULL,
	"Address" VARCHAR (255) NOT NULL,
	"Description" VARCHAR (255) NOT NULL
);
CREATE TABLE "Category"(
	"Id" SERIAL PRIMARY KEY,
	"Name" VARCHAR (255) NOT NULL,
	"Description" VARCHAR (255) NOT NULL
);
CREATE TABLE "Product"(
	"Id" Serial PRIMARY KEY,
	"ProducerId" int NOT NULL ,
	"CategoryId" int NOT NULL,
	CONSTRAINT "FK_Product_Producer_ProducerId"
		FOREIGN KEY ("ProducerId")
		REFERENCES "Producer"("Id")
		ON DELETE CASCADE,

	CONSTRAINT "FK_Product_Category_CategoryId"
		FOREIGN KEY ("CategoryId")
		REFERENCES "Category"("Id")
		ON DELETE CASCADE,

	"ProductName" VARCHAR (255) NOT NULL,
	"Description" varchar (511) 
);
CREATE TABLE "Article"(
	"Id" SERIAL PRIMARY KEY,
	"ProductId" int NOT NULL,
	CONSTRAINT "FK_Article_Product_ProductId"
		FOREIGN KEY ("ProductId")
		REFERENCES "Product"("Id")
		ON DELETE CASCADE,

	"Size" VARCHAR(255) NOT NULL,
	"Price" DECIMAL NOT NULL,
	"Quantity" INT
);
CREATE TABLE "Bill"(
	"Id" SERIAL PRIMARY KEY,
	"CustomerPIN" CHAR(11) NOT NULL,
	CONSTRAINT "FK_Bill_Customer_CustomerPIN"
		FOREIGN KEY ("CustomerPIN")
		REFERENCES "Customer"("PIN")
		ON DELETE CASCADE,
	"DateTimeCreated" Date NOT NULL,
	"DeliveryId" int NOT NULL,
	CONSTRAINT "FK_Bill_Delivery_DeliveryId"
		FOREIGN KEY ("DeliveryId")
		REFERENCES "Delivery"("Id")
		ON DELETE CASCADE
);
CREATE TABLE "ArticleBill"(
	"Id" SERIAL PRIMARY KEY,
	"ArticleId" INT NOT NULL, 
	"BillId" INT NOT NULL,
	CONSTRAINT "FK_ArticleBill_Article_ArticleId"
		FOREIGN KEY ("ArticleId")
		REFERENCES "Article"("Id")
		ON DELETE CASCADE,
	CONSTRAINT "FK_Article_Bill_BillId"
		FOREIGN KEY ("BillId")
		REFERENCES "Bill"("Id")
		ON DELETE CASCADE,
	"Quantity" INT NOT NULL,
	"ArticlePrice" decimal NOT NULL
);
CREATE TABLE "Review"(
	"Id" SERIAL PRIMARY KEY,
	"CustomerPIN" char(11) NOT NULL,
	CONSTRAINT "FK_Review_Customer_CustomerPIN"
		FOREIGN KEY ("CustomerPIN")
		REFERENCES "Customer"("PIN")
		ON DELETE CASCADE,
	"ArticleId" int NOT NULL,
	CONSTRAINT "FK_Review_Article_ArticleId"
		FOREIGN KEY ("ArticleId")
		REFERENCES "Article"("Id")
		ON DELETE CASCADE,
	"Grade" INT NOT NULL
);