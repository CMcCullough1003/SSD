using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataStore;

namespace DogCare
{

    //TODO
    // Client: name = first name and last name
    // ProgramVariety: includes numberOfClasses and maxNumberOfDogs
    // Program: name = variety + ID

    public class Populate
    {

        //Client Ids
        private int clientIdJames = 0; ClientModel clientModelJames = new ClientModel();
        private int clientIdMark = 0;  ClientModel clientModelMark = new ClientModel();
        private int clientIdTed = 0;  ClientModel clientModelTed = new ClientModel();
        private int clientIdSam = 0;  ClientModel clientModelSam = new ClientModel();
        private int clientIdBarry = 0;  ClientModel clientModelBarry = new ClientModel();
        private int clientIdJim = 0;  ClientModel clientModelJim = new ClientModel();
        private int clientIdRon = 0;  ClientModel clientModelRon = new ClientModel();
        private int clientIdSid = 0;  ClientModel clientModelSid = new ClientModel();

        //Dog Ids
        private int dogIdThor = 0;  DogModel dogModelThor = new DogModel();
        private int dogIdOdin = 0; DogModel dogModelOdin = new DogModel();       
        private int dogIdLoki = 0; DogModel dogModelLoki = new DogModel();
        private int dogIdHela = 0; DogModel dogModelHela = new DogModel();
        private int dogIdHeimdall = 0; DogModel dogModelHeimdall = new DogModel();
        private int dogIdBaldur = 0; DogModel dogModelBaldur = new DogModel();
        private int dogIdBragi = 0; DogModel dogModelBragi = new DogModel();
        private int dogIdIdun = 0;  DogModel dogModelIdun = new DogModel();      
        private int dogIdNjord = 0; DogModel dogModelNjord = new DogModel();
        private int dogIdFreya = 0; DogModel dogModelFreya = new DogModel();
        private int dogIdFreyer = 0; DogModel dogModelFreyer = new DogModel();
        private int dogIdForseti = 0; DogModel dogModelForseti = new DogModel();
        private int dogIdYmir = 0; DogModel dogModelYmir = new DogModel();
        private int dogIdMimir = 0; DogModel dogModelMimir = new DogModel();
        private int dogIdThurd = 0; DogModel dogModelThurd = new DogModel();
        private int dogIdAngbroda = 0; DogModel dogModelAngbroda = new DogModel();

        //Staff Ids
        private int staffIdAllison = 0;
        private int staffIdBeth = 0;
        private int staffIdCarol = 0;
        private int staffIdDiane = 0;
        private int staffIdEva = 0;

        //Program Variety Ids
        int programVarietyIdAdvanced = 0; ProgramVarietyModel programVarietyModelAdvanced = new ProgramVarietyModel();
        int programVarietyIdRegular = 0; ProgramVarietyModel programVarietyModelRegular = new ProgramVarietyModel();


        //Program Ids
        int programIdRegular1 = 0; ProgramModel programModelRegular1 = new ProgramModel();
        int programIdRegular2 = 0; ProgramModel programModelRegular2 = new ProgramModel();
        int programIdAdvanced1 = 0; ProgramModel programModelAdvanced1 = new ProgramModel();


        public void populateDatabase(){
            populateClient(); //boy names
            populateDog(); //norse god names
            populateStaff(); //girl names
            populateVariety();
            populateProgram();
            populateClasses();
            populateEnrollment();
        }

