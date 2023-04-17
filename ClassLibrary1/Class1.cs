namespace class1
{
    public class myStack
    {
        private object[] einträge = new object[100];
        private int index = -1;

        public void push(object eintrag)
        {
            einträge[++index] = eintrag;
            showEinträge();
        }

        public void pop()
        {
            einträge[index--] = null;
            showEinträge();
        }

        private void showEinträge()
        {
            for (int i = index; i>=0; i--)
            {
                Console.WriteLine("<{0}>", einträge[i].ToString());
            }
        }


    }
}