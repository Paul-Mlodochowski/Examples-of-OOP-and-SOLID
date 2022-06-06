using SOLID;
using SOLID.Good;
using SOLID.Good.Interfaces;

// --- GOOD ---

Soldier soldier = new Soldier(new PersonalData(1,"Łukasz","Polish",24));
Medic medic = new Medic(new PersonalData(1,"Tom","US",26));
AltyleryOperator Alt_operator = new AltyleryOperator(new PersonalData(1, "Grzegosz", "Polish", 22));


RadioCommunicator radioToAltylery = new RadioCommunicator(new CommunicateToCallAlltylery());

radioToAltylery.Communucate(soldier, Alt_operator);

RadioCommunicator radioGroup = new RadioCommunicator(new CommunicateBetweenSoldiers());

radioGroup.Communucate(soldier, medic);

soldier.shoot();


// --- Bad ---


