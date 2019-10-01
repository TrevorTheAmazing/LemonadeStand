using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.PlayerItems
{
    public class Wallet
    {
        //memb vars
        public bool increase;
        public double amount;
        private double money;
        public double Money
        {
            get => CountMoney();
            set => AdjustMoney(increase, amount);
        }        

        //constructor
        public Wallet()
        {
            this.money = 0.0;
        }

        //memb meths
        //CountMoney() to get a money report
        public double CountMoney()
        {
            return money;
        }

        public double AdjustMoney(bool increase, double amount)
        {
            double tempAmount = amount;
            double tempMoney = CountMoney();
            switch (increase)
            {
                case (false):
                    //decrease money by amount
                    if (tempMoney >= tempAmount)
                    {
                        tempMoney -= tempAmount;
                        return tempMoney;
                    }
                    else
                    {
                        return tempMoney;
                    }
                case (true):
                    //increase money by amount
                    tempMoney += tempAmount;
                    break;
                default:                    
                    break;
            }
            return tempMoney;
        }
    }
}
