
SELECT 
    E.nombreEmpleado,
    DATE_FORMAT(N.FechaPago, '%Y-%m') AS mes,  
    N.Pagado AS total_cobrado
FROM 
    Empleado E
JOIN 
    Nomina N ON E.idEmpleado = N.idEmpleado
WHERE 
    YEAR(N.FechaPago) = 2021  -- Filtramos el año
    AND N.Pagado > 2000       -- Filtramos la cantidad cobrada
 