using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMaker
{
    public abstract class BurgerMaker
    {
        public void MakeBurgerMenu()
        {
            PrepareMeat();
            AddIngreadients();
            AddBread();
            AddSideDish();
            AddDrink();
        }
        protected abstract void PrepareMeat();

        protected abstract void AddIngreadients();

        protected abstract void AddBread();

        protected abstract void AddSideDish();

        protected abstract void AddDrink();
    }
}
