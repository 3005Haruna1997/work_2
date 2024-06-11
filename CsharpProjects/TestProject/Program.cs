
string firstName = "Kirill";
string secondName = "Ivanov";
string surName= "Dmitrievich";
string fullName = secondName + " " + firstName + " " + surName;

string age = "27";
string eMail = "iDontTellYouMyRealMail@mail.ru";
string techicalVar_1 = "";
string technicalVar_2 = "-";

byte computerClassGrade = 3;
byte mathematicGrade = 4;
byte phisicGrade = 4;
byte gradeCount = 3;

float middleGrade = 0;
long sumOfGrade = 0;

string pattern = "Full name :{0} \nAge :{1} \nemail :{2}";

fullName = techicalVar_1.PadRight(16) + fullName;
age = age.PadLeft(24);
eMail = techicalVar_1.PadRight(20) + eMail;
technicalVar_2 = string.Join("-",Enumerable.Repeat(technicalVar_2,30));

sumOfGrade = computerClassGrade + mathematicGrade + phisicGrade;
middleGrade = (float)(sumOfGrade)/(float)(gradeCount);

Console.WriteLine(technicalVar_2);
Console.WriteLine(pattern,
                 fullName,
                 age,
                 eMail
                 );

Console.WriteLine($"{technicalVar_2}\nComputer class grade :{computerClassGrade,6}\nMathematic grade :{mathematicGrade,10}\nPhisic grade :{phisicGrade,14}");

Console.WriteLine($"\nMiddle grade :" + techicalVar_1.PadRight(13) +"{0:0.000}",middleGrade);
Console.WriteLine(technicalVar_2);

Console.ReadKey();