        private void populateClient(){

            ClientTable clientTable = new ClientTable();

            clientModelBarry = new ClientModel();
            clientModelBarry.forename = "James";
            clientModelBarry.surname = "Jones";
            clientModelBarry.phone = "1234567890";
            clientModelBarry.email = "james@gmail.com";
            clientModelBarry.displayName = clientModelBarry.forename + " " + clientModelBarry.surname;
            clientIdBarry = clientTable.create(clientModelBarry);

            clientModelJames = new ClientModel();
            clientModelJames.forename = "Barry";
            clientModelJames.surname = "Bonds";
            clientModelJames.phone = "1234567891";
            clientModelJames.email = "barry@gmail.com";
            clientModelJames.displayName = clientModelJames.forename + " " + clientModelJames.surname;
            clientIdJames = clientTable.create(clientModelJames);

            clientModelMark = new ClientModel();
            clientModelMark.forename = "Mark";
            clientModelMark.surname = "Murray";
            clientModelMark.phone = "1234567892";
            clientModelMark.email = "mark@gmail.com";
            clientModelMark.displayName = clientModelMark.forename + " " + clientModelMark.surname;
            clientIdMark = clientTable.create(clientModelMark);

            clientModelSam = new ClientModel();
            clientModelSam.forename = "Sam";
            clientModelSam.surname = "Spud";
            clientModelSam.phone = "1234567893";
            clientModelSam.email = "sam@gmail.com";
            clientModelSam.displayName = clientModelSam.forename + " " + clientModelSam.surname;
            clientIdSam = clientTable.create(clientModelSam);

            clientModelTed = new ClientModel();
            clientModelTed.forename = "Ted";
            clientModelTed.surname = "Teddington";
            clientModelTed.phone = "1234567894";
            clientModelTed.email = "ted@gmail.com";
            clientModelTed.displayName = clientModelTed.forename + " " + clientModelTed.surname;
            clientIdTed = clientTable.create(clientModelTed);

            clientModelJim = new ClientModel();
            clientModelJim.forename = "Jim";
            clientModelJim.surname = "Jones";
            clientModelJim.phone = "1234567895";
            clientModelJim.email = "jim@gmail.com";
            clientModelJim.displayName = clientModelJim.forename + " " + clientModelJim.surname;
            clientIdJim = clientTable.create(clientModelJim);

            clientModelRon = new ClientModel();
            clientModelRon.forename = "Ron";
            clientModelRon.surname = "Ronalds";
            clientModelRon.phone = "1234567896";
            clientModelRon.email = "ron@gmail.com";
            clientModelRon.displayName = clientModelRon.forename + " " + clientModelRon.surname;
            clientIdRon = clientTable.create(clientModelRon);

            clientModelSid = new ClientModel();
            clientModelSid.forename = "Sid";
            clientModelSid.surname = "Siddle";
            clientModelSid.phone = "1234567897";
            clientModelSid.email = "sid@gmail.com";
            clientModelSid.displayName = clientModelSid.forename + " " + clientModelSid.surname;
            clientIdSid = clientTable.create(clientModelSid);
        }
    
