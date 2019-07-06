/*Mostrar datos de los pedidos(Orders)
ID de pedido(orderid)
fecha del pedido(orderdate)
Empleado(lastname y firstname)
Cliente(CompanyName)
Importe del flete(Freight) */

/*Tablas
Orders Employees Customers*/

/*ALTER  AUTHORIZATION ON DATABASE::NORTHWIND TO SA*/

Select 
o.OrderID as IDPedido,
o.OrderDate as Fecha,
e.Lastname+', '+e.FirstName as Empleado,
c.CompanyName as Cliente,
o.Freight as ImporteFlete
from Orders as o
inner join Customers as c on o.CustomerID=c.CustomerID
inner join Employees as e on e.EmployeeID=O.EmployeeID


/*Funciones de agregado/escalares
Count:Cuenta filas/registros con contenido no nulo*/
select count(CustomerID) as Total
from Customers
where Country='Argentina'

/*Sum=Suma contenido de campos numericos
Cantidad en stock de bebidas*/

select sum(p.UnitsInStock)
from Products as p
inner join categories as c on c.CategoryID=p.CategoryID
where c.CategoryName='Beverages'

/*Max:Devuelve el valor maximo de un campo numerico
Precio mas caro del proveedor*/

select max(UnitPrice) as PrecioMasCaro
from Products 
where SupplierID=2

/*Min:Devuelve el valor minimo de un campo numerico
Precio mas barato del proveedor*/

select min(UnitPrice) as PrecioMasBarato
from Products 
where SupplierID=2

/*avg:Promedio de valores numericos
Promedio de precios del proveedor 2*/

select avg(unitPrice) as Promedio
from products
where SupplierID=2

Select
count(*) as Cantidad,
sum(unitPrice) as Stock,
max(unitprice) as 'PrecioMayor',
min(unitprice) as 'PrecioMin',
avg(unitprice) as Promedio
from Products
where (SupplierID=2)


/*Mostrar la cantidad de stock de la categoria 3*/
select sum(UnitsinStock) as Stock
from products
where CategoryID=3

/*Mostrar la cantidad de stock por categoria*/
select CategoryID,sum(UnitsinStock) as Stock
from products
group by CategoryID
having sum(UnitsInStock)<=200
order by Stock
