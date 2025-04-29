// See https://aka.ms/new-console-template for more information
string studentName = "Raj";
string course1 = "101";
string course2 = "102";
string course3 = "103";
string course4 = "104";

int course1credit = 3;
int course2credit = 3;
int course3credit = 3;
int course4credit = 4;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeA;
int course4Grade = gradeB; // note: corrected capitalization

Console.WriteLine("Course\t\tGrade\t\tHours"); // fixed missing semicolon

Console.WriteLine($"{course1}\t\t{course1Grade}\t\t{course1credit}");
Console.WriteLine($"{course2}\t\t{course2Grade}\t\t{course2credit}");
Console.WriteLine($"{course3}\t\t{course3Grade}\t\t{course3credit}");
Console.WriteLine($"{course4}\t\t{course4Grade}\t\t{course4credit}");

int totalcredithours = 0;

totalcredithours += course1credit;
totalcredithours += course2credit;
totalcredithours += course3credit;
totalcredithours += course4credit;

int totalgradepoints = 0;
totalgradepoints += course1credit * course1Grade;
totalgradepoints += course2credit * course2Grade;
totalgradepoints += course3credit * course3Grade;
totalgradepoints += course4credit * course4Grade;

Console.WriteLine($"Totalgradepoints\t Totalcredithours");
Console.WriteLine($"{totalgradepoints}\t\t {totalcredithours}");

decimal gradeavg = (decimal)totalgradepoints / totalcredithours;

Console.WriteLine($"Final GPA: {gradeavg}");

int gpadigit = (int)gradeavg;
int first = (int)(gradeavg * 10) % 10;
int last = (int)(gradeavg * 100) % 10;

Console.WriteLine($"FinalGPA:\t{gpadigit}.{first}{last}");
