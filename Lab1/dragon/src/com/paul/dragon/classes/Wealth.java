package com.paul.dragon.classes;

import java.util.Random;

public class Wealth {

    private final int DEFAULT_MAX_WEALTH_COST = 101;//from zero to 100

    public Wealth(String mode)
    {
        if (mode.equals("random"))
        {
            Random random = new Random();
            _cost = random.nextInt(DEFAULT_MAX_WEALTH_COST);
        }
    }

    private int _cost;

    public int getCost()
    {
        return _cost;
    }

    public Wealth setCost(int cost) {
        _cost = cost;
        return this;
    }

}
