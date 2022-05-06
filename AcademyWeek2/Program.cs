using AcademyWeek2;
using AcademyWeek2.Entities.LevelOfApprovation;
using AcademyWeek2.LevelOfApprovation;

string percorsoLettura = @"C:\Users\LittleManOfAir\source\repos\AcademyWeek2.Test\AcademyWeek2\spese.txt";
string percorsoScrittura = @"C:\Users\LittleManOfAir\source\repos\AcademyWeek2.Test\AcademyWeek2\spese_elaborate.txt";
StreamReader sr = new StreamReader(percorsoLettura);
StreamWriter sw = new StreamWriter(percorsoScrittura);
string riga = "";
List<Spesa> list = new List<Spesa>();
string nuovariga = "";
var Ceo = new CEO();
var Manager = new Manager();
var OperationManager = new OperationManager();
Ceo.SetNext(Manager).SetNext(OperationManager);



do
{
    riga = sr.ReadLine();
    var rigaSplittata = riga.Split(";");
    nuovariga += rigaSplittata[0]+";";
    nuovariga += rigaSplittata[1] + ";";

    nuovariga += rigaSplittata[2] + ";";

    
    if (Approvation.ApprovationCode(Ceo, double.Parse(rigaSplittata[3])) != null || Approvation.ApprovationCode(Ceo, double.Parse(rigaSplittata[3]))=="")
    {
        nuovariga +=  "APPROVATA;";
        nuovariga += Approvation.ApprovationCode(Ceo, double.Parse(rigaSplittata[3])) +";\r\n";
    }
    else
    {
        nuovariga += "RESPINTA;-;-\r\n";
    }


   



    

} while (!sr.EndOfStream);
    Console.WriteLine(nuovariga);
