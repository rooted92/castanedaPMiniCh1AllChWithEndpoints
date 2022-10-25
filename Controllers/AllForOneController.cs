using Microsoft.AspNetCore.Mvc;

namespace castanedaPMiniCh1AllChWithEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class AllForOneController : ControllerBase
{
    //this function will greet the user after they input their name
    [HttpGet]
    [Route("Hello")]
    public string SayHello()
    {
        return "Hello, nice to meet you!";
    }
    //this function will take two numbers from user then add them together
    [HttpGet]
    [Route("Add")]
    public int AddNums()
    {
        return 33 + 0;
    }
    //this function will simulate a conversation with user after each of their inputs
    [HttpGet]
    [Route("Asking")]

    public string AskingQs()
    {
        //supposed to get user input to simulate a conversation, this is hardcoded
        string q1 = "Hello, what is your name? ";
        string r1 = " Pedro";
        string q2 = " What time did you wake up today?";
        string r2 = " At 5:00am";
        string computerFinalResponse = " Dang Pedro, 5:00am is pretty early.";
        return q1 + r1 + q2 + r2 + computerFinalResponse;
    }
    //this function will compare two numbers that a user inputs and say they if they are equal or greater than or less than
    [HttpGet]
    [Route("Than")]
    public string GreaterOrLess()
    {
        //supposed to get user input but I don't know how to do that yet
        int num1 = 5;
        int num2 = 10;
        string result = "";
        if(num1 < num2)
        {
            result = $"{num1.ToString()} is less than {num2.ToString()}";
        }
        return result;
    }
    //this function will prompt user to play madlibe and ask them for different types of words to create madlib story
    [HttpPost]
    [Route("Madlib")]
    public string MadGame()
    {
        return "Once upon a time there was a {adj1} {noun1} who liked {verb1} trees. After a long day from {verb2}, it sat down and took off it's {noun2} It {adverb} {verb3} over to the kitchen to grab a {noun3} from the fridge, tripped over a {noun4} and hit its head on the corner of the {noun5}. It never went back to {verb4} ever again because it was {adj2}. THE END.";
    }
    //this function will prompt user to enter a number and tell the user if there number is odd or even
    [HttpGet]
    [Route("OddOrEven")]
    public string OddEven()
    {   
        return "4 is even";
    }
    //this function will reverse a number or string that user inputs
    [HttpGet]
    [Route("Reverse")]
    public string ReverseIt()
    {
        return "Your word(drink) reversed is: knird. Your number(123) reversed is: 321";
    }
    //this function will ask user guess a number from 1 to 10
    [HttpGet]
    [Route("Guess")]
    public string GuessIt()
    {
        return "8 is too low, try again.";
    }
    //this function will run a Magic8Ball game user will input a question and get a random respose
    [HttpGet]
    [Route("Magic")]
    public string Magic()
    {
        return "Maybe";
    }
    //this function will ask user what type of food they'd like to eat and generate a random restaurant suggestion respective to theri choice.
    [HttpGet]
    [Route("ResPicker")]
    public string ResPicker()
    {
        return "We recomment: Glady's Taqueria.";
    }
}   

