//Kent Tupas
//10/27/2022
// Reverse It API
//Peer Review: Pedro Castaneda - The validation set up is awesome and works great. I like the for loop as the method to reverse the number. I would suggest trying to reverse a string as well. Other than that great work!

using Microsoft.AspNetCore.Mvc;

namespace TupasKReverseItAPI7.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
[HttpGet]
[Route("Reverse/{number}")]

public string Reverse(string number, bool num1 = false, int vaildNum = 0)
{
    num1 = Int32.TryParse(number, out vaildNum);
    if(num1 == true)
    {
        string reverse = "";
        for(int i = number.Length -1; i >= 0; i--)
        {
            reverse += number[i];
        }
        return $" Here is your number in reverse: {reverse}";
        
    }
    return "That's not a number";
}
}



