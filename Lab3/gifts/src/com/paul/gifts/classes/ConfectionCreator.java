package com.paul.gifts.classes;

/**
 * Created by 1 on 08.04.2015.
 */
public class ConfectionCreator extends Creator {
    @Override
    public Product factoryMethod() {
        return new Confection();
    }
}
