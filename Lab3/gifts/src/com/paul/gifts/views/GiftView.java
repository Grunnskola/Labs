package com.paul.gifts.views;

import com.paul.gifts.classes.Gift;
import com.paul.gifts.classes.Product;

/**
 * Created by 1 on 08.04.2015.
 */
public class GiftView {
    public void printGift(Gift gift) {
        System.out.println("Here is "+gift.toString());
        for(Product consistuent: gift.getConstituents()){
            System.out.println("It has got " + consistuent.toString());
        }
    }
}
