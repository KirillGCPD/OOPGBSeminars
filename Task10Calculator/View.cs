using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task10Calculator
{
    public class View
    {
        ILoggable _logger;
        public View(ILoggable log) {
            _logger = log;
        }
        public void RunView()
        {
            while (true)
            {
                bool flag = true;
                ComplexNumber firstArg = promptComplex("Введите пеpвый аpгумент: ");
                ICalculable result=new ComplexNumber();
                string cmd = Prompt("Введите команду (+, -, *, /): ");
                switch (cmd)
                {
                    case "+":
                        {
                            ComplexNumber arg = promptComplex("Введите втоpой аpгумент: ");
                            result=firstArg.Sum(arg);
                            break;
                        }
                    case "-":
                        {
                            ComplexNumber arg = promptComplex("Введите втоpой аpгумент: ");
                            result = firstArg.Minus(arg);
                            break;
                        }
                    case "*":
                        {
                            ComplexNumber arg = promptComplex("Введите втоpой аpгумент: ");
                            result = firstArg.Multiplicate(arg);
                            break;
                        }
                    case "/":
                        {
                            ComplexNumber arg = promptComplex("Введите втоpой аpгумент: ");
                            result = firstArg.Divide(arg);
                            break;
                        }
                    default:
                        Console.WriteLine("Некорректный ввод");
                        flag = false;
                        break;
                }
                if (flag)
                {
                    _logger.Log("Pезультат " + result.Value());
                    Console.WriteLine("Pезультат: "+result.Value());
                }
                string p = Prompt("Продолжаем (y/n)? ");
                if (p.Equals("n"))
                {
                    break;
                }


            }
        }

        private string Prompt(string msg)
        {
            _logger.Log("Запрос: "+msg);
            Console.WriteLine(msg);
            var resp= Console.ReadLine().ToString();
            _logger.Log("Ответ: "+resp);
            return resp;
        }

        private double promptDouble(string msg)
        {
            _logger.Log("Запрос: " + msg);
            Console.WriteLine(msg);
            double resp= double.Parse(Console.ReadLine().ToString());
            _logger.Log("Ответ: " + resp);
            return resp;
        }

        private ComplexNumber promptComplex(string msg)
        {
            _logger.Log("Запрос: " + msg);
            Console.WriteLine(msg);
            double inputRe = promptDouble("Введите вещественную часть: ");
            double inputIm = promptDouble("Введите мнимую часть: ");
            var resp= new ComplexNumber(inputRe, inputIm);
            _logger.Log("Ответ: " + resp);
            return resp;
        }
    }
}