        private void populateDog(){

            DogTable dogTable = new DogTable();

            dogModelThor = new DogModel();
            dogModelThor.name = "Thor";
            dogModelThor.clientID = clientIdJames;
            dogModelThor.age = 1;
            dogModelThor.breed = "Bulldog";
            dogModelThor.experienceOrQualification = false;
            dogIdThor = dogTable.create(dogModelThor);

            dogModelOdin = new DogModel();
            dogModelOdin.name = "Odin";
            dogModelOdin.clientID = clientIdJames;
            dogModelOdin.age = 2;
            dogModelOdin.breed = "Shi Tzu";
            dogModelOdin.experienceOrQualification = true;
            dogIdOdin = dogTable.create(dogModelOdin);

            dogModelLoki = new DogModel();
            dogModelLoki.name = "Loki";
            dogModelLoki.clientID = clientIdJames;
            dogModelLoki.age = 3;
            dogModelLoki.breed = "Beadle";
            dogModelLoki.experienceOrQualification = true;
            dogIdLoki = dogTable.create(dogModelLoki);

            dogModelHela = new DogModel();
            dogModelHela.name = "Hela";
            dogModelHela.clientID = clientIdMark;
            dogModelHela.age = 4;
            dogModelHela.breed = "Poodle";
            dogModelHela.experienceOrQualification = false;
            dogIdHela = dogTable.create(dogModelHela);

            dogModelHeimdall = new DogModel();
            dogModelHeimdall.name = "Heimdall";
            dogModelHeimdall.clientID = clientIdMark;
            dogModelHeimdall.age = 5;
            dogModelHeimdall.breed = "Bulldog";
            dogModelHeimdall.experienceOrQualification = true;
            dogIdHeimdall = dogTable.create(dogModelHeimdall);

            dogModelBaldur = new DogModel();
            dogModelBaldur.name = "Baldur";
            dogModelBaldur.clientID = clientIdMark;
            dogModelBaldur.age = 6;
            dogModelBaldur.breed = "Shi Tzu";
            dogModelBaldur.experienceOrQualification = false;
            dogIdBaldur = dogTable.create(dogModelBaldur);

            dogModelBragi = new DogModel();
            dogModelBragi.name = "Bragi";
            dogModelBragi.clientID = clientIdTed;
            dogModelBragi.age = 7;
            dogModelBragi.breed = "Poodle";
            dogModelBragi.experienceOrQualification = true;
            dogIdBragi = dogTable.create(dogModelBragi);

            dogModelIdun = new DogModel();
            dogModelIdun.name = "Idun";
            dogModelIdun.clientID = clientIdTed;
            dogModelIdun.age = 8;
            dogModelIdun.breed = "Beagle";
            dogModelIdun.experienceOrQualification = false;
            dogIdIdun = dogTable.create(dogModelIdun);

            dogModelNjord = new DogModel();
            dogModelNjord.name = "Njord";
            dogModelNjord.clientID = clientIdSam;
            dogModelNjord.age = 9;
            dogModelNjord.breed = "Shi Tzu";
            dogModelNjord.experienceOrQualification = true;
            dogIdNjord = dogTable.create(dogModelNjord);

            dogModelFreya = new DogModel();
            dogModelFreya.name = "Freya";
            dogModelFreya.clientID = clientIdSam;
            dogModelFreya.age = 10;
            dogModelFreya.breed = "Bulldog";
            dogModelFreya.experienceOrQualification = false;
            dogIdFreya = dogTable.create(dogModelFreya);

            dogModelFreyer = new DogModel();
            dogModelFreyer.name = "Freyer";
            dogModelFreyer.clientID = clientIdBarry;
            dogModelFreyer.age = 11;
            dogModelFreyer.breed = "Pug";
            dogModelFreyer.experienceOrQualification = true;
            dogIdFreyer = dogTable.create(dogModelFreyer);

            dogModelForseti = new DogModel();
            dogModelForseti.name = "Forseti";
            dogModelForseti.clientID = clientIdBarry;
            dogModelForseti.age = 12;
            dogModelForseti.breed = "Beagle";
            dogModelForseti.experienceOrQualification = false;
            dogIdForseti = dogTable.create(dogModelForseti);

            dogModelYmir = new DogModel();
            dogModelYmir.name = "Ymir";
            dogModelYmir.clientID = clientIdJim;
            dogModelYmir.age = 13;
            dogModelYmir.breed = "Shi Tzu";
            dogModelYmir.experienceOrQualification = true;
            dogIdYmir = dogTable.create(dogModelYmir);

            dogModelMimir = new DogModel();
            dogModelMimir.name = "Mimir";
            dogModelMimir.clientID = clientIdJim;
            dogModelMimir.age = 14;
            dogModelMimir.breed = "Poodle";
            dogModelMimir.experienceOrQualification = false;
            dogIdMimir = dogTable.create(dogModelMimir);

            dogModelThurd = new DogModel();
            dogModelThurd.name = "Thurd";
            dogModelThurd.clientID = clientIdRon;
            dogModelThurd.age = 15;
            dogModelThurd.breed = "Great Dane";
            dogModelThurd.experienceOrQualification = true;
            dogIdThurd = dogTable.create(dogModelThurd);

            dogModelAngbroda = new DogModel();
            dogModelAngbroda.name = "Angbroda";
            dogModelAngbroda.clientID = clientIdSid;
            dogModelAngbroda.age = 16;
            dogModelAngbroda.breed = "Husky";
            dogModelAngbroda.experienceOrQualification = false;
            dogIdAngbroda = dogTable.create(dogModelAngbroda);
        }

