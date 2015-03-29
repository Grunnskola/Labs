package com.paul.dragon;

import com.paul.dragon.classes.Wealth;

import java.util.ArrayList;

public class DragonController {
    DragonModel model;
    DragonView view;

    private final int DEFAULT_CHOOSE_COST = 100;

    public DragonController(){
        this.model = new DragonModel();
        this.view = new DragonView();
    }

    public void updateView()
    {
        view.printMessage("All wealthes");
        view.printWealthes(model.getWealthes());

        Wealth mostCostableWealth = model.getMostCostableWealth();
        view.printMessage("Most costable wealth");
        view.printWealth(mostCostableWealth);

        ArrayList<Wealth> wealthesByCost = model.getWealthesByCost(DEFAULT_CHOOSE_COST);
        view.printMessage("Wealthes by cost: " + DEFAULT_CHOOSE_COST);
        view.printWealthes(wealthesByCost);

        view.printMessage("All wealthes");
        view.printWealthes(model.getWealthes());
        //choose
    }


}
