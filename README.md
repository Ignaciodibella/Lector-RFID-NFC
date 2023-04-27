# Lector-RFID-NFC

El sistema lee una tarjeta apoyada en el sensor, leyendo su UID. Si el UID coincide con el UID harcodeado, se enciende un led verde y suena un buzzer (agudo).
<br> En caso de que la tarjeta apoyada en el sensor no tenga el UID esperado enciende un led rojo y suena el buzzer (mas grave) indicando el rechazo de la tarjeta.

#### Conexiones implementadas para la versión V2-3
![conexiones arduino](https://raw.githubusercontent.com/Ignaciodibella/Lector-RFID-NFC/main/recursos/RFID-V2-3.png)

Pines en orden (de arriba a bajo) de la placa RC522:

|PIN RC522 | PIN Arduino UNO R3|
|----------|-------------------|
|SDA(SS)   |~10                |
|SCK       |13                 |
|MOSI      |~11                |
|MISO      |12                 |
|IRQ       |Sin conectar       |
|GND       |GND                |
|RST       |~9                 |
|3.3v      |3.3v               |



#### Mejoras a implementar:
- [x] Armar BD con Usuarios (dni, nombre, apellido, UDI asociado, saldo, activa[bool]) y Productos (id, nombre, precio unitario y stock).
      <br>Ver archivo dummy_bd_rfid_test.sql
- [ ] Armar un backend simple que se conecte a la BD.
- [x] Conectar backend con lector rfid.
- [ ] Probar verificación con últimos 3 dígitos del dni.
- [ ] Cargar Saldo.
- [ ] Comprar Producto (descuenta saldo usuario y descuenta stock producto) -> Agregar validaciones necesarias (saldo/stock insuficiente)
- [ ] Anular Tarjeta (apaga el bit del atributo "activa" de un usuario) -> El saldo no se toca ya que queda asociado al usuario, luego se le asigna otro UID.
