using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    // url: localhost:5000/hello
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    // url: localhost:5000/goodbye
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }
    //root path: "/"
    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      myLetterVariable.Location = "Tortuga";
      myLetterVariable.Souvenir = "CLAMS";
      return View(myLetterVariable);
    }
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location = location;
      myLetterVariable.Souvenir = souvenir;
      return View(myLetterVariable);
    }
  }
}