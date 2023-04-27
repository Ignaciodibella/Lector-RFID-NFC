# Lector-RFID-NFC

El sistema lee una tarjeta apoyada en el sensor, leyendo su UID. Si el UID coincide con el UID harcodeado, se enciende un led verde y suena un buzzer (agudo).
<br> En caso de que la tarjeta apoyada en el sensor no tenga el UID esperado enciende un led rojo y suena el buzzer (mas grave) indicando el rechazo de la tarjeta.

Ver el archivo conexiones.md donde se muestra el circuito a seguir para que funcione el código implementado.
<br><br> ⚠️Es necesario descargar e instalar la libreria rfid-master cargada en la carpeta "recursos" de este repositorio.⚠️

### Mejoras a implementar:
Se deberia implementar una base de datos con una tabla clientes (los dueños de las tarjetas) que incluya su nombre, apellido, UID asociado a su tarjeta, saldo y número de dni
para poder hacer una validación de identidad. El cliente deberá ingresar por pantalla los últimos 3 dígitos de su dni. El atributo saldo almacenará el saldo cargado, del
cual se irá descontando con cada compra de algún producto o entrada.
Se debe tener una tabla de artículos con su nombre y precio unitario para poder simular una compra.
