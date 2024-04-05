using System;

namespace Apr042024
{
    class Car
    {
        private string reg_num;
        public string model = "Suzuki";

        public Car(string Reg_Num)
        {
            this.reg_num = Reg_Num;
        }
        public string Get_Reg_Num()
        {
            return this.reg_num;
        }
        public void CarInfo()
        {

        }
    }
}
