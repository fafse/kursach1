namespace kursach1
{
    public struct SinglePlayerResult
    {
        public string userName;
        public uint score;

        public SinglePlayerResult(string login, uint points)
        {
            userName = login;
            score = points;
        }

        public SinglePlayerResult(SinglePlayerResult _singlePlayerResult)
        {
            userName = _singlePlayerResult.userName;
            score = _singlePlayerResult.score;
        }

        public override string ToString()
        {
            return userName + " " + score;
        }
    }
}