        private void populateStaff(){

            StaffTable staffTable = new StaffTable();

            StaffModel staffModelAllison = new StaffModel();
            staffModelAllison.name = "Allison";
            staffIdAllison = staffTable.create(staffModelAllison);

            StaffModel staffModelBeth = new StaffModel();
            staffModelAllison.name = "Beth";
            staffIdBeth = staffTable.create(staffModelAllison);

            StaffModel staffModelCarol = new StaffModel();
            staffModelCarol.name = "Carol";
            staffIdCarol = staffTable.create(staffModelCarol);

            StaffModel staffModelDiane = new StaffModel();
            staffModelDiane.name = "Diane";
            staffIdDiane = staffTable.create(staffModelDiane);

            StaffModel staffModelEva = new StaffModel();
            staffModelEva.name = "Eva";
            staffIdEva = staffTable.create(staffModelDiane);

        }


        private void populateVariety(){
                                  
            ProgramVarietyTable programVarietyTable = new ProgramVarietyTable();

            programVarietyModelAdvanced = new ProgramVarietyModel();
            programVarietyModelAdvanced.name = "Advanced";
            programVarietyModelAdvanced.depositAmount = 30.0;
            programVarietyModelAdvanced.fullPaymentPercentageDiscount = 0;
            programVarietyModelAdvanced.sessionCost = 30.0;
            programVarietyModelAdvanced.noOfClasses = 8;
            programVarietyModelAdvanced.dogSpacesMaximum = 8;
            programVarietyIdAdvanced = programVarietyTable.create(programVarietyModelAdvanced);

            programVarietyModelRegular = new ProgramVarietyModel();
            programVarietyModelRegular.name = "Regular";
            programVarietyModelRegular.depositAmount = 20.0;
            programVarietyModelRegular.fullPaymentPercentageDiscount = 10.0;
            programVarietyModelRegular.sessionCost = 25.0;
            programVarietyModelRegular.noOfClasses = 6;
            programVarietyModelRegular.dogSpacesMaximum = 10;
            programVarietyIdRegular = programVarietyTable.create(programVarietyModelRegular);
        }

        private void populateProgram(){
            ProgramTable programTable = new ProgramTable();

            programModelRegular1 = new ProgramModel();
            programModelRegular1.name = "Regular 1" ;
            programModelRegular1.programVarietyId = programVarietyIdRegular ;
            programIdRegular1 = programTable.create(programModelRegular1); 

            programModelRegular2 = new ProgramModel();
            programModelRegular2.name = "Regular 2" ;
            programModelRegular2.programVarietyId = programVarietyIdRegular;
            programIdRegular2 = programTable.create(programModelRegular2);

            programModelAdvanced1 = new ProgramModel();
            programModelAdvanced1.name = "Advanced 1" ;
            programModelAdvanced1.programVarietyId = programVarietyIdAdvanced;
            programIdAdvanced1 = programTable.create(programModelAdvanced1);  
        }

        private void populateClasses(){
            ClassTable classTable = new ClassTable();

            //regular classes
            for(var i = 0; i <= 5; i++ ){
                ClassModel classModel = new ClassModel();
                classModel.programId = programIdRegular1;
                classModel.staffId = staffIdAllison;
                classModel.classDate = DateTime.Now.AddDays( (i * 7) + 1);
                classModel.startTime = TimeSpan.Parse("09:30");
                classModel.endTime = TimeSpan.Parse("11:30");
                classTable.create(classModel);
            }

            //regular classes
            for(var i = 0; i <= 5; i++ ){
                ClassModel classModel = new ClassModel();
                classModel.programId = programIdRegular2;
                classModel.staffId = staffIdBeth;
                classModel.classDate = DateTime.Now.AddDays( (i * 7) + 1);
                classModel.startTime = TimeSpan.Parse("13:00");
                classModel.endTime = TimeSpan.Parse("15:00");
                classTable.create(classModel);
            }

            //advanced classes
            for(var i = 0; i <= 7; i++ ){
                ClassModel classModel = new ClassModel();
                classModel.programId = programIdAdvanced1;
                classModel.staffId = staffIdBeth;
                classModel.classDate = DateTime.Now.AddDays( (i * 7) + 50);
                classModel.startTime = TimeSpan.Parse("16:00");
                classModel.endTime = TimeSpan.Parse("18:00");
                classTable.create(classModel);
            } 

        }

