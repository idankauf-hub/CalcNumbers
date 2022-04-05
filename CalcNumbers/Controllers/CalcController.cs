using CalcNumbers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalcNumbers.Controllers
{
    public class CalcController : ApiController
    {
        // GET api/<controller>
        public HttpResponseMessage Get(string num1,string num2,string operand)

        {
            int fNum = Int32.Parse(num1);
            int sNum = Int32.Parse(num2);
            string res;
            
            Operand op = new Operand();
            switch (operand)
            {
                case "+":
                    res=op.Add(fNum, sNum);
                    break;
                case "/":
                    res=op.Divide(fNum, sNum);
                    break;
                case "*":
                    res = op.multiply(fNum, sNum);
                    break;
                case "-":
                    res = op.Sub(fNum, sNum);
                    break;
                default:
                    res = "Error";
                    break;
            }
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}