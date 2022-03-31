using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApi{

public class DrinkFlavourFactory{

public IDrink returnInstance;

public IDrink getDrinkType(String drinkType){
 switch (drinkType){
  case("Coke"):
  returnInstance = new Coke();
  break;
  case("Fanta"):
  returnInstance = new Fanta();
  break;
  case("Sprite"):
  returnInstance = new Sprite();
  break;
  

}

return returnInstance;

}


}


}