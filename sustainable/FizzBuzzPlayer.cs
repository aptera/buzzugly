namespace sustainable
{
    class FizzBuzzPlayer
    {
        public string Play(int input)
        {
            string result = "";

            /*
             * if it's neither fizz nor buzz, return the number 
             * as a string
             */
            if (input % 3 != 0 && input % 5 != 0)
            {
                result = input.ToString();

            }

            else if (input % 3 != 0 || input % 5 != 0)
            {

                /*
                 * if we've made it this far and it's not a multiple of 3
                 * it's buzz:
                 */
                if (input % 3 != 0) result = "buzz";

                /*
                 * if we've made it this far and it's not a multiple of 3
                 * it's buzz:
                 */
                else if (input % 5 != 0) { result = "fizz"; }


            }
            else
            {
                // WHAT'S MY NAME
                return "fizzbuzz";
            }

            return result;
        }
    }
}