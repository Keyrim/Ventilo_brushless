#include<Servo.h>

#define PIN_ESC 7
Servo esc ;
String str_number ="";
int value_max = 1150;


void setup()
{
    esc.attach(PIN_ESC);
    esc.writeMicroseconds(1000);
    Serial.begin(9600);
}

void loop()
{
    //We wait 3,5 before doing anything so the esc is ready
    if(millis()>3500)
    {
        while(Serial.available())
        {
            char chr = Serial.read();
            if(chr == '\n')
            {
                int number = str_number.toInt();
                if(number > value_max)number = value_max ;
                esc.writeMicroseconds(number);
                str_number = "";
            }
            else str_number += chr ;
        }
    }
}