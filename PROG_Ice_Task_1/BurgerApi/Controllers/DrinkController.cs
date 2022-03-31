using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApi.Controllers{
    
    [ApiController]
    [Route("[controller]")]

public class DrinkController: ControllerBase{
      
       [HttpGet]
        public List<Drink> Get(string drinkType="plain")
        {

            DrinkFlavourFactory drinkFactory = new DrinkFlavourFactory();
            IDrink drink = drinkFactory.getDrinkType(drinkType);
            
            

        }

        

   }

}