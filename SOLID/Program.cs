using SOLID;
using SOLID.Good;
using SOLID.Good.Interfaces;
using SOLID.Bad;

// --- GOOD ---

SOLID.Good.Soldier soldier = new SOLID.Good.Soldier(new PersonalData(1,"Łukasz","Polish",24));
SOLID.Good.Medic medic = new SOLID.Good.Medic(new PersonalData(2,"Tom","US",26));
SOLID.Good.AltyleryOperator Alt_operator = new SOLID.Good.AltyleryOperator(new PersonalData(3, "Grzegosz", "Polish", 22));


SOLID.Good.RadioCommunicator radioToAltylery = new SOLID.Good.RadioCommunicator(new CommunicateToCallAlltylery());

radioToAltylery.Communucate(soldier, Alt_operator);

SOLID.Good.RadioCommunicator radioGroup = new SOLID.Good.RadioCommunicator(new CommunicateBetweenSoldiers());

radioGroup.Communucate(soldier, medic);

soldier.shoot();


// --- Bad ---
Console.WriteLine("None SOLID \n\n\n");


SOLID.Bad.Soldier soldier_Bad = new SOLID.Bad.Soldier(1,"Robert","Polish",23);
SOLID.Bad.Medic medic_Bad = new SOLID.Bad.Medic(2,"Krystian","Polish",30);
SOLID.Bad.AltyleryOperator operator_Bad = new SOLID.Bad.AltyleryOperator(3,"Bob","US",24);


SOLID.Bad.RadioCommunicator radio_Bad = new SOLID.Bad.RadioCommunicator();

radio_Bad.CommunucateToAltylery(soldier_Bad, operator_Bad);

radio_Bad.CommunucateToSoldier(medic_Bad,soldier_Bad);

soldier_Bad.shoot();




