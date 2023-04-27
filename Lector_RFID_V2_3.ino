/*
Lector RFID.
V2.3
Incluye sonido de aceptación o rechado de tarjeta así como luz indicativa de ello (verde/roja)

*/

#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN	9    //Pin 9 para el reset del RC522
#define SS_PIN	10   //Pin 10 para el SS (SDA) del RC522
MFRC522 mfrc522(SS_PIN, RST_PIN); //Creamos el objeto para el RC522

const int buzzer = 3;
const int led_verde = 6;
const int led_rojo = 5;

String uid = "";
String uid_aceptado = "620b265";

void setup() {
	Serial.begin(9600); //Iniciamos la comunicación  serial
	SPI.begin();        //Iniciamos el Bus SPI
	mfrc522.PCD_Init(); // Iniciamos  el MFRC522
	Serial.println("Lectura del UID");
  pinMode(buzzer, OUTPUT);
  pinMode(led_verde, OUTPUT);
  pinMode(led_rojo, OUTPUT);
}

void loop() {
	// Revisamos si hay nuevas tarjetas  presentes
	if ( mfrc522.PICC_IsNewCardPresent()) 
        {  
  		//Seleccionamos una tarjeta
            if ( mfrc522.PICC_ReadCardSerial()) 
            {
                  // Enviamos serialemente su UID
                  Serial.print("Card UID:");
                  for (byte i = 0; i < mfrc522.uid.size; i++) {
                          Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
                          Serial.print(mfrc522.uid.uidByte[i], HEX);
                          uid = uid + String(mfrc522.uid.uidByte[i],HEX);
                  } 
                  Serial.println();
                  Serial.println(uid);
                  
                  if (uid == uid_aceptado)
                  {
                    noTone(buzzer);
                    delay(300); //Delay entre leer tarjeta y sonar.
                    tone(buzzer, 1900); //el segundo parámetro indica frecuencia. A mayor valor mas agudo y a menos mas grave.
                    delay(200); // Duración del pitido
                    
                    digitalWrite(led_verde , HIGH);   
                    
                    noTone(buzzer);
                    delay(1000);

                    digitalWrite(led_verde , LOW);    
                    delay(1000);                   
                  }
                  else{
                    noTone(buzzer);
                    delay(300); //Delay entre leer tarjeta y sonar.
                    tone(buzzer, 400); //el segundo parámetro indica frecuencia. A mayor valor mas agudo y a menos mas grave.
                    delay(200); // Duración del pitido

                    digitalWrite(led_rojo , HIGH); 

                    noTone(buzzer);
                    delay(1000);

                    digitalWrite(led_rojo , LOW);    
                    delay(1000);
                  }
                  
                  uid = "";

                  // Terminamos la lectura de la tarjeta  actual
                  mfrc522.PICC_HaltA();         
            }      
	}	
}
