//Elizar Garcia
//10-27-22
//MiniChallengeRestaurantPicker
//In this challenge we will create a list of restaurants that will be randomlu generated for the user.
//peer review: Jacob Dekok - The code looks great, I like how he used switch statements for deciding which place to print. I found no errors and he even planned for when they don't pick one of the options




using Microsoft.AspNetCore.Mvc;

namespace GarciaERestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class PickerController : ControllerBase
{
    [HttpGet]
    [Route("Picker/{foodChoice}")]

    public string Food(string foodChoice)
    {
        string poop ="";

        if(foodChoice == "americanfood")
    {   

        Random rndNumber = new Random();
        int rndNumber1 = rndNumber.Next(1, 10);

        switch(rndNumber1)
        {
            case 1: poop = ("Market Tavern");
             break;
            case 2: poop = ("The Habit");
             break;
            case 3: poop = ("In N Out Burger");
             break;
            case 4: poop = ("Midgley's Public House");
            break;
            case 5: poop = ("Lumberjacks"); 
            break;
            case 6: poop = ("IHop");
            break;
            case 7: poop = ("Denny's");
            break;
            case 8: poop = ("BJ's Restaurant & Brewhouse");
            break;
            case 9: poop = ("Moo Moo's Burger Barn");
            break;
            case 10: poop = ("Whirlows");
            break;
        } 
        

    }
    
     else if(foodChoice == "asianfood" )
    {   

        Random rndNumber = new Random();
        int rndNumber2 = rndNumber.Next(1, 10);

         switch(rndNumber2)
        {
            case 1: poop = ("Prosperity Szechuan Cuisine");
             break;
            case 2: poop = ("New Yen Ching Restaurant");
             break;
            case 3: poop = ("China Palace");
             break;
            case 4: poop = ("Green Papaya");
            break;
            case 5: poop = ("GK Mongolian BBQ"); 
            break;
            case 6: poop = ("Lao, Der");
            break;
            case 7: poop = ("Sushi Villa Buffet");
            break;
            case 8: poop = ("Quickly");
            break;
            case 9: poop = ("Bayon Restaurant");
            break;
            case 10: poop = ("Shome Japenese Cuisine");
            break;
    }
    

}
else if(foodChoice == "mexicanfood")
{   

     Random rndNumber = new Random();
        int rndNumber3 = rndNumber.Next(1, 10);

         switch(rndNumber3)
        {
            case 1: poop = ("Taco Bell");
             break;
            case 2: poop = ("Chapala");
             break;
            case 3: poop = ("Nene's");
             break;
            case 4: poop = ("El Pollo Loco");
            break;
            case 5: poop = ("Casa Flores"); 
            break;
            case 6: poop = ("El Frutal");
            break;
            case 7: poop = ("Taco House");
            break;
            case 8: poop = ("Alberto's Mexican Food");
            break;
            case 9: poop = ("Rubio's Coastal Grill");
            break;
            case 10: poop = ("Don Luis");
            break;
    }
    }else{
        poop = " I swear if you dont pick one of the options I provided im going to poop on you.";
    }
    return poop;
}
}