        private void populateEnrollment(){
            
            enrollThorRegular(); //paid deposit and balance
            enrollOdinRegular(); //paid deposit and balance
            enrollLokiRegular(); //paid deposit but not balance
            enrollLokiAdvanced(); // paid in full 
            enrollHelaRegular(); //paid deposit but not installments
            enrollHeimdallRegular(); //paid deposit but not balance
            enrollHeimdallAdvanced(); //paid in installments
            enrollBaldurRegular();  //paid deposit and balance

        }

        private void enrollThorRegular(){
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            PaymentTable paymentTable = new PaymentTable();

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = dogModelThor.name + " (owned by " + clientModelJames.displayName + ") in " + programModelRegular1.name;
            enrollmentModel.clientId = clientIdJames;
            enrollmentModel.dogId = dogIdThor;
            enrollmentModel.programId = programIdRegular1;
            enrollmentModel.paymentMethod = PaymentConstants.PAYMENT_IN_FULL;
            enrollmentModel.joinDate = DateTime.Now.AddDays(-19);
            enrollmentModel.inviteIssued = true;
            int enrollmentId = enrollmentTable.create(enrollmentModel);

            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel1.paymentAmountDue = programVarietyModelRegular.depositAmount;
            paymentModel1.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel1.recieptIssued = true;
            paymentTable.create(paymentModel1);

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentType = PaymentTypeConstants.BALANCE;
            paymentModel2.paymentAmountDue = 117.00;
            paymentModel2.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel2.paymentRecieved = true;
            paymentModel2.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel2.recieptIssued = true;
            paymentTable.create(paymentModel2);
        }


        private void enrollOdinRegular(){
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            PaymentTable paymentTable = new PaymentTable();

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = dogModelOdin.name + " (owned by " + clientModelJames.displayName + ") in " + programModelRegular1.name;
            enrollmentModel.clientId = clientIdJames;
            enrollmentModel.dogId = dogIdOdin;
            enrollmentModel.programId = programIdRegular1;
            enrollmentModel.paymentMethod = PaymentConstants.PAYMENT_IN_FULL;
            enrollmentModel.joinDate = DateTime.Now.AddDays(-19);
            enrollmentModel.inviteIssued = true;
            int enrollmentId = enrollmentTable.create(enrollmentModel);

            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel1.paymentAmountDue = programVarietyModelRegular.depositAmount;
            paymentModel1.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel1.recieptIssued = true;
            paymentTable.create(paymentModel1);

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentType = PaymentTypeConstants.BALANCE;
            paymentModel2.paymentAmountDue = 117.00;
            paymentModel2.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel2.paymentRecieved = true;
            paymentModel2.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel2.recieptIssued = true;
            paymentTable.create(paymentModel2);
        }

        private void enrollLokiRegular(){
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            PaymentTable paymentTable = new PaymentTable();

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = dogModelLoki.name + " (owned by " + clientModelJames.displayName + ") in " + programModelRegular1.name;
            enrollmentModel.clientId = clientIdJames;
            enrollmentModel.dogId = dogIdLoki;
            enrollmentModel.programId = programIdRegular1;
            enrollmentModel.paymentMethod = PaymentConstants.PAYMENT_IN_FULL;
            enrollmentModel.joinDate = DateTime.Now.AddDays(-19);
            enrollmentModel.inviteIssued = true;
            int enrollmentId = enrollmentTable.create(enrollmentModel);

            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel1.paymentAmountDue = programVarietyModelRegular.depositAmount;
            paymentModel1.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel1.recieptIssued = true;
            paymentTable.create(paymentModel1);

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentType = PaymentTypeConstants.BALANCE;
            paymentModel2.paymentAmountDue = 117.00;
            paymentModel2.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel2.paymentRecieved = false;
            //paymentModel2.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel2.recieptIssued = false;
            paymentTable.create(paymentModel2);
        }

