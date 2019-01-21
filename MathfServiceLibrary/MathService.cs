using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MathService : IMathService
    {
        public int Add(MyNumbers obj)
        {
            return (obj.Number1 + obj.Number2);
        }

        public int Divide(MyNumbers obj)
        {
            int result = 0;
            try
            {
                result = obj.Number1 / obj.Number2;
            }
            catch (System.DivideByZeroException dbze)
            {
                throw new DivideByZeroException(dbze.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return (result);
        }

        public int Subtract(MyNumbers obj)
        {
            return (obj.Number1 - obj.Number2);
        }
    }
}
