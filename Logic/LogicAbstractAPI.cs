﻿namespace Logic
{
    public abstract class LogicAbstractAPI
    {
        public static LogicAbstractAPI CreateAPI()
        {
            return new Table(580, 420);
        }

        public abstract List<IBall> GetBalls();
        public abstract void CreateBalls(int n, int r);
        public abstract void ClearTable();
    }
}
