using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CalculatorReference;
using EjemploSoap.Services;

namespace EjemploSoap.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Calcular : ControllerBase
    {
        [HttpGet]
        public IActionResult Rest(int num1, int num2)
        {
            CalculatorRequest calculatorRequest = new CalculatorRequest();
            int result = calculatorRequest.GetRest(num1, num2);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Multiplicacion(int num1, int num2)
        {
            CalculatorRequest calculatorRequest = new CalculatorRequest();
            int result = calculatorRequest.GetMultiplicacion(num1, num2);
            return Ok(result);
        }

        [HttpPatch]
        public IActionResult Division(int num1, int num2)
        {
            CalculatorRequest calculatorRequest = new CalculatorRequest();
            int result = calculatorRequest.GetDivision(num1, num2);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Sum(int num1, int num2)
        {
            CalculatorRequest calculatorRequest = new CalculatorRequest();
            int result = calculatorRequest.GetSum(num1, num2);
            return Ok(result);
        }

    }


}
