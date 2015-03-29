package com.paul.dragon;

import com.paul.dragon.classes.Wealth;
import com.paul.dragon.classes.WealthContainer;

import java.util.ArrayList;

class DragonModel {

    public ArrayList<Wealth> getWealthes()
    {
        return WealthContainer.getInstance().getWealthes();
    }

    public Wealth getMostCostableWealth()
    {
        return WealthContainer.getInstance().getMostCostableWealth();
    }

    public ArrayList<Wealth> getWealthesByCost(int cost)
    {
        return WealthContainer.getInstance().getWealthesByCost(cost);
    }

}