        private void enrollLokiAdvanced(){
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            PaymentTable paymentTable = new PaymentTable();

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = dogModelLoki.name + " (owned by " + clientModelJames.displayName + ") in " + programModelAdvanced1.name;
            enrollmentModel.clientId = clientIdJames;
            enrollmentModel.dogId = dogIdLoki;
            enrollmentModel.programId = programIdAdvanced1;
            enrollmentModel.paymentMethod = PaymentConstants.PAYMENT_IN_FULL;
            enrollmentModel.joinDate = DateTime.Now.AddDays(-2);
            enrollmentModel.inviteIssued = true;
            int enrollmentId = enrollmentTable.create(enrollmentModel);

            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel1.paymentAmountDue = programVarietyModelAdvanced.depositAmount;
            paymentModel1.paymentAmountDueDate = DateTime.Now.AddDays(-2);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-2);
            paymentModel1.recieptIssued = true;
            paymentTable.create(paymentModel1);
        

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentType = PaymentTypeConstants.BALANCE;
            paymentModel2.paymentAmountDue = 210.00;
            paymentModel2.paymentAmountDueDate = DateTime.Now.AddDays(-2);
            paymentModel2.paymentRecieved = false;
            //paymentModel2.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel2.recieptIssued = false;
            paymentTable.create(paymentModel2);
        }


        private void enrollHelaRegular(){
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            PaymentTable paymentTable = new PaymentTable();

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = dogModelOdin.name + " (owned by " + clientModelJames.displayName + ") in " + programModelRegular1.name;
            enrollmentModel.clientId = clientIdJames;
            enrollmentModel.dogId = dogIdOdin;
            enrollmentModel.programId = programIdRegular1;
            enrollmentModel.paymentMethod = PaymentConstants.PAYMENT_PER_CLASS;
            enrollmentModel.joinDate = DateTime.Now.AddDays(-19);
            enrollmentModel.inviteIssued = true;
            int enrollmentId = enrollmentTable.create(enrollmentModel);

            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel1.paymentAmountDue = programVarietyModelRegular.depositAmount;
            paymentModel1.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel1.recieptIssued = true;
            paymentTable.create(paymentModel1);

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentType = PaymentTypeConstants.INSTALLMENT;
            paymentModel2.paymentAmountDue = 39.00;
            paymentModel2.paymentAmountDueDate = DateTime.Now.AddDays(+14);
            paymentModel2.paymentRecieved = false;
            //paymentModel2.paymentRecievedDate = DateTime.Now.AddDays(+);
            paymentModel2.recieptIssued = false;
            paymentTable.create(paymentModel2);

            PaymentModel paymentModel3 = new PaymentModel();
            paymentModel3.enrollmentId = enrollmentId;
            paymentModel3.paymentType = PaymentTypeConstants.INSTALLMENT;
            paymentModel3.paymentAmountDue = 39.00;
            paymentModel3.paymentAmountDueDate = DateTime.Now.AddDays(+28);
            paymentModel3.paymentRecieved = false;
            //paymentModel2.paymentRecievedDate = DateTime.Now.AddDays(+);
            paymentModel3.recieptIssued = false;
            paymentTable.create(paymentModel3);
            
            PaymentModel paymentModel4 = new PaymentModel();
            paymentModel4.enrollmentId = enrollmentId;
            paymentModel4.paymentType = PaymentTypeConstants.INSTALLMENT;
            paymentModel4.paymentAmountDue = 39.00;
            paymentModel4.paymentAmountDueDate = DateTime.Now.AddDays(+42);
            paymentModel4.paymentRecieved = false;
            //paymentModel4.paymentRecievedDate = DateTime.Now.AddDays(+);
            paymentModel4.recieptIssued = false;
            paymentTable.create(paymentModel4);
        }

