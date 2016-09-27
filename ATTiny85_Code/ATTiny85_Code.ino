//Robot9706 ~ 2016
//https://github.com/robot9706/Xbox360RFController

int clockpin = 3;
int datapin = 4;
int buttonpin = 2;

int ledinit[] = { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 };
int sync[] = { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };

int cycles = 0;
bool act = false;

void setup() {
  pinMode(clockpin, INPUT);
  pinMode(datapin, OUTPUT);
  pinMode(buttonpin, INPUT);
  
  digitalWrite(datapin, HIGH);

  delay(2000);
  sendCmd(ledinit);
}

void sendCmd(int cmd[]){
  digitalWrite(datapin, LOW);

  for(int x = 0;x<10;x++){
    while(digitalRead(clockpin)){}

    digitalWrite(datapin, (cmd[x] == 1 ? HIGH : LOW));

    while(!digitalRead(clockpin)){}
  }

  digitalWrite(datapin, HIGH);
}

void loop() {
  bool btn = digitalRead(buttonpin);
  if(btn){ //Pressed
    cycles++;

    if(!act && cycles > 20){
      act = true;
      sendCmd(sync);
    }
  }else{ //Button is not pressed
    act = false;  
  }
  
  delay(50);
}
