SELECT * from "Customer";
SELECT * from "Producer";
SELECT * from "Product";
SELECT * from "Article";
SELECT * from "Bill";
SELECT * from "ArticleBill";
SELECT * from "Delivery";
SELECT * from "Category";

SELECT 
	cu."FirstName" as "FirstName",
	cu."LastName" as "LastName",
	b."DateTimeCreated" as "Created",
	ab."ArticlePrice" as "Price",
	a."Size" as "Size",
	p."ProductName" as "Name"
	FROM
	"Customer" cu
	INNER JOIN
	"Bill" b
	ON
	b."CustomerPIN"=cu."PIN"
	INNER JOIN
	"ArticleBill" ab
	ON
	ab."BillId"=b."Id"
	INNER JOIN
	"Article" a
	on
	a."Id"=ab."ArticleId"
	INNER JOIN
	"Product" p
	on
	p."Id"=a."ProductId"



	
	