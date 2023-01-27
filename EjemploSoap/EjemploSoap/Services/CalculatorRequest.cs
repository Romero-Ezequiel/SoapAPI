using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using CalculatorReference;

namespace EjemploSoap.Services
{
    public class CalculatorRequest
    {
        public  int GetSum(int num1, int num2)
        {
            var binding = new BasicHttpBinding();
            // Crear una instancia de endpoint
            var endpoint = new EndpointAddress("http://www.dneonline.com/calculator.asmx");
            // Crear una instancia de cliente
            var client = new CalculatorSoapClient(binding, endpoint);
            // Crear una instancia de la clase Add
            var add = new CalculatorReference.AddRequest();
            add.intA = num1;
            add.intB = num2;
            // Llamar al método Add del servicio y retornar resultado
            return client.Add(add).AddResult;
        }


        public int GetRest(int num1, int num2)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress("http://www.dneonline.com/calculator.asmx");
            var client = new CalculatorSoapClient(binding, endpoint);
            var add = new CalculatorReference.SubtractRequest();
            add.intA = num1;
            add.intB = num2;
            return client.Subtract(add).SubtractResult;
        }

        public int GetMultiplicacion(int num1, int num2)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress("http://www.dneonline.com/calculator.asmx");
            var client = new CalculatorSoapClient(binding, endpoint);
            var add = new CalculatorReference.MultiplyRequest();
            add.intA = num1;
            add.intB = num2;
            // Llamar al método Add del servicio y retornar resultado
            return client.Multiply(add).MultiplyResult;
        }

        public int GetDivision(int num1, int num2)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress("http://www.dneonline.com/calculator.asmx");
            var client = new CalculatorSoapClient(binding, endpoint);
            var add = new CalculatorReference.DivideRequest();
            add.intA = num1;
            add.intB = num2;
            return client.Divide(add).DivideResult;

        }


    }




}