        private void enrollBaldurRegular(){
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            PaymentTable paymentTable = new PaymentTable();

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = dogModelBaldur.name + " (owned by " + clientModelMark.displayName + ") in " + programModelRegular1.name;
            enrollmentModel.clientId = clientIdMark;
            enrollmentModel.dogId = dogIdBaldur;
            enrollmentModel.programId = programIdRegular1;
            enrollmentModel.paymentMethod = PaymentConstants.PAYMENT_IN_FULL;
            enrollmentModel.joinDate = DateTime.Now.AddDays(-19);
            enrollmentModel.inviteIssued = true;
            int enrollmentId = enrollmentTable.create(enrollmentModel);

            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel1.paymentAmountDue = programVarietyModelRegular.depositAmount;
            paymentModel1.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel1.recieptIssued = true;
            paymentTable.create(paymentModel1);

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentType = PaymentTypeConstants.BALANCE;
            paymentModel2.paymentAmountDue = 117.00;
            paymentModel2.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel2.paymentRecieved = true;
            paymentModel2.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel2.recieptIssued = true;
            paymentTable.create(paymentModel2);
        }

        private void enrollHeimdallRegular(){
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            PaymentTable paymentTable = new PaymentTable();

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = dogModelHeimdall.name + " (owned by " + clientModelMark.displayName + ") in " + programModelRegular1.name;
            enrollmentModel.clientId = clientIdMark;
            enrollmentModel.dogId = dogIdHeimdall;
            enrollmentModel.programId = programIdRegular1;
            enrollmentModel.paymentMethod = PaymentConstants.PAYMENT_IN_FULL;
            enrollmentModel.joinDate = DateTime.Now.AddDays(-19);
            enrollmentModel.inviteIssued = true;
            int enrollmentId = enrollmentTable.create(enrollmentModel);

            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel1.paymentAmountDue = programVarietyModelRegular.depositAmount;
            paymentModel1.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel1.recieptIssued = true;
            paymentTable.create(paymentModel1);

            PaymentModel paymentModel2 = new PaymentModel();
            paymentModel2.enrollmentId = enrollmentId;
            paymentModel2.paymentType = PaymentTypeConstants.BALANCE;
            paymentModel2.paymentAmountDue = 117.00;
            paymentModel2.paymentAmountDueDate = DateTime.Now.AddDays(-19);
            paymentModel2.paymentRecieved = false;
            //paymentModel2.paymentRecievedDate = DateTime.Now.AddDays(-19);
            paymentModel2.recieptIssued = false;
            paymentTable.create(paymentModel2);
        }



        private void enrollHeimdallAdvanced(){
            EnrollmentTable enrollmentTable = new EnrollmentTable();
            PaymentTable paymentTable = new PaymentTable();

            EnrollmentModel enrollmentModel = new EnrollmentModel();
            enrollmentModel.name = dogModelHeimdall.name + " (owned by " + clientModelMark.displayName + ") in " + programModelAdvanced1.name;
            enrollmentModel.clientId = clientIdJames;
            enrollmentModel.dogId = dogIdLoki;
            enrollmentModel.programId = programIdAdvanced1;
            enrollmentModel.paymentMethod = PaymentConstants.PAYMENT_PER_CLASS;
            enrollmentModel.joinDate = DateTime.Now.AddDays(-2);
            enrollmentModel.inviteIssued = true;
            int enrollmentId = enrollmentTable.create(enrollmentModel);

            PaymentModel paymentModel1 = new PaymentModel();
            paymentModel1.enrollmentId = enrollmentId;
            paymentModel1.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel1.paymentAmountDue = programVarietyModelAdvanced.depositAmount;
            paymentModel1.paymentAmountDueDate = DateTime.Now.AddDays(-2);
            paymentModel1.paymentRecieved = true;
            paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-2);
            paymentModel1.recieptIssued = true;
            paymentTable.create(paymentModel1);

            for(var i = 0; i < 8; i++){
                PaymentModel paymentModelInstallment = new PaymentModel();
                paymentModelInstallment.enrollmentId = enrollmentId;
                paymentModelInstallment.paymentType = PaymentTypeConstants.INSTALLMENT;
                paymentModelInstallment.paymentAmountDue = 26.25;
                paymentModelInstallment.paymentAmountDueDate = DateTime.Now.AddDays(50 + (i*7));
                paymentModelInstallment.paymentRecieved = false;
                //paymentModel1.paymentRecievedDate = DateTime.Now.AddDays(-2);
                paymentModelInstallment.recieptIssued = false;
                paymentTable.create(paymentModelInstallment);
            }
        


        }

    }

}