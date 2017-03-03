namespace Practice
{
    class ExponentOf2
    {
        public bool isExponentOf2(uint x)
        {
            if (x == 0)
                return false;

            int count = 0;
            while(x>0)
            {
                if (x % 2 == 1)
                    count++;
                x = x >> 1;
            }

            return count == 1;
        }
    }
}
