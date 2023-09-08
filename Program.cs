// See https://aka.ms/new-console-template for more information

//sets integers for "myBirthMonth," "myBirthDay," "myBirthYear."
int myBirthMonth = (int)Months.Dec;
int myBirthDay = 23;
int myBirthYear = 1997;

//makes the string,"myBirthDate," keep information on the sentence below, playing it anytime it is used.
string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

//writes all the text in the second half on "File.WriteAllText," to myFile.txt.
File.WriteAllText("myFile.txt", "This is my text file vermin!\n");
Console.WriteLine(File.ReadAllText("myFile.txt"));

//if the files works, it should append the text on the second half and write out "myFile.txt" right after.
File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
Console.WriteLine(File.ReadAllText("myFile.txt"));

//makes an if else, playing text files for the if statement then after that it plays the else statement. 
if (!File.Exists("newFile.txt"))
{
    File.Copy("myFile.txt", "newFile.txt");
}
else
{
    File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
}

//Appends the dates in the "myBirthDate" variable and plays the "newFile.txt" right after
File.AppendAllText("newFile.txt", myBirthDate);
Console.WriteLine(File.ReadAllText("newFile.txt"));

//sets Jan with the variable of 1 and goes up as the list goes down. ex: Feb = 2, Mar = 3.
enum Months
{
    Jan = 1,
    Feb,
    Mar,
    Apr,
    May,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec
}




