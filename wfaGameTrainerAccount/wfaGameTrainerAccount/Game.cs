namespace wfaGameTrainerAccount
{
    internal class Game
    {
        public int CountCorrect { get; private set; } = 0;
        public int CountWrong { get; private set; } = 0;
        public string CodeText { get; private set; } = "";

        private bool answerCorrect;

        public event EventHandler? Change;

        public void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();
        }

        private void DoContinue()
        {
            Random rnd = new();
            int xValue1 = rnd.Next(20);
            int xValue2 = rnd.Next(20);
            int xResult = xValue1 + xValue2;
            int xResultNew = xResult;

            if (rnd.Next(2) == 1)
            {
                xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
            }

            CodeText = $"{xValue1} + {xValue2} = {xResultNew}";
            answerCorrect = xResult == xResultNew;
            Change?.Invoke(this, EventArgs.Empty);
        }

        public void DoAnswer(bool v)
        {
            if (v == answerCorrect)
            {
                CountCorrect++;
            }
            else
            {
                CountWrong++;
            }DoContinue();
        }
    }
}