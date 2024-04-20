using System;

namespace Apr162024
{
    internal class Student
    {
        // Class members

        // fields
        public float _obt_marks;
        private static float _max_marks = 200;

        // methods
        public static void MyMethod()
        {
            Console.WriteLine("This is My Method of Student Class...");
        }
        public void TheMethod()
        {
            Console.WriteLine("This is the Method of Student Class...");
        }
        public float ShowPercentage()
        {
            return this._obt_marks / _max_marks * 100;
        }
        public float ShowPercentage(float ObtMarks)
        {
            this._obt_marks = ObtMarks;
            return this._obt_marks / _max_marks * 100;
        }
        public float ShowPercentage(float ObtMarks, float MaxMarks)
        {
            this._obt_marks = ObtMarks;
            _max_marks = MaxMarks;
            return this._obt_marks / _max_marks * 100;
        }
    }
}
