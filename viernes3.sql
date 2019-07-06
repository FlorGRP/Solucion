/*Mostrar un ranking de los primeros 10 productos(los nombres y cantidad de unidades) mas pedidos en 1997,
ordenados descendientemente por cantidad de unidades*/

select top 10 p.ProductName, sum(od.Quantity) as Unidades

from orders as o
inner join [Order Details] as od on od.OrderID=o.OrderID
inner join Products as p on p.ProductID=od.ProductID
where year( o.OrderDate)=1997
group by p.ProductName
order by Unidades desc