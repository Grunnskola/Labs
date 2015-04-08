package com.paul.gifts.controllers;

import com.paul.gifts.classes.Gift;
import com.paul.gifts.models.GiftModel;
import com.paul.gifts.views.GiftView;

/**
 * Created by 1 on 08.04.2015.
 */
public class GiftController {
    private GiftModel model;
    private GiftView view;

    public GiftController(){
        model = new GiftModel();
        view = new GiftView();
    }

    public void updateView(){
        Gift gift = model.getGift();
        view.printGift(gift);
    }

}
