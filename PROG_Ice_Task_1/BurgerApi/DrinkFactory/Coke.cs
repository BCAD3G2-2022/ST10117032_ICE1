using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApi{
public class Coke : IDrink{

public string getDrink(){
    return "Coke";
}


public string Diet(){
    return "Diet";
}

}

}