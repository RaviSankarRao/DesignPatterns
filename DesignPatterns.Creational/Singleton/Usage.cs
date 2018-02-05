using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Usage
    {
        public void firstException()
        {
            try
            {
                throw new Exception("first exception");
            }
            catch(Exception ex)
            {
                ExceptionHandler.Instance.WriteException(ex);
            }
        }

        public void secondException()
        {
            try
            {
                throw new Exception("second exception");
            }
            catch (Exception ex)
            {
                ExceptionHandler.Instance.WriteException(ex);
            }
        }
    }
}
