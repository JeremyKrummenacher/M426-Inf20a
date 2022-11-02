namespace FooBarQix
{
    public class FooBarQixDeterminer
    {

        public string getFoo(int number)
        {
            string result = "";

            if (number % 3 == 0) { result = "Foo"; }
            if (number.ToString().Contains("3")) { result += "Foo"; }
            if (number % 5 == 0) { result += "Bar"; }
            if (number.ToString().Contains("5")) { result += "Bar"; }
            if (number % 7 == 0) { result += "Qix"; }
            if (number.ToString().Contains("7")) { result += "Qix"; }

            if (result == "") { return number.ToString(); }
            return result;
        }

    }
}