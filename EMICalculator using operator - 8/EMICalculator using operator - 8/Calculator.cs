namespace EMICalculator_using_operator___8
{
    public class Calculator
    {
        /// <summary>Emi the calculator.</summary>
        /// <param name="price">The price.</param>
        /// <param name="rate">The rate.</param>
        /// <param name="time">The time.</param>
        /// <returns>
        ///   <br />
        /// </returns>           
       public static float Emi_calculator(float price, float rate, float time)
        {
            float emi;

                rate = rate / (12 * 100);        // one month interest
                time = time * 12;                   // one month period

                emi = (price * rate * (float)Math.Pow(1 + rate, time))
                    / (float)(Math.Pow(1 + rate, time) - 1);                //Mathematical logic

                return (emi);
            }
        }
   }
