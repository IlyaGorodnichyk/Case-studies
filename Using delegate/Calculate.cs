using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_delegate
{
    //Create delegate
    public delegate void Notification(string messege);
    internal class Calculate
    {
        //Declarete delegate
        Notification? notification;
        
        public void RegistrMetod(Notification del) // Add to delegete metod
        {
            notification += del;
        }
        public void UnregisterMetod(Notification del) // Delete to delegate metod
        { 
            notification -= del;
        }
        public int Add(int x, int y)
        {
            int result = x + y;
            notification?.Invoke($"Sum add: {result}"); //Call delegate
            return result;
        }
        public int Subtraction(int x, int y)
        {
            int result = x - y;
            notification?.Invoke($"Sum Subtraction: {result}"); //Call delegate
            return result;
        }
        public int Multiply(int x, int y)
        {
            int result = x * y;
            notification?.Invoke($"Sum Multiply: {result}"); //Call delegate
            return result;
        }

        public double Dividsion(double x, double y)
        {
            try //Checking division by 0
            {
                double result = x / y;
                notification?.Invoke($"Sum Dividsion: {result}"); //Call delegate
                return result;
            }
            catch (DivideByZeroException) 
            {
                notification?.Invoke("Attempt to divide by zero"); //Call delegate
                return 0;
            }

        }
    }
}
