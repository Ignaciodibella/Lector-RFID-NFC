/*
Lector RFID.
V2.3
Incluye: 
 - Sonido de aceptación o rechazo de tarjeta 
 - Luz indicativa (verde/roja) según concoordancia con el UDI harcodeado como aceptado.

*/

#include <SPI.h>
#include <MFRC522.h>

//Asignación de Pines:
#define RST_PIN 9
#define SS_PIN 10
MFRC522 mfrc522(SS_PIN, RST_PIN);  //Creación de Objeto RC522.

const int buzzer = 3;
const int led_verde = 6;
const int led_rojo = 5;

String uid = "";                  //String para almacenar UID.
String uid_aceptado = "620b265";  //Harcodeado, la idea es que este dato venga de la BD en la próxima versión.

void setup() {
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  Serial.println("Lectura del UID");
  pinMode(buzzer, OUTPUT);
  pinMode(led_verde, OUTPUT);
  pinMode(led_rojo, OUTPUT);
}

void loop() {
  //Buscar tarjetas apoyadas:
  if (mfrc522.PICC_IsNewCardPresent()) {
    //Seleccionamos la tarjeta
    if (mfrc522.PICC_ReadCardSerial()) {
      // Enviamos serialemente su UID
      Serial.print("Card UID:");
      for (byte i = 0; i < mfrc522.uid.size; i++) {
        Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");  //Esto formatea los dígitos hexa del UID de a pares separados por un espacio (para mejor legibilidad)
        Serial.print(mfrc522.uid.uidByte[i], HEX);                 //Pasa el UID a hexa.
        uid = uid + String(mfrc522.uid.uidByte[i], HEX);           //Tomo cada dígito y los concateno para formar el UDI y hacer consultas despues (pregunta a la BD a futuro)
      }
      Serial.println();

      if (uid == uid_aceptado) {
        alerta(1900, led_verde)
      } else {
        alerta(400, led_rojo)
      }

      uid = "";

      // Terminamos la lectura de la tarjeta  actual
      mfrc522.PICC_HaltA();
    }
  }
}

void alerta(frec_pitido, led) {
  noTone(buzzer);
  delay(300);                 //Delay entre leer tarjeta y sonar.
  tone(buzzer, frec_pitido);  //el segundo parámetro indica frecuencia. A mayor valor mas agudo y a menor mas grave el pitido.
  delay(200);                 // Duración del pitido.

  digitalWrite(led, HIGH);

  noTone(buzzer);
  delay(1000);

  digitalWrite(led, LOW);
  delay(1000);
}
