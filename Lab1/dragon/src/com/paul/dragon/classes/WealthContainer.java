package com.paul.dragon.classes;

import java.awt.image.AreaAveragingScaleFilter;
import java.util.ArrayList;
import java.util.Iterator;

public class WealthContainer {
    private WealthContainer(){}

    public static WealthContainer instance;

    ArrayList<Wealth> _wealthes;

    private final int DEFAULT_WEALTH_COUNT = 10;
    private final int DEFAULT_START_INDEX = 0;

    public static WealthContainer getInstance() {
        if (instance == null)
        {
            instance = new WealthContainer();
            instance.generateWealth();
        }
        return instance;
    }

    private void generateWealth() {
        _wealthes = new ArrayList<>();
        for (int i=DEFAULT_START_INDEX; i<DEFAULT_WEALTH_COUNT; i++)
        {
            _wealthes.add(new Wealth("random"));
        }
    }

    public ArrayList<Wealth> getWealthes() {
        return _wealthes;
    }

    public Wealth getMostCostableWealth() {
        int index = DEFAULT_START_INDEX;
        for (int i=DEFAULT_START_INDEX+1; i<DEFAULT_WEALTH_COUNT; i++)
        {
            if(_wealthes.get(i).getCost() > _wealthes.get(index).getCost())
            {
                index = i;
            }
        }
        return _wealthes.get(index);
    }

    public ArrayList<Wealth> getWealthesByCost(int cost)
    {
        ArrayList<Wealth> wealthesToCost = new ArrayList<>();
        ArrayList<Wealth> bufWealthes = new ArrayList<>(_wealthes);
        boolean searching = true;
        while (searching){
            searching = false;

            for(Iterator<Wealth> iteratorItem = bufWealthes.iterator();iteratorItem.hasNext();)
            {
                int bufcost = iteratorItem.next().getCost();
                if (bufcost < cost)
                {
                    Wealth bufWealth = new Wealth("normal");
                    wealthesToCost.add(bufWealth.setCost(bufcost));
                    cost -= bufcost;

                    iteratorItem.remove();
                    searching = true;
                }
            }
        }
        return wealthesToCost;
    }
}
