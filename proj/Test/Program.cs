int[] student1={100,100,90,90,100};
int[] student2={20,70,80,20,80};
int[] student3={30,30,60,60,50};
int[] student4={70,30,30,40,40};
int[] student5={10,10,10,5,10};

string[] names={"sophia","andrew","megan","janus","josef"};
int[] studentScores=new int[10];

string currentStudentLetterGrade="";


int currentAssignments=5;
Console.WriteLine("Student\t\tGrade\tletter Grade\n");

foreach(string name in names){
    string currentStudent = name;
    if (currentStudent == "sophia"){
        studentScores=student1;
    }
    else if (currentStudent =="andrew"){
        studentScores=student2;
    }
    else if (currentStudent == "megan"){
        studentScores=student3;
    }
    else if(currentStudent=="logan"){
        studentScores=student4;
    }
    else if (currentStudent=="pitt"){
        studentScores=student5;
    }

    int x=0;
    

    foreach (int score in studentScores ){
        x += score;
        
    }
    float avg=x/currentAssignments;
    if (avg>=90)
    {
        currentStudentLetterGrade="A";
    }
    else if(avg>=75)
    {
        currentStudentLetterGrade="B";
    }
    else if(avg>=60)
    {
        currentStudentLetterGrade="C";
    }
    else if(avg>=50)
    {
        currentStudentLetterGrade="D";
    }
    else {
        currentStudentLetterGrade="F";
    }
    Console.WriteLine($"{currentStudent}\t\t{avg}\t{currentStudentLetterGrade}");
}
Console.WriteLine("\n\r press the enter  key to continue");
Console.ReadLine();

















/*foreach (int sum  in student1 ){
    
    x += sum;
    avg=x/currentAssignments;

}
if(avg>=90){
        Console.WriteLine("A");
    }
    else if (avg>=80)
    {
        Console.WriteLine("B");
    }
    else if (avg>=60){
        Console.WriteLine("C");
    }
    else if (avg>=50){
        Console.WriteLine("D");
    }
    else{
        Console.WriteLine("F");
    }

*/
