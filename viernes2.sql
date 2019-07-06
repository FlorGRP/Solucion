select distinct country as Pais
from Customers
order by Pais


--5 productos mas caros
select top 36 with ties productname, unitprice
from products
order by unitprice desc