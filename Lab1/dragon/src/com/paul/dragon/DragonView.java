package com.paul.dragon;

import com.paul.dragon.classes.Wealth;

import java.util.ArrayList;

class DragonView {

    public void printWealthes(ArrayList<Wealth> wealthes) {
        for(Wealth wealth : wealthes)
        {
            printWealth(wealth);
        }
    }

    public void printWealth(Wealth wealth) {
        System.out.println("Cost: " + wealth.getCost());
    }

    public void printMessage(String message) {
        System.out.println(message);
    }

